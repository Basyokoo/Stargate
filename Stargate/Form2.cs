using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
using BCrypt.Net;

namespace Stargate
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        SQLiteConnection connec = new SQLiteConnection();
        string chcon = @"Data Source=Stargate.db";

        // ══════════════════════════════════════════════════════════════════════
        // SIDEBAR — navigation vers les autres volets
        // ══════════════════════════════════════════════════════════════════════

        private void AjouterNavItems()
        {
            int yBase = 122; int h = 66; int esp = 10;
            pnlSidebar.Controls.Add(CreerNavItem("Tableau de bord",     "loupe.svg",   yBase + (h + esp) * 0, nav_Tableau_Click));
            pnlSidebar.Controls.Add(CreerNavItem("Nouvelle mission",    "mission.svg", yBase + (h + esp) * 1, nav_Mission_Click));
            pnlSidebar.Controls.Add(CreerNavItem("Découverte des races","alien.svg",   yBase + (h + esp) * 2, nav_Races_Click));
            pnlSidebar.Controls.Add(CreerNavItem("Info planètes",       "planet.svg",  yBase + (h + esp) * 3, nav_Planetes_Click));
            pnlSidebar.Controls.Add(CreerNavItem("Statistiques",        "stats.svg",   yBase + (h + esp) * 4, nav_Stats_Click));
        }

        private static StargateControlLibrary.NavItem CreerNavItem(string nom, string svg, int y, EventHandler onClick)
        {
            var item = new StargateControlLibrary.NavItem(nom, svg, System.Drawing.Color.FromArgb(255, 200, 50), System.Drawing.Color.White, onClick);
            item.Location = new System.Drawing.Point(10, y);
            return item;
        }

        private void nav_Tableau_Click(object s, EventArgs e)  { NavHelper.ProchainVolet = null;     this.Close(); }
        private void nav_Mission_Click(object s, EventArgs e)  { /* déjà ici */ }
        private void nav_Races_Click(object s, EventArgs e)    { NavHelper.ProchainVolet = "volet5"; this.Close(); }
        private void nav_Planetes_Click(object s, EventArgs e) { NavHelper.ProchainVolet = "volet6"; this.Close(); }
        private void nav_Stats_Click(object s, EventArgs e)    { NavHelper.ProchainVolet = "volet7"; this.Close(); }

        public string nomPlanete = "";
        public int numMission = 1;
        public int nombreMembres = 0;
        public string dateDepartMission = "";
        public string dateRetourPrevuMission = "";
        public string matriculeChef = "";
        public string feuilleRoute = "";
        public int objData = 0;
        public int Budget = 0;
        public int nombreMembresDisponibles = 0;
        public int nombreMembresRequis = 0;

        // Dictionnaire pour stocker les matricules des membres
        private Dictionary<string, string> matriculesMembres = new Dictionary<string, string>();



        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Ajout des NavItems dans la sidebar
            AjouterNavItems();

            connec.ConnectionString = chcon;
            connec.Open();

            SQLiteCommand cmd_planete = new SQLiteCommand();
            cmd_planete.Connection = connec;
            cmd_planete.CommandType = CommandType.Text;
            cmd_planete.CommandText = "SELECT nom FROM Planete";

            SQLiteDataReader dr_planete = cmd_planete.ExecuteReader();
            while (dr_planete.Read())
            {
                cboChoixPlanete.Items.Add(dr_planete["nom"].ToString());
            }
            dr_planete.Close();

            SQLiteTransaction transaction = connec.BeginTransaction();
            try
            {
                SQLiteCommand cmd_ennemi = new SQLiteCommand();
                cmd_ennemi.Connection = connec;
                cmd_ennemi.Transaction = transaction;
                cmd_ennemi.CommandType = CommandType.Text;
                cmd_ennemi.CommandText = "SELECT e.nom, e.couleur, en.degreAgressivite FROM Espece e " +
                                         "JOIN Ennemi en ON e.id = en.idEspece ORDER BY e.nom";

                SQLiteDataReader dr_ennemi = cmd_ennemi.ExecuteReader();
                while (dr_ennemi.Read())
                {
                    cboObj.Items.Add(dr_ennemi["nom"].ToString() + " - " + dr_ennemi["couleur"].ToString() + " - " + dr_ennemi["degreAgressivite"].ToString());
                }
                dr_ennemi.Close();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erreur lors du chargement des espèces ennemies : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connec.Close();
            }
        }


        private void btnChoixPlanete_Click_1(object sender, EventArgs e)
        {
            if (cboChoixPlanete.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une planète avant de valider votre choix.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grpInfosMission.Visible = true;
            lblChoixPlanete.Enabled = false;
            cboChoixPlanete.Enabled = false;
            btnChoixPlanete.Enabled = false;
            lblNomMission.Enabled = false;

            SQLiteCommand cmd_num_mission = new SQLiteCommand();
            cmd_num_mission.Connection = connec;
            cmd_num_mission.CommandType = CommandType.Text;
            cmd_num_mission.CommandText = "SELECT max(numero) FROM Mission WHERE nomPlanete = @planete";
            cmd_num_mission.Parameters.AddWithValue("@planete", cboChoixPlanete.SelectedItem.ToString());

            connec.Open();
            object result = cmd_num_mission.ExecuteScalar();
            if (result != DBNull.Value && result != null)
            {
                numMission = Convert.ToInt32(result) + 1;
            }

            lblNomMission.Text += " " + cboChoixPlanete.SelectedItem.ToString() + "\t\t - " + numMission;
            nomPlanete = cboChoixPlanete.SelectedItem.ToString();
            connec.Close();
        }

        private void btnValiderInfos_Click(object sender, EventArgs e)
        {
            int nbErreurs = 0;
            string messageErreur = "";
            DateTime Today = DateTime.Today;
            DateTime dateDepart = dateTimePickerDateDepart.Value.Date;
            DateTime dateRetourPrevu = dateTimePickerDateRetourPrevu.Value.Date;

            if (Today > dateDepart)
            {
                messageErreur += "- La date de départ doit être supérieure ou égale à la date d'aujourd'hui.\n";
                nbErreurs++;
            }
            if (dateRetourPrevu < dateDepart)
            {
                messageErreur += "- La date de retour ne peut pas être antérieure à la date de départ.\n";
                nbErreurs++;
            }
            if (txtFeuilleRoute.Text == "")
            {
                messageErreur += "- La feuille de route ne peut pas être vide.\n";
                nbErreurs++;
            }
            if (txtObjData.Text == "")
            {
                messageErreur += "- L'objectif de Databaz de la mission ne peut pas être vide.\n";
                nbErreurs++;
            }
            if (int.TryParse(txtObjData.Text, out int objDataValidation) && objDataValidation == 0)
            {
                messageErreur += "- L'objectif de Databaz ne peut pas être égal à 0.\n";
                nbErreurs++;
            }
            if (txtBudget.Text == "")
            {
                messageErreur += "- Le budget de la mission ne peut pas être vide.\n";
                nbErreurs++;
            }
            if (int.TryParse(txtBudget.Text, out int budget) && budget == 0)
            {
                messageErreur += "- Le budget ne peut pas être égal à 0.\n";
                nbErreurs++;
            }

            if (messageErreur != "" && nbErreurs == 1)
            {
                MessageBox.Show("Une erreur est survenue : \n\n" + messageErreur, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (messageErreur != "" && nbErreurs > 1)
            {
                MessageBox.Show("Plusieurs erreurs sont survenues : \n\n" + messageErreur, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblParametreMission.Enabled = false;
                lblDateDepart.Enabled = false;
                lblDateRetourPrevu.Enabled = false;
                dateTimePickerDateDepart.Enabled = false;
                dateTimePickerDateRetourPrevu.Enabled = false;
                lblFeuilleRoute.Enabled = false;
                txtFeuilleRoute.Enabled = false;
                lblObjData.Enabled = false;
                lblBudget.Enabled = false;
                txtObjData.Enabled = false;
                txtBudget.Enabled = false;
                lblTonnes.Enabled = false;
                lblEuro.Enabled = false;
                btnValiderInfos.Enabled = false;

                dateDepartMission = dateTimePickerDateDepart.Value.Date.ToString("yyyy-MM-dd");
                dateRetourPrevuMission = dateTimePickerDateRetourPrevu.Value.Date.ToString("yyyy-MM-dd");
                feuilleRoute = txtFeuilleRoute.Text;
                objData = int.Parse(txtObjData.Text);
                Budget = int.Parse(txtBudget.Text);

                cboChoixChef.Items.Clear();
                connec.Open();

                SQLiteCommand cmd_chef_dispo = new SQLiteCommand();
                cmd_chef_dispo.Connection = connec;
                cmd_chef_dispo.CommandType = CommandType.Text;
                cmd_chef_dispo.CommandText = "SELECT m.nom, m.prenom, mil.grade FROM Membre m " +
                                             "JOIN Militaire mil ON m.matricule = mil.matriculeMembre " +
                                             "WHERE m.matricule LIKE 'M%' " +
                                             "AND m.matricule NOT IN ( " +
                                             "    SELECT c.matriculeMembre FROM Composer c " +
                                             "    JOIN Mission mis ON c.nomPlanete = mis.nomPlanete AND c.numeroMission = mis.numero " +
                                             "    WHERE mis.dateDepart <= @dateRetour " +
                                             "    AND mis.dateRetour >= @dateDepart " +
                                             ") ORDER BY m.nom, m.prenom";
                cmd_chef_dispo.Parameters.AddWithValue("@dateDepart", dateDepartMission);
                cmd_chef_dispo.Parameters.AddWithValue("@dateRetour", dateRetourPrevuMission);

                SQLiteDataReader dr_chef_dispo = cmd_chef_dispo.ExecuteReader();
                while (dr_chef_dispo.Read())
                {
                    cboChoixChef.Items.Add(dr_chef_dispo["nom"].ToString() + " " + dr_chef_dispo["prenom"].ToString() + " - " + dr_chef_dispo["grade"].ToString());
                }
                dr_chef_dispo.Close();


                SQLiteCommand cmd_nb_dispo = new SQLiteCommand();
                cmd_nb_dispo.Connection = connec;
                cmd_nb_dispo.CommandType = CommandType.Text;
                cmd_nb_dispo.CommandText = "SELECT COUNT(*) FROM Membre m " +
                                           "WHERE m.matricule NOT IN ( " +
                                           "    SELECT c.matriculeMembre FROM Composer c " +
                                           "    JOIN Mission mis ON c.nomPlanete = mis.nomPlanete AND c.numeroMission = mis.numero " +
                                           "    WHERE mis.dateDepart <= @dateRetour " +
                                           "    AND mis.dateRetour >= @dateDepart " +
                                           ")";
                cmd_nb_dispo.Parameters.AddWithValue("@dateDepart", dateDepartMission);
                cmd_nb_dispo.Parameters.AddWithValue("@dateRetour", dateRetourPrevuMission);
                nombreMembresDisponibles = Convert.ToInt32(cmd_nb_dispo.ExecuteScalar());

                connec.Close();

                grpChoixChef.Visible = true;
            }
        }

        private void btnValiderChef_Click(object sender, EventArgs e)
        {
            string messageErreur = "";
            int nbErreurs = 0;

            if (cboChoixChef.SelectedItem == null)
            {
                messageErreur += "- Veuillez sélectionner un chef de mission avant de valider votre choix.\n";
                return;
            }

            if (txtNbMembres.Text == "")
            {
                messageErreur += "- Le nombre de membres ne peut pas être vide.\n";
                return;
            }
            if (int.TryParse(txtNbMembres.Text, out int nbMembres))
            {
                if (nbMembres == 0)
                {
                    messageErreur += "- Le nombre de membres ne peut pas être égal à 0.\n";
                    nbErreurs++;
                }
                if (nbMembres > nombreMembresDisponibles)
                {
                    messageErreur += "- Le nombre de membres (" + nbMembres + ") ne peut pas dépasser le nombre de membres disponibles sur la période (" + nombreMembresDisponibles + ").\n";
                    nbErreurs++;
                }
            }

            if (messageErreur != "" && nbErreurs == 1)
            {
                MessageBox.Show("Une erreur est survenue : \n\n" + messageErreur, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (messageErreur != "" && nbErreurs > 1)
            {
                MessageBox.Show("Plusieurs erreurs sont survenues : \n\n" + messageErreur, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblChoixChef.Enabled = false;
            cboChoixChef.Enabled = false;
            btnValiderChef.Enabled = false;
            lblPersonnes.Enabled = false;
            txtNbMembres.Enabled = false;
            lblNbMembres.Enabled = false;
            lblChef.Enabled = false;

            nombreMembres = int.Parse(txtNbMembres.Text);
            nombreMembresRequis = nombreMembres;
            lblAffectationMembre.Text += " " + (nombreMembres - 1).ToString();

            connec.Open();

            SQLiteCommand cmd_matricule_chef = new SQLiteCommand();
            cmd_matricule_chef.Connection = connec;
            cmd_matricule_chef.CommandType = CommandType.Text;
            cmd_matricule_chef.CommandText = "SELECT m.matricule FROM Membre m JOIN Militaire mil ON m.matricule=mil.matriculeMembre " +
                                             "WHERE m.matricule LIKE 'M%' AND m.nom || ' ' || m.prenom || ' - ' || mil.grade = @chef";
            cmd_matricule_chef.Parameters.AddWithValue("@chef", cboChoixChef.SelectedItem.ToString());
            matriculeChef = cmd_matricule_chef.ExecuteScalar().ToString();

            // Réinitialiser le dictionnaire
            matriculesMembres.Clear();

            // Militaires disponibles (hors chef)
            SQLiteCommand cmd_militaire = new SQLiteCommand();
            cmd_militaire.Connection = connec;
            cmd_militaire.CommandType = CommandType.Text;
            cmd_militaire.CommandText = "SELECT m.matricule, m.nom, m.prenom, mil.grade FROM Membre m " +
                                        "JOIN Militaire mil ON m.matricule = mil.matriculeMembre " +
                                        "WHERE m.matricule LIKE 'M%' " +
                                        "AND m.matricule != @chef " +
                                        "AND m.matricule NOT IN ( " +
                                        "    SELECT c.matriculeMembre FROM Composer c " +
                                        "    JOIN Mission mis ON c.nomPlanete = mis.nomPlanete AND c.numeroMission = mis.numero " +
                                        "    WHERE mis.dateDepart <= @dateRetour " +
                                        "    AND mis.dateRetour >= @dateDepart " +
                                        ") ORDER BY m.nom, m.prenom";
            cmd_militaire.Parameters.AddWithValue("@chef", matriculeChef);
            cmd_militaire.Parameters.AddWithValue("@dateDepart", dateDepartMission);
            cmd_militaire.Parameters.AddWithValue("@dateRetour", dateRetourPrevuMission);

            SQLiteDataReader dr_militaire = cmd_militaire.ExecuteReader();
            while (dr_militaire.Read())
            {
                string display = dr_militaire["nom"].ToString() + " " + dr_militaire["prenom"].ToString() + " - " + dr_militaire["grade"].ToString();
                string matricule = dr_militaire["matricule"].ToString();
                cboAffecterMembre.Items.Add(display);
                matriculesMembres[display] = matricule;
            }
            dr_militaire.Close();

            // Civils disponibles
            SQLiteCommand cmd_civil = new SQLiteCommand();
            cmd_civil.Connection = connec;
            cmd_civil.CommandType = CommandType.Text;
            cmd_civil.CommandText = "SELECT m.matricule, m.nom, m.prenom, c.Specialite FROM Membre m " +
                                    "JOIN Civil c ON m.matricule = c.matriculeMembre " +
                                    "WHERE m.matricule NOT LIKE 'M%' " +
                                    "AND m.matricule NOT IN ( " +
                                    "    SELECT c2.matriculeMembre FROM Composer c2 " +
                                    "    JOIN Mission mis ON c2.nomPlanete = mis.nomPlanete AND c2.numeroMission = mis.numero " +
                                    "    WHERE mis.dateDepart <= @dateRetour " +
                                    "    AND mis.dateRetour >= @dateDepart " +
                                    ") ORDER BY m.nom, m.prenom";
            cmd_civil.Parameters.AddWithValue("@dateDepart", dateDepartMission);
            cmd_civil.Parameters.AddWithValue("@dateRetour", dateRetourPrevuMission);

            SQLiteDataReader dr_civil = cmd_civil.ExecuteReader();
            while (dr_civil.Read())
            {
                string display = dr_civil["nom"].ToString() + " " + dr_civil["prenom"].ToString() + " - " + dr_civil["Specialite"].ToString();
                string matricule = dr_civil["matricule"].ToString();
                cboAffecterMembre.Items.Add(display);
                matriculesMembres[display] = matricule;
            }
            dr_civil.Close();

            connec.Close();

            grpChoixMembres.Visible = true;

            if (nombreMembres == 1)
            {
                grpObjCaptures.Visible = true;
                lblAffectationMembre.Enabled = false;
                cboAffecterMembre.Enabled = false;
                btnValiderMembre.Enabled = false;
                btnSupprimerMembre.Enabled = false;
                btnValiderMembreMission.Enabled = false;
                lboListeMembre.Enabled = false;
            }
        }

        private void btnValiderMembreMission_Click(object sender, EventArgs e)
        {
            if (nombreMembres - 1 > 0)
            {
                if (nombreMembres - 1 == 1)
                    MessageBox.Show("Il reste " + (nombreMembres - 1).ToString() + " membre à affecter à la mission.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Il reste " + (nombreMembres - 1).ToString() + " membres à affecter à la mission.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblAffectationMembre.Enabled = false;
                cboAffecterMembre.Enabled = false;
                btnValiderMembre.Enabled = false;
                lboListeMembre.Enabled = false;
                btnSupprimerMembre.Enabled = false;
                btnValiderMembreMission.Enabled = false;
                grpObjCaptures.Visible = true;
            }
        }

        private void btnValiderObjMission_Click(object sender, EventArgs e)
        {
            lblObj.Enabled = false;
            cboObj.Enabled = false;
            txtQuantiteObj.Enabled = false;
            btnValiderObj.Enabled = false;
            lboListeObj.Enabled = false;
            btnSupprimerObj.Enabled = false;
            btnValiderObjMission.Enabled = false;
            grpBoutonFinal.Visible = true;
        }

        private void btnValiderMission_Click(object sender, EventArgs e)
        {
            connec.Open();
            SQLiteTransaction transaction = connec.BeginTransaction();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = connec;
                cmd.Transaction = transaction;

                // 1. Insertion de la mission
                cmd.CommandText = "INSERT INTO Mission (nomPlanete, numero, nbMembreRequis, dateDepart, dateRetour, matriculeChef, feuilleDeRoute, objectifDatabaz, budget) " +
                                  "VALUES (@planete, @num, @nbMembres, @depart, @retour, @chef, @feuille, @objData, @budget)";
                cmd.Parameters.AddWithValue("@planete", nomPlanete);
                cmd.Parameters.AddWithValue("@num", numMission);
                cmd.Parameters.AddWithValue("@nbMembres", nombreMembresRequis);
                cmd.Parameters.AddWithValue("@depart", dateDepartMission);
                cmd.Parameters.AddWithValue("@retour", dateRetourPrevuMission);
                cmd.Parameters.AddWithValue("@chef", matriculeChef);
                cmd.Parameters.AddWithValue("@feuille", feuilleRoute);
                cmd.Parameters.AddWithValue("@objData", objData);
                cmd.Parameters.AddWithValue("@budget", Budget);
                cmd.ExecuteNonQuery();

                // 2. Insertion du chef dans Composer
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO Composer (nomPlanete, numeroMission, matriculeMembre) VALUES (@planete, @num, @matricule)";
                cmd.Parameters.AddWithValue("@planete", nomPlanete);
                cmd.Parameters.AddWithValue("@num", numMission);
                cmd.Parameters.AddWithValue("@matricule", matriculeChef);
                cmd.ExecuteNonQuery();

                // 3. Insertion des membres depuis lboListeMembre via le dictionnaire
                foreach (var item in lboListeMembre.Items)
                {
                    string display = item.ToString();

                    if (!matriculesMembres.TryGetValue(display, out string matriculeMembre))
                    {
                        throw new Exception("Matricule introuvable pour le membre : " + display);
                    }

                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO Composer (nomPlanete, numeroMission, matriculeMembre) VALUES (@planete, @num, @matricule)";
                    cmd.Parameters.AddWithValue("@planete", nomPlanete);
                    cmd.Parameters.AddWithValue("@num", numMission);
                    cmd.Parameters.AddWithValue("@matricule", matriculeMembre);
                    cmd.ExecuteNonQuery();
                }

                // 4. Insertion des objectifs de capture depuis lboListeObj
                foreach (var item in lboListeObj.Items)
                {
                    string nomEspece = item.ToString().Split('-')[0].Trim();
                    string quantite = item.ToString().Split(':')[2].Trim();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT e.id FROM Espece e WHERE e.nom = @nom";
                    cmd.Parameters.AddWithValue("@nom", nomEspece);
                    int idEspece = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO ObjectifCapture (nomPlanete, numeroMission, idEspeceEnnemi, objectif) " +
                                      "VALUES (@planete, @num, @idEspece, @objectif)";
                    cmd.Parameters.AddWithValue("@planete", nomPlanete);
                    cmd.Parameters.AddWithValue("@num", numMission);
                    cmd.Parameters.AddWithValue("@idEspece", idEspece);
                    cmd.Parameters.AddWithValue("@objectif", int.Parse(quantite));
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Mission créée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erreur lors de la création de la mission : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connec.Close();
            }
        }


        private void txtNbMembres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (txtNbMembres.Text.Length < 9 || e.KeyChar == (char)Keys.Back)
                    e.Handled = false;
            }
        }

        private void txtObjData_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (txtObjData.Text.Length < 9 || e.KeyChar == (char)Keys.Back)
                    e.Handled = false;
            }
        }


        private void txtBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (txtBudget.Text.Length < 9 || e.KeyChar == (char)Keys.Back)
                    e.Handled = false;
            }
        }

        private void btnValiderMembre_Click(object sender, EventArgs e)
        {
            if (cboAffecterMembre.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un membre à affecter à la mission.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lboListeMembre.Items.Add(cboAffecterMembre.SelectedItem);
            cboAffecterMembre.Items.Remove(cboAffecterMembre.SelectedItem);
            nombreMembres--;
            if (nombreMembres - 1 == 1)
                lblAffectationMembre.Text = "Affectation des membres à la mission - reste à affecter : " + (nombreMembres - 1).ToString() + " membre";
            else
                lblAffectationMembre.Text = "Affectation des membres à la mission - reste à affecter : " + (nombreMembres - 1).ToString() + " membres";

            if (nombreMembres - 1 == 0)
                btnValiderMembre.Enabled = false;
        }

        private void btnSupprimerMembre_Click(object sender, EventArgs e)
        {
            if (lboListeMembre.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un membre à supprimer de la mission.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cboAffecterMembre.Items.Add(lboListeMembre.SelectedItem);
            nombreMembres++;
            lboListeMembre.Items.Remove(lboListeMembre.SelectedItem);
            if (nombreMembres - 1 == 1)
                lblAffectationMembre.Text = "Affectation des membres à la mission - reste à affecter : " + (nombreMembres - 1).ToString() + " membre";
            else
                lblAffectationMembre.Text = "Affectation des membres à la mission - reste à affecter : " + (nombreMembres - 1).ToString() + " membres";

            if (nombreMembres - 1 > 0)
                btnValiderMembre.Enabled = true;
        }

        private void btnValiderObj_Click(object sender, EventArgs e)
        {
            int nbErreurs = 0;
            string messageErreur = "";
            if (txtQuantiteObj.Text == "")
            {
                messageErreur += "- La quantité de l'objectif ne peut pas être vide.\n";
                nbErreurs++;
            }
            if (cboObj.SelectedItem == null)
            {
                messageErreur += "- Veuillez sélectionner un objectif de capture à ajouter à la mission.\n";
                nbErreurs++;
            }

            if (nbErreurs == 1)
                MessageBox.Show("Une erreur est survenue : \n\n" + messageErreur, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (nbErreurs > 1)
                MessageBox.Show("Plusieurs erreurs sont survenues : \n\n" + messageErreur, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                lboListeObj.Items.Add(cboObj.SelectedItem + " : Quantité : " + txtQuantiteObj.Text);
                cboObj.Items.Remove(cboObj.SelectedItem);
                txtQuantiteObj.Text = "";
            }
        }

        private void txtQuantiteObj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (txtQuantiteObj.Text.Length < 9 || e.KeyChar == (char)Keys.Back)
                    e.Handled = false;
            }
        }

        private void btnSupprimerObj_Click(object sender, EventArgs e)
        {
            if (lboListeObj.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un objectif de capture à supprimer de la mission.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cboObj.Items.Add(lboListeObj.SelectedItem.ToString().Split(':')[0].Trim());
            lboListeObj.Items.Remove(lboListeObj.SelectedItem);
        }

        private void pnlMission_Paint(object sender, PaintEventArgs e) { }
        private void cboChoixChef_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void lblParametreMission_Click(object sender, EventArgs e) { }
        private void lblDateDepart_Click(object sender, EventArgs e) { }
        private void lblDateRetourPrevu_Click(object sender, EventArgs e) { }
        private void lblFeuilleRoute_Click(object sender, EventArgs e) { }
        private void dateTimePickerDateRetourPrevu_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePickerDateDepart_ValueChanged(object sender, EventArgs e) { }
        private void txtFeuilleRoute_TextChanged(object sender, EventArgs e) { }
        private void lblNbMembres_Click(object sender, EventArgs e) { }
        private void lblPersonnes_Click(object sender, EventArgs e) { }
        private void lblObjData_Click(object sender, EventArgs e) { }
        private void lblTonnes_Click(object sender, EventArgs e) { }
        private void lblEuro_Click(object sender, EventArgs e) { }
        private void lblBudget_Click(object sender, EventArgs e) { }
        private void lblAffectationMembre_Click(object sender, EventArgs e) { }
        private void cboAffecterMembre_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lboListeMembre_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lboListeObj_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblObj_Click(object sender, EventArgs e) { }
        private void cboObj_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblChoixChef_Click(object sender, EventArgs e) { }
        private void txtObjData_TextChanged(object sender, EventArgs e) { }
        private void txtNbMembres_TextChanged(object sender, EventArgs e) { }
        private void txtBudget_TextChanged(object sender, EventArgs e) { }

    }
}