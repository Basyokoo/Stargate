using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Stargate
{
    // Volet 7 : Données statistiques
    // Toutes les requêtes statistiques demandées dans le cahier des charges
    public partial class Form7 : Form
    {
        private const string CONN_STRING = "Data Source=Stargate.db;Version=3;";

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
            var item = new StargateControlLibrary.NavItem(nom, svg, Color.FromArgb(255,200,50), Color.White, onClick);
            item.Location = new System.Drawing.Point(10, y);
            return item;
        }

        private void nav_Tableau_Click(object s, EventArgs e)  { NavHelper.ProchainVolet = null;     this.Close(); }
        private void nav_Mission_Click(object s, EventArgs e)  { NavHelper.ProchainVolet = "volet2"; this.Close(); }
        private void nav_Races_Click(object s, EventArgs e)    { NavHelper.ProchainVolet = "volet5"; this.Close(); }
        private void nav_Planetes_Click(object s, EventArgs e) { NavHelper.ProchainVolet = "volet6"; this.Close(); }
        private void nav_Stats_Click(object s, EventArgs e)    { /* déjà ici */ }

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Ajout des NavItems dans la sidebar
            AjouterNavItems();

            // Charger la liste des membres dans la ComboBox (requête 1)
            ChargerListeMembres();

            // Afficher par défaut la requête 1 au chargement
            tabControl1.SelectedIndex = 0;
        }

        // ============================================================
        // UTILITAIRE : exécuter une requête et remplir un DataGridView
        // ============================================================
        private void ExecuterRequete(string sql, DataGridView dgv, SQLiteParameter[] parametres = null)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(CONN_STRING))
                {
                    conn.Open();
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
                    if (parametres != null)
                        da.SelectCommand.Parameters.AddRange(parametres);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;

                    // Style visuel cohérent avec le reste du projet
                    dgv.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 45);
                    dgv.DefaultCellStyle.ForeColor = Color.White;
                    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 100, 160);
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 60);
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 60, 100);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // REQUÊTE 1 : Membres partis en mission avec un membre donné
        // ============================================================
        private void ChargerListeMembres()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(CONN_STRING))
                {
                    conn.Open();
                    string sql = "SELECT matricule, nom || ' ' || prenom AS nomComplet FROM Membre ORDER BY nom, prenom";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    cmbMembre.Items.Clear();
                    cmbMembre.DisplayMember = "nomComplet";
                    cmbMembre.ValueMember = "matricule";

                    DataTable dt = new DataTable();
                    dt.Columns.Add("matricule");
                    dt.Columns.Add("nomComplet");

                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["matricule"] = reader["matricule"].ToString();
                        row["nomComplet"] = reader["nomComplet"].ToString();
                        dt.Rows.Add(row);
                    }
                    reader.Close();

                    cmbMembre.DataSource = dt;
                    cmbMembre.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement membres : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton Rechercher (requête 1) : personnes parties en mission avec le membre sélectionné
        private void btnRechercherMembre_Click(object sender, EventArgs e)
        {
            if (cmbMembre.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un membre.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string matriculeSelectionne = cmbMembre.SelectedValue.ToString();

            // Toutes les personnes (nom, prénom, type) avec qui ce membre est parti en mission
            // On exclut le membre lui-même du résultat
            string sql =
                "SELECT DISTINCT mb.nom AS Nom, mb.prenom AS Prénom, " +
                "CASE WHEN mil.matriculeMembre IS NOT NULL THEN 'Militaire' ELSE 'Civil' END AS Type " +
                "FROM Composer c1 " +
                "JOIN Composer c2 ON c1.nomPlanete = c2.nomPlanete AND c1.numeroMission = c2.numeroMission " +
                "JOIN Membre mb ON c2.matriculeMembre = mb.matricule " +
                "LEFT JOIN Militaire mil ON mb.matricule = mil.matriculeMembre " +
                "WHERE c1.matriculeMembre = @matricule " +
                "AND c2.matriculeMembre != @matricule " +
                "ORDER BY mb.nom, mb.prenom";

            ExecuterRequete(sql, dgvReq1, new SQLiteParameter[]
            {
                new SQLiteParameter("@matricule", matriculeSelectionne)
            });

            lblResultatReq1.Text = "Résultat : " + dgvReq1.Rows.Count + " co-équipier(s) trouvé(s).";
        }

        // ============================================================
        // REQUÊTE 2 : Missions > 10 membres : dépenses et budgets
        // ============================================================
        private void btnReq2_Click(object sender, EventArgs e)
        {
            // Pour les missions comportant un équipage de plus de 10 personnes :
            // liste des dépenses, budgets initiaux et actuels
            string sql =
                "SELECT m.nomPlanete || ' - ' || m.numero AS Mission, " +
                "m.budget AS [Budget initial (€)], " +
                "(m.budget - COALESCE(SUM(d.montant), 0)) AS [Budget actuel (€)], " +
                "COUNT(DISTINCT comp.matriculeMembre) AS [Nb membres], " +
                "td.libelle AS [Type dépense], " +
                "d.dateD AS [Date dépense], " +
                "d.motif AS Motif, " +
                "d.montant AS [Montant (€)] " +
                "FROM Mission m " +
                "JOIN Composer comp ON m.nomPlanete = comp.nomPlanete AND m.numero = comp.numeroMission " +
                "LEFT JOIN Depense d ON m.nomPlanete = d.nomPlanete AND m.numero = d.numeroMission " +
                "LEFT JOIN TypeDepense td ON d.idTypeDepense = td.id " +
                "GROUP BY m.nomPlanete, m.numero, d.id " +
                "HAVING COUNT(DISTINCT comp.matriculeMembre) > 10 " +
                "ORDER BY m.nomPlanete, m.numero, d.dateD";

            ExecuterRequete(sql, dgvReq2);
            lblResultatReq2.Text = "Résultat : " + dgvReq2.Rows.Count + " ligne(s).";
        }

        // ============================================================
        // REQUÊTE 3 : Nombre de missions par planète (y compris 0)
        // ============================================================
        private void btnReq3_Click(object sender, EventArgs e)
        {
            // Pour chaque planète : nombre de missions qui y ont eu lieu
            // Les planètes sans mission doivent apparaître (LEFT JOIN)
            string sql =
                "SELECT p.nom AS Planète, " +
                "COUNT(m.numero) AS [Nombre de missions] " +
                "FROM Planete p " +
                "LEFT JOIN Mission m ON p.nom = m.nomPlanete " +
                "GROUP BY p.nom " +
                "ORDER BY COUNT(m.numero) DESC, p.nom";

            ExecuterRequete(sql, dgvReq3);
            lblResultatReq3.Text = "Résultat : " + dgvReq3.Rows.Count + " planète(s).";
        }

        // ============================================================
        // REQUÊTE 4 : Dépenses les plus élevées de chaque mission
        // ============================================================
        private void btnReq4_Click(object sender, EventArgs e)
        {
            // Liste des dépenses les plus élevées de chaque mission
            // Colonne concaténée "Dépenses les plus importantes", nom de mission, chef
            string sql =
                "SELECT " +
                "d.dateD || ' - ' || d.motif || ' - ' || d.montant || ' €' AS [Dépenses les plus importantes], " +
                "m.nomPlanete || ' - ' || m.numero AS [Mission], " +
                "mb.nom || ' ' || mb.prenom AS [Chef de mission] " +
                "FROM Depense d " +
                "JOIN Mission m ON d.nomPlanete = m.nomPlanete AND d.numeroMission = m.numero " +
                "JOIN Membre mb ON m.matriculeChef = mb.matricule " +
                "WHERE d.montant = ( " +
                "    SELECT MAX(d2.montant) " +
                "    FROM Depense d2 " +
                "    WHERE d2.nomPlanete = d.nomPlanete AND d2.numeroMission = d.numeroMission " +
                ") " +
                "ORDER BY m.nomPlanete, m.numero";

            ExecuterRequete(sql, dgvReq4);
            lblResultatReq4.Text = "Résultat : " + dgvReq4.Rows.Count + " dépense(s) maximale(s).";
        }

        // ============================================================
        // REQUÊTE 5 : Informateurs ayant reçu le moins d'argent
        //             pour une mission donnée
        // ============================================================
        private void ChargerListeMissions()
        {
            // Chargement de la liste des missions dans le ComboBox de la requête 5
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(CONN_STRING))
                {
                    conn.Open();
                    string sql =
                        "SELECT nomPlanete || ' - ' || numero AS libelle, " +
                        "nomPlanete, numero " +
                        "FROM Mission ORDER BY nomPlanete, numero";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("libelle");
                    dt.Columns.Add("nomPlanete");
                    dt.Columns.Add("numero");

                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["libelle"] = reader["libelle"].ToString();
                        row["nomPlanete"] = reader["nomPlanete"].ToString();
                        row["numero"] = reader["numero"].ToString();
                        dt.Rows.Add(row);
                    }
                    reader.Close();

                    cmbMission.DataSource = dt;
                    cmbMission.DisplayMember = "libelle";
                    cmbMission.ValueMember = "nomPlanete";
                    cmbMission.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement missions : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRechercherMission_Click(object sender, EventArgs e)
        {
            if (cmbMission.SelectedValue == null || cmbMission.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez sélectionner une mission.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRowView rowView = (DataRowView)cmbMission.SelectedItem;
            string nomPlanete = rowView["nomPlanete"].ToString();
            string numero = rowView["numero"].ToString();

            // Informateurs ayant perçu le moins d'argent pendant cette mission
            // (somme totale minimale parmi tous les informateurs de la mission)
            string sql =
                "SELECT i.nomCode AS [Nom de code], " +
                "e.nom AS [Espèce d'origine], " +
                "SUM(c.sommeVersee) AS [Somme totale reçue ($)] " +
                "FROM Contact c " +
                "JOIN Informateur i ON c.nomCodeInformateur = i.nomCode " +
                "JOIN Espece e ON i.idEspeceEnnemi = e.id " +
                "WHERE c.nomPlanete = @nomPlanete AND c.numeroMission = @numero " +
                "GROUP BY i.nomCode, e.nom " +
                "HAVING SUM(c.sommeVersee) = ( " +
                "    SELECT MIN(totalParInformateur) " +
                "    FROM ( " +
                "        SELECT SUM(c2.sommeVersee) AS totalParInformateur " +
                "        FROM Contact c2 " +
                "        WHERE c2.nomPlanete = @nomPlanete AND c2.numeroMission = @numero " +
                "        GROUP BY c2.nomCodeInformateur " +
                "    ) " +
                ") " +
                "ORDER BY i.nomCode";

            ExecuterRequete(sql, dgvReq5, new SQLiteParameter[]
            {
                new SQLiteParameter("@nomPlanete", nomPlanete),
                new SQLiteParameter("@numero", numero)
            });

            lblResultatReq5.Text = "Résultat : " + dgvReq5.Rows.Count + " informateur(s) en bas de classement.";
        }

        // Chargement de la liste des missions quand on clique sur l'onglet 5
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 4) // Onglet Requête 5 (index 4)
            {
                ChargerListeMissions();
            }
        }
    }
}
