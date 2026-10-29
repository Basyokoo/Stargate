using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using StargateControlLibrary;

namespace Stargate
{
    public partial class volet5 : Form
    {
        private SQLiteConnection conn = new SQLiteConnection("Data Source=Stargate.db;Version=3;");

        // ── Sidebar ──────────────────────────────────────────────────────────
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
            var item = new StargateControlLibrary.NavItem(nom, svg, System.Drawing.Color.FromArgb(255,200,50), System.Drawing.Color.White, onClick);
            item.Location = new System.Drawing.Point(10, y);
            return item;
        }

        private void nav_Tableau_Click(object s, EventArgs e)  { NavHelper.ProchainVolet = null;     this.Close(); }
        private void nav_Mission_Click(object s, EventArgs e)  { NavHelper.ProchainVolet = "volet2"; this.Close(); }
        private void nav_Races_Click(object s, EventArgs e)    { /* déjà ici */ }
        private void nav_Planetes_Click(object s, EventArgs e) { NavHelper.ProchainVolet = "volet6"; this.Close(); }
        private void nav_Stats_Click(object s, EventArgs e)    { NavHelper.ProchainVolet = "volet7"; this.Close(); }

        public volet5()
        {
            InitializeComponent();
        }

        private void volet6_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Ajout des NavItems dans la sidebar
            AjouterNavItems();

            RemplirFiltres();
            RemplirFiltresDegresCouleurEtPlanete();

            cboInstrument.Visible = false;
            cboArme.Visible = false;
            cboDegresBienveillance.Visible = false;
            cboDegresAgressivité.Visible = false;
            lblAgro.Visible = false;
            lblBien.Visible = false;
        }

        private void RemplirFiltres()
        {
            try
            {
                conn.Open();

                DataTable dtAllies = new DataTable();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT DISTINCT instrumentMusique FROM Allie WHERE instrumentMusique IS NOT NULL AND instrumentMusique <> ''", conn))
                {
                    adapter.Fill(dtAllies);
                }
                cboInstrument.Items.Clear();
                cboInstrument.Items.Add("Aucun");
                foreach (DataRow row in dtAllies.Rows)
                {
                    cboInstrument.Items.Add(row["instrumentMusique"].ToString());
                }

                DataTable dtEnnemis = new DataTable();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT DISTINCT typeArme FROM Ennemi WHERE typeArme IS NOT NULL AND typeArme <> ''", conn))
                {
                    adapter.Fill(dtEnnemis);
                }
                cboArme.Items.Clear();
                cboArme.Items.Add("Aucun");
                foreach (DataRow row in dtEnnemis.Rows)
                {
                    cboArme.Items.Add(row["typeArme"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement des filtres : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void RemplirFiltresDegresCouleurEtPlanete()
        {
            try
            {
                conn.Open();

                cboCouleur.Items.Clear();
                cboCouleur.Items.Add("Aucun");
                DataTable dtCouleurs = new DataTable();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT DISTINCT couleur FROM Espece WHERE couleur IS NOT NULL AND couleur <> ''", conn))
                {
                    adapter.Fill(dtCouleurs);
                }
                foreach (DataRow row in dtCouleurs.Rows)
                {
                    cboCouleur.Items.Add(row["couleur"].ToString());
                }

                cboDegresBienveillance.Items.Clear();
                cboDegresBienveillance.Items.Add("Aucun");
                DataTable dtBienveillance = new DataTable();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT DISTINCT degreBienveillance FROM Allie WHERE degreBienveillance IS NOT NULL", conn))
                {
                    adapter.Fill(dtBienveillance);
                }
                foreach (DataRow row in dtBienveillance.Rows)
                {
                    cboDegresBienveillance.Items.Add(row["degreBienveillance"].ToString());
                }

                cboDegresAgressivité.Items.Clear();
                cboDegresAgressivité.Items.Add("Aucun");
                DataTable dtAgressivite = new DataTable();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT DISTINCT degreAgressivite FROM Ennemi WHERE degreAgressivite IS NOT NULL", conn))
                {
                    adapter.Fill(dtAgressivite);
                }
                foreach (DataRow row in dtAgressivite.Rows)
                {
                    cboDegresAgressivité.Items.Add(row["degreAgressivite"].ToString());
                }

                // Récupération des planètes depuis la table Planete
                cboTriePlanete.Items.Clear();
                cboTriePlanete.Items.Add("Aucun");
                DataTable dtPlanetes = new DataTable();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT nom FROM Planete WHERE nom IS NOT NULL AND nom <> ''", conn))
                {
                    adapter.Fill(dtPlanetes);
                }
                foreach (DataRow row in dtPlanetes.Rows)
                {
                    cboTriePlanete.Items.Add(row["nom"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement des filtres secondaires : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ActualiserTrombinoscope()
        {
            flpAlien.Controls.Clear();

            try
            {
                conn.Open();

                string filtreNom = txtFiltreNom.Text.Trim();

                // Si une planète est sélectionnée, on affiche toutes ses espèces (alliés + ennemis)
                bool montrerAllies = chkAlliés.Checked || cboTriePlanete.SelectedIndex > 0;
                bool montrerEnnemis = chkEnemis.Checked || cboTriePlanete.SelectedIndex > 0;

                if (montrerAllies)
                {
                    // Jointure via la table intermédiaire 'Habiter' comme indiqué sur ton schéma
                    string sql = @"
                        SELECT DISTINCT E.id, E.nom, E.couleur, A.degreBienveillance, A.instrumentMusique, A.datePremierContact
                        FROM Espece E
                        INNER JOIN Allie A ON E.id = A.idEspece
                        LEFT JOIN Habiter H ON E.id = H.idEspece
                        WHERE 1=1";

                    if (cboInstrument.SelectedIndex > 0) sql += " AND A.instrumentMusique = @instrument";
                    if (cboCouleur.SelectedIndex > 0) sql += " AND E.couleur = @couleur";
                    if (cboDegresBienveillance.SelectedIndex > 0) sql += " AND A.degreBienveillance = @bienveillance";
                    if (cboTriePlanete.SelectedIndex > 0) sql += " AND H.nomPlanete = @planete";
                    if (!string.IsNullOrEmpty(filtreNom)) sql += " AND E.nom LIKE @nom";

                    DataTable dt = new DataTable();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn))
                    {
                        if (cboInstrument.SelectedIndex > 0) adapter.SelectCommand.Parameters.AddWithValue("@instrument", cboInstrument.SelectedItem.ToString());
                        if (cboCouleur.SelectedIndex > 0) adapter.SelectCommand.Parameters.AddWithValue("@couleur", cboCouleur.SelectedItem.ToString());
                        if (cboDegresBienveillance.SelectedIndex > 0) adapter.SelectCommand.Parameters.AddWithValue("@bienveillance", cboDegresBienveillance.SelectedItem.ToString());
                        if (cboTriePlanete.SelectedIndex > 0) adapter.SelectCommand.Parameters.AddWithValue("@planete", cboTriePlanete.SelectedItem.ToString());
                        if (!string.IsNullOrEmpty(filtreNom)) adapter.SelectCommand.Parameters.AddWithValue("@nom", "%" + filtreNom + "%");
                        adapter.Fill(dt);
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        Alien carte = new Alien(
                            row["nom"].ToString(),
                            row["id"].ToString(),
                            row["degreBienveillance"].ToString(),
                            row["instrumentMusique"].ToString(),
                            "Non",
                            row["datePremierContact"].ToString()
                        );
                        string couleurA = row["couleur"] != DBNull.Value ? row["couleur"].ToString() : "";
                        if (!string.IsNullOrEmpty(couleurA))
                            carte.ChargImage(System.IO.Path.Combine(Application.StartupPath, "Alien", couleurA + ".png"));
                        flpAlien.Controls.Add(carte);
                    }
                }

                if (montrerEnnemis)
                {
                    // Même logique de jointure pour les ennemis
                    string sql = @"
                        SELECT DISTINCT E.id, E.nom, E.couleur, EN.degreAgressivite, EN.typeArme
                        FROM Espece E
                        INNER JOIN Ennemi EN ON E.id = EN.idEspece
                        LEFT JOIN Habiter H ON E.id = H.idEspece
                        WHERE 1=1";

                    if (cboArme.SelectedIndex > 0) sql += " AND EN.typeArme = @arme";
                    if (cboCouleur.SelectedIndex > 0) sql += " AND E.couleur = @couleur";
                    if (cboDegresAgressivité.SelectedIndex > 0) sql += " AND EN.degreAgressivite = @agressivite";
                    if (cboTriePlanete.SelectedIndex > 0) sql += " AND H.nomPlanete = @planete";
                    if (!string.IsNullOrEmpty(filtreNom)) sql += " AND E.nom LIKE @nom";

                    DataTable dt = new DataTable();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn))
                    {
                        if (cboArme.SelectedIndex > 0) adapter.SelectCommand.Parameters.AddWithValue("@arme", cboArme.SelectedItem.ToString());
                        if (cboCouleur.SelectedIndex > 0) adapter.SelectCommand.Parameters.AddWithValue("@couleur", cboCouleur.SelectedItem.ToString());
                        if (cboDegresAgressivité.SelectedIndex > 0) adapter.SelectCommand.Parameters.AddWithValue("@agressivite", cboDegresAgressivité.SelectedItem.ToString());
                        if (cboTriePlanete.SelectedIndex > 0) adapter.SelectCommand.Parameters.AddWithValue("@planete", cboTriePlanete.SelectedItem.ToString());
                        if (!string.IsNullOrEmpty(filtreNom)) adapter.SelectCommand.Parameters.AddWithValue("@nom", "%" + filtreNom + "%");
                        adapter.Fill(dt);
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        Alien carte = new Alien(
                            row["nom"].ToString(),
                            row["id"].ToString(),
                            row["degreAgressivite"].ToString(),
                            row["typeArme"].ToString(),
                            "Oui"
                        );
                        string couleurE = row["couleur"] != DBNull.Value ? row["couleur"].ToString() : "";
                        if (!string.IsNullOrEmpty(couleurE))
                            carte.ChargImage(System.IO.Path.Combine(Application.StartupPath, "Alien", couleurE + ".png"));
                        flpAlien.Controls.Add(carte);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des aliens : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnResetFiltre_Click(object sender, EventArgs e)
        {
            chkAlliés.Checked = false;
            chkEnemis.Checked = false;

            cboInstrument.SelectedIndex = -1;
            cboArme.SelectedIndex = -1;
            cboCouleur.SelectedIndex = -1;
            cboDegresBienveillance.SelectedIndex = -1;
            cboDegresAgressivité.SelectedIndex = -1;
            cboTriePlanete.SelectedIndex = -1;
            txtFiltreNom.Text = "";

            flpAlien.Controls.Clear();
        }

        private void chkAlliés_CheckedChanged(object sender, EventArgs e)
        {
            cboInstrument.Visible = chkAlliés.Checked;
            cboDegresBienveillance.Visible = chkAlliés.Checked;
            lblBien.Visible = chkAlliés.Checked;

            if (!chkAlliés.Checked)
            {
                cboInstrument.SelectedIndex = -1;
                cboDegresBienveillance.SelectedIndex = -1;
            }
            ActualiserTrombinoscope();
        }

        private void chkEnemis_CheckedChanged(object sender, EventArgs e)
        {
            cboArme.Visible = chkEnemis.Checked;
            cboDegresAgressivité.Visible = chkEnemis.Checked;
            lblAgro.Visible = chkEnemis.Checked;

            if (!chkEnemis.Checked)
            {
                cboArme.SelectedIndex = -1;
                cboDegresAgressivité.SelectedIndex = -1;
            }
            ActualiserTrombinoscope();
        }

        private void cboInstrument_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserTrombinoscope();
        }

        private void cboArme_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserTrombinoscope();
        }

        private void cboCouleur_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserTrombinoscope();
        }

        private void cboDegresBienveillance_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserTrombinoscope();
        }

        private void cboDegresAgressivité_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserTrombinoscope();
        }

        private void cboTriePlanete_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserTrombinoscope();
        }

        private void txtFiltreNom_TextChanged(object sender, EventArgs e)
        {
            ActualiserTrombinoscope();
        }
    }
}