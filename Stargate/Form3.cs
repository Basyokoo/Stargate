using Stargate.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using Color = System.Drawing.Color;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using QuestPDF;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


namespace Stargate
{
    // Volet 3 : Récapitulatif complet d'une mission (mode déconnecté)
    // Les données sont chargées une seule fois depuis la base, puis tout fonctionne en mémoire
    public partial class Form3 : Form
    {

        // Paramètres de la mission sélectionnée (passés depuis le tableau de bord)
        private string nomPlanete;
        private int numeroMission;

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
            var item = new StargateControlLibrary.NavItem(nom, svg, Color.FromArgb(255,200,50), Color.White, onClick);
            item.Location = new System.Drawing.Point(10, y);
            return item;
        }

        private void nav_Tableau_Click(object s, EventArgs e)  { NavHelper.ProchainVolet = null;     this.Close(); }
        private void nav_Mission_Click(object s, EventArgs e)  { NavHelper.ProchainVolet = "volet2"; this.Close(); }
        private void nav_Races_Click(object s, EventArgs e)    { NavHelper.ProchainVolet = "volet5"; this.Close(); }
        private void nav_Planetes_Click(object s, EventArgs e) { NavHelper.ProchainVolet = "volet6"; this.Close(); }
        private void nav_Stats_Click(object s, EventArgs e)    { NavHelper.ProchainVolet = "volet7"; this.Close(); }

        // DataSet local pour stocker toutes les données de la mission (mode déconnecté)
        private DataSet dsMission = new DataSet();

        // BindingSource pour la navigation dans le journal (liaison de données)
        private BindingSource bsJournal = new BindingSource();

        // User Control journal actuellement affiché
        private UCJournal ucJournalActuel;

        public Form3(string nomPlanete, int numeroMission)
        {
            InitializeComponent();
            this.nomPlanete = nomPlanete;
            this.numeroMission = numeroMission;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            // Remplissage de la sidebar de navigation
            AjouterNavItems();

            // Chargement unique de toutes les données en mode connecté
            ChargerToutesLesDonnees();

            // Passage en mode déconnecté : tout l'affichage se fait depuis le DataSet local
            AfficherInfosMission();
            AfficherMembres();
            AfficherObjectifsCaptures();
            AfficherDepenses();
            InitialiserJournal();
            AfficherContacts();
        }

        // ============================================================
        // CHARGEMENT DES DONNÉES (mode connecté - une seule fois)
        // ============================================================
        private void ChargerToutesLesDonnees()
        {
            // Vide les LIGNES du DataSet avant de recharger (utile après un ajout).
            // IMPORTANT : on n'appelle PAS Tables.Clear() car cela détruirait les DataTable
            // référencées par le BindingSource bsJournal, ce qui casserait la navigation.
            dsMission.Clear();

            string chcon = @"Data Source=Stargate.db";
            using (SQLiteConnection connec = new SQLiteConnection(chcon))
            {
                connec.Open();
                SQLiteDataAdapter da;

                // Table Mission
                da = new SQLiteDataAdapter(
                    "SELECT m.*, mb.nom as nomChef, mb.prenom as prenomChef, " +
                    "CASE WHEN mil.grade IS NOT NULL THEN mil.grade ELSE 'Chef' END as gradeChef " +
                    "FROM Mission m " +
                    "JOIN Membre mb ON m.matriculeChef = mb.matricule " +
                    "LEFT JOIN Militaire mil ON mb.matricule = mil.matriculeMembre " +
                    "WHERE m.nomPlanete = @p AND m.numero = @n",
                    connec);
                da.SelectCommand.Parameters.AddWithValue("@p", nomPlanete);
                da.SelectCommand.Parameters.AddWithValue("@n", numeroMission);
                da.Fill(dsMission, "Mission");

                // Table Membres de l'équipage
                da = new SQLiteDataAdapter(
                    "SELECT mb.matricule, mb.nom, mb.prenom, " +
                    "CASE WHEN mil.grade IS NOT NULL THEN mil.grade ELSE c.Specialite END as role, " +
                    "CASE WHEN mil.grade IS NOT NULL THEN 'Militaire' ELSE 'Civil' END as type, " +
                    "CASE WHEN mb.matricule = mis.matriculeChef THEN 1 ELSE 0 END as estChef " +
                    "FROM Composer comp " +
                    "JOIN Membre mb ON comp.matriculeMembre = mb.matricule " +
                    "JOIN Mission mis ON comp.nomPlanete = mis.nomPlanete AND comp.numeroMission = mis.numero " +
                    "LEFT JOIN Militaire mil ON mb.matricule = mil.matriculeMembre " +
                    "LEFT JOIN Civil c ON mb.matricule = c.matriculeMembre " +
                    "WHERE comp.nomPlanete = @p AND comp.numeroMission = @n " +
                    "ORDER BY estChef DESC, mb.nom",
                    connec);
                da.SelectCommand.Parameters.AddWithValue("@p", nomPlanete);
                da.SelectCommand.Parameters.AddWithValue("@n", numeroMission);
                da.Fill(dsMission, "Membres");

                // Table Objectifs de capture avec résultats réels
                da = new SQLiteDataAdapter(
                    "SELECT e.nom as espece, e.couleur, oc.objectif, oc.idEspeceEnnemi, " +
                    "COALESCE(ca.nombre, 0) as captures " +
                    "FROM ObjectifCapture oc " +
                    "JOIN Espece e ON oc.idEspeceEnnemi = e.id " +
                    "LEFT JOIN Capturer ca ON oc.nomPlanete = ca.nomPlanete " +
                    "    AND oc.numeroMission = ca.numeroMission " +
                    "    AND oc.idEspeceEnnemi = ca.idEspeceEnnemi " +
                    "WHERE oc.nomPlanete = @p AND oc.numeroMission = @n",
                    connec);
                da.SelectCommand.Parameters.AddWithValue("@p", nomPlanete);
                da.SelectCommand.Parameters.AddWithValue("@n", numeroMission);
                da.Fill(dsMission, "Captures");

                // Table Dépenses
                da = new SQLiteDataAdapter(
                    "SELECT d.dateD, d.montant, d.motif, td.libelle as typeDepense " +
                    "FROM Depense d " +
                    "JOIN TypeDepense td ON d.idTypeDepense = td.id " +
                    "WHERE d.nomPlanete = @p AND d.numeroMission = @n " +
                    "ORDER BY d.dateD",
                    connec);
                da.SelectCommand.Parameters.AddWithValue("@p", nomPlanete);
                da.SelectCommand.Parameters.AddWithValue("@n", numeroMission);
                da.Fill(dsMission, "Depenses");

                // Table Journal de bord
                da = new SQLiteDataAdapter(
                    "SELECT dateJ, commentaires FROM JournalDeBord " +
                    "WHERE nomPlanete = @p AND numero = @n ORDER BY dateJ",
                    connec);
                da.SelectCommand.Parameters.AddWithValue("@p", nomPlanete);
                da.SelectCommand.Parameters.AddWithValue("@n", numeroMission);
                da.Fill(dsMission, "Journal");

                // Table Contacts informateurs
                da = new SQLiteDataAdapter(
                    "SELECT c.dateC, c.sommeVersee, c.appreciation, " +
                    "i.nomCode, e.nom as especeInformateur " +
                    "FROM Contact c " +
                    "JOIN Informateur i ON c.nomCodeInformateur = i.nomCode " +
                    "JOIN Espece e ON i.idEspeceEnnemi = e.id " +
                    "WHERE c.nomPlanete = @p AND c.numeroMission = @n " +
                    "ORDER BY c.dateC",
                    connec);
                da.SelectCommand.Parameters.AddWithValue("@p", nomPlanete);
                da.SelectCommand.Parameters.AddWithValue("@n", numeroMission);
                da.Fill(dsMission, "Contacts");

                connec.Close();
            }
        }

        // ============================================================
        // UTILITAIRE : Date de la dernière entrée du journal
        // C'est la date plancher pour tout ajout (journal, dépense, négociation).
        // ============================================================
        private DateTime ObtenirDateDerniereEntreeJournal()
        {
            DataTable tJournal = dsMission.Tables["Journal"];
            if (tJournal == null || tJournal.Rows.Count == 0)
            {
                // Aucune entrée : on utilise la date de départ de la mission
                DataRow rMission = dsMission.Tables["Mission"].Rows[0];
                if (DateTime.TryParse(rMission["dateDepart"].ToString(), out DateTime dateDepart))
                    return dateDepart;
                return DateTime.Today;
            }

            // La table Journal est triée par dateJ ASC, donc la dernière ligne = la plus récente
            string derniereDateStr = tJournal.Rows[tJournal.Rows.Count - 1]["dateJ"].ToString();
            if (DateTime.TryParse(derniereDateStr, out DateTime derniereDate))
                return derniereDate;

            return DateTime.Today;
        }

        // ============================================================
        // AFFICHAGE INFOS MISSION (depuis DataSet local)
        // ============================================================
        private void AfficherInfosMission()
        {
            if (dsMission.Tables["Mission"].Rows.Count == 0) return;
            DataRow r = dsMission.Tables["Mission"].Rows[0];

            string nomMission = r["nomPlanete"].ToString() + " - " + r["numero"].ToString();
            lblTitreMission.Text = "Mission " + nomMission;
            lblDateDepart.Text = "Départ : " + r["dateDepart"].ToString();
            lblDateRetour.Text = "Retour prévu : " + r["dateRetour"].ToString();
            txtFeuilleRoute.Text = r["feuilleDeRoute"].ToString();

            int budget = Convert.ToInt32(r["budget"]);
            int totalDepenses = 0;
            foreach (DataRow dr in dsMission.Tables["Depenses"].Rows)
                totalDepenses += Convert.ToInt32(dr["montant"]);

            lblBudgetInitial.Text = "Budget initial : " + budget.ToString("N0") + " €";
            int solde = budget - totalDepenses;
            lblSolde.Text = "Solde après dépenses : " + solde.ToString("N0") + " €";
            if (solde < 0)
                lblSolde.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
            else if (solde < 500)
                lblSolde.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
            else
                lblSolde.ForeColor = System.Drawing.Color.FromArgb(80, 220, 120);

            lblChef.Text = "Chef : " + r["prenomChef"].ToString() + " " + r["nomChef"].ToString() + " - " + r["gradeChef"].ToString();
            lblObjectifDatabaz.Text = "Objectif DataBaz : " + r["objectifDatabaz"].ToString() + " tonnes";
        }

        // ============================================================
        // AFFICHAGE MEMBRES (User Controls générés dynamiquement)
        // ============================================================
        private void AfficherMembres()
        {
            flpMembres.Controls.Clear();
            DataRowCollection drc_missions = dsMission.Tables["Mission"].Rows;
            if (drc_missions.Count <= 0) { return; }

            string matriculeChef = dsMission.Tables["Mission"].Rows[0]["matriculeChef"].ToString();

            foreach (DataRow r in dsMission.Tables["Membres"].Rows)
            {
                bool estChef = r["matricule"].ToString() == matriculeChef;
                UCMembre uc = new UCMembre(
                    r["nom"].ToString(),
                    r["prenom"].ToString(),
                    r["role"].ToString(),
                    r["type"].ToString(),
                    estChef
                );
                uc.Width = 130;
                uc.Height = 160;
                uc.Margin = new Padding(5);
                flpMembres.Controls.Add(uc);
            }
        }

        // ============================================================
        // AFFICHAGE OBJECTIFS DE CAPTURE (depuis DataSet local)
        // ============================================================
        private void AfficherObjectifsCaptures()
        {
            dgvCaptures.Rows.Clear();
            foreach (DataRow r in dsMission.Tables["Captures"].Rows)
            {
                int objectif = Convert.ToInt32(r["objectif"]);
                int captures = Convert.ToInt32(r["captures"]);
                double taux = objectif > 0 ? Math.Round((double)captures / objectif * 100, 1) : 0;

                int idx = dgvCaptures.Rows.Add(
                    r["espece"].ToString() + " (" + r["couleur"].ToString() + ")",
                    objectif,
                    captures,
                    taux + " %"
                );

                // Colorisation selon le taux de réussite
                if (taux >= 100)
                    dgvCaptures.Rows[idx].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 80, 50);
                else if (taux >= 50)
                    dgvCaptures.Rows[idx].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 60, 20);
                else
                    dgvCaptures.Rows[idx].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(80, 30, 30);
            }
        }

        // ============================================================
        // AFFICHAGE DÉPENSES (depuis DataSet local)
        // ============================================================
        private void AfficherDepenses()
        {
            dgvDepenses.Rows.Clear();
            int total = 0;
            foreach (DataRow r in dsMission.Tables["Depenses"].Rows)
            {
                int montant = Convert.ToInt32(r["montant"]);
                total += montant;
                dgvDepenses.Rows.Add(
                    r["dateD"].ToString(),
                    r["motif"].ToString(),
                    montant.ToString("N0") + " €",
                    r["typeDepense"].ToString()
                );
            }
            lblTotalDepenses.Text = "Total dépenses : " + total.ToString("N0") + " €";
        }

        // ============================================================
        // JOURNAL DE BORD (liaison de données - aucun accès BDD)
        // ============================================================
        private void InitialiserJournal()
        {
            if (dsMission.Tables["Journal"] == null || dsMission.Tables["Journal"].Rows.Count == 0)
            {
                lblPositionJournal.Text = "Aucun événement";
                btnPremier.Enabled = btnPrecedent.Enabled = btnSuivant.Enabled = btnDernier.Enabled = false;
                if (pnlJournal.Controls.Count > 0) pnlJournal.Controls.Clear();
                return;
            }

            // 1) Détacher les bindings de l'ancien UC (s'il existe) avant de
            //    toucher au BindingSource — sinon WinForms tente de résoudre
            //    dateJ/commentaires sur DataSource=null et lève ArgumentException.
            if (ucJournalActuel != null)
                ucJournalActuel.DataBindings.Clear();

            // 2) Réinitialiser le BindingSource : plus aucun binding actif dessus.
            bsJournal.DataSource = null;
            bsJournal.DataMember = "";
            bsJournal.DataSource = dsMission;
            bsJournal.DataMember = "Journal";

            // 3) Créer le nouveau UC et y brancher les bindings.
            pnlJournal.Controls.Clear();
            ucJournalActuel = new UCJournal();
            ucJournalActuel.Dock = DockStyle.Fill;
            ucJournalActuel.DataBindings.Add("DateEvenement", bsJournal, "dateJ");
            ucJournalActuel.DataBindings.Add("Commentaire", bsJournal, "commentaires");
            pnlJournal.Controls.Add(ucJournalActuel);

            // Aller à la dernière entrée (la plus récente) après un rechargement
            bsJournal.MoveLast();
            MettreAJourNavigationJournal();
        }

        private void MettreAJourNavigationJournal()
        {
            int total = bsJournal.Count;
            int pos = bsJournal.Position + 1;
            lblPositionJournal.Text = total > 0 ? pos + " / " + total : "Aucun événement";
            btnPremier.Enabled = bsJournal.Position > 0;
            btnPrecedent.Enabled = bsJournal.Position > 0;
            btnSuivant.Enabled = bsJournal.Position < bsJournal.Count - 1;
            btnDernier.Enabled = bsJournal.Position < bsJournal.Count - 1;
        }

        // Boutons de navigation du journal - liaison de données pure, pas d'accès BDD
        private void btnPremier_Click(object sender, EventArgs e)
        {
            bsJournal.MoveFirst();
            MettreAJourNavigationJournal();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            bsJournal.MovePrevious();
            MettreAJourNavigationJournal();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bsJournal.MoveNext();
            MettreAJourNavigationJournal();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            bsJournal.MoveLast();
            MettreAJourNavigationJournal();
        }

        // ============================================================
        // AFFICHAGE CONTACTS INFORMATEURS (depuis DataSet local)
        // ============================================================
        private void AfficherContacts()
        {
            dgvContacts.Rows.Clear();
            int total = 0;
            foreach (DataRow r in dsMission.Tables["Contacts"].Rows)
            {
                int somme = Convert.ToInt32(r["sommeVersee"]);
                total += somme;
                dgvContacts.Rows.Add(
                    r["dateC"].ToString(),
                    r["nomCode"].ToString(),
                    r["especeInformateur"].ToString(),
                    somme.ToString("N0") + " $",
                    r["appreciation"].ToString()
                );
            }
            lblTotalContacts.Text = "Total sommes versées : " + total.ToString("N0") + " $";
        }

        // ============================================================
        // RECHARGEMENT COMPLET (après un ajout en base)
        // On recharge depuis la BDD et on rafraîchit tous les affichages
        // ============================================================
        private void RechargementComplet()
        {
            ChargerToutesLesDonnees();
            AfficherInfosMission();   // recalcule le solde budget
            AfficherDepenses();
            InitialiserJournal();
            AfficherContacts();
        }

        // ============================================================
        // BOUTON : Ajouter une entrée au journal
        // ============================================================
        private void btnAjoutJournal_Click(object sender, EventArgs e)
        {
            DateTime plancher = ObtenirDateDerniereEntreeJournal();
            FormAjoutJournal popup = new FormAjoutJournal(nomPlanete, numeroMission, plancher);
            popup.ShowDialog(this);

            if (popup.Succes)
                RechargementComplet();
        }

        // ============================================================
        // BOUTON : Ajouter une dépense
        // ============================================================
        private void btnAjoutDepense_Click(object sender, EventArgs e)
        {
            DateTime plancher = ObtenirDateDerniereEntreeJournal();

            // Calcul du budget restant
            DataRow rMission = dsMission.Tables["Mission"].Rows[0];
            int budget = Convert.ToInt32(rMission["budget"]);
            int totalDepenses = 0;
            foreach (DataRow dr in dsMission.Tables["Depenses"].Rows)
                totalDepenses += Convert.ToInt32(dr["montant"]);
            int budgetRestant = budget - totalDepenses;

            FormAjoutDepense popup = new FormAjoutDepense(nomPlanete, numeroMission, plancher, budgetRestant);
            popup.ShowDialog(this);

            if (popup.Succes)
                RechargementComplet();
        }

        // ============================================================
        // BOUTON : Mettre à jour les captures d'aliens
        // ============================================================
        private void btnMajCaptures_Click(object sender, EventArgs e)
        {
            FormMajCaptures popup = new FormMajCaptures(nomPlanete, numeroMission, dsMission);
            popup.ShowDialog(this);

            if (popup.Succes)
            {
                ChargerToutesLesDonnees();
                AfficherObjectifsCaptures();
            }
        }

        // ============================================================
        // BOUTON : Ajouter une négociation (contact informateur)
        // ============================================================
        private void btnAjoutNegociation_Click(object sender, EventArgs e)
        {
            DateTime plancher = ObtenirDateDerniereEntreeJournal();

            // Calcul du budget restant
            DataRow rMission = dsMission.Tables["Mission"].Rows[0];
            int budget = Convert.ToInt32(rMission["budget"]);
            int totalDepenses = 0;
            foreach (DataRow dr in dsMission.Tables["Depenses"].Rows)
                totalDepenses += Convert.ToInt32(dr["montant"]);
            int budgetRestant = budget - totalDepenses;

            FormAjoutNegociation popup = new FormAjoutNegociation(nomPlanete, numeroMission, plancher, budgetRestant);
            popup.ShowDialog(this);

            if (popup.Succes)
                RechargementComplet();
        }

        private void CreePDF()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // Demander à l'utilisateur où enregistrer le fichier
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Enregistrer le rapport de mission";
                sfd.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                sfd.FileName = "RapportMission_" + nomPlanete + "_" + numeroMission + ".pdf";
                sfd.DefaultExt = "pdf";

                if (sfd.ShowDialog(this) != DialogResult.OK)
                    return; // L'utilisateur a annulé

                string cheminPdf = sfd.FileName;

                try
                {
                    // ── Données Mission ───────────────────────────────────────────────
                    string nomPlanetePdf = "Inconnue", numeroMissionPdf = "?", dateDepart = "?",
                           dateRetour = "?", nomChef = "?", feuilleDeRoute = "", budgetStr = "?";
                    int budgetVal = 0, totalDepensesVal = 0;

                    if (dsMission.Tables["Mission"] != null && dsMission.Tables["Mission"].Rows.Count > 0)
                    {
                        DataRow m = dsMission.Tables["Mission"].Rows[0];
                        nomPlanetePdf = m["nomPlanete"].ToString();
                        numeroMissionPdf = m["numero"].ToString();
                        dateDepart = m["dateDepart"].ToString();
                        dateRetour = m["dateRetour"].ToString();
                        nomChef = m["prenomChef"].ToString() + " " + m["nomChef"].ToString();
                        feuilleDeRoute = m["feuilleDeRoute"].ToString();
                        budgetVal = Convert.ToInt32(m["budget"]);
                        budgetStr = budgetVal.ToString("N0");
                    }

                    // Calcul solde
                    if (dsMission.Tables["Depenses"] != null)
                        foreach (DataRow dr in dsMission.Tables["Depenses"].Rows)
                            totalDepensesVal += Convert.ToInt32(dr["montant"]);
                    int solde = budgetVal - totalDepensesVal;

                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(1.5f, QuestPDF.Infrastructure.Unit.Centimetre);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontSize(10));

                            // ══════════════════════════════════════════════════════════
                            // EN-TÊTE
                            // ══════════════════════════════════════════════════════════
                            page.Header()
                                .BorderBottom(2).BorderColor("#1a3a5c")
                                .PaddingBottom(6)
                                .Row(row =>
                                {
                                    row.RelativeItem()
                                        .Text("Rapport de mission")
                                        .Bold().FontSize(20).FontColor("#1a3a5c");
                                    row.ConstantItem(160).AlignRight()
                                        .Text($"Mission n°{numeroMissionPdf}  —  {nomPlanetePdf}")
                                        .FontSize(9).FontColor(Colors.Grey.Darken1);
                                });

                            // ══════════════════════════════════════════════════════════
                            // CONTENU
                            // ══════════════════════════════════════════════════════════
                            page.Content().PaddingTop(10).Column(col =>
                            {
                                // ── Bloc infos générales ──────────────────────────────
                                col.Item()
                                    .Border(1).BorderColor("#d0d8e4")
                                    .Background("#f4f7fb")
                                    .Padding(10)
                                    .Column(info =>
                                    {
                                        info.Item().Row(r =>
                                        {
                                            r.RelativeItem().Text($"Départ le {dateDepart}").Bold();
                                            r.RelativeItem().Text($"Retour le {dateRetour}").Bold();
                                        });
                                        info.Item().PaddingTop(6)
                                            .LineHorizontal(1).LineColor("#c0cfe0");
                                        info.Item().PaddingTop(6)
                                            .Text($"Sous la responsabilité de  {nomChef}").Bold();
                                        info.Item().PaddingTop(2)
                                            .Text($"Budget initial : {budgetStr} €  —  Solde restant : {solde.ToString("N0")} €").Bold();
                                    });

                                // ── Feuille de route ──────────────────────────────────
                                col.Item().PaddingTop(12).Column(fr =>
                                {
                                    fr.Item().Text("Feuille de route :").Bold().FontSize(11).FontColor("#1a3a5c");
                                    fr.Item().PaddingTop(4).PaddingLeft(8)
                                        .Text(string.IsNullOrWhiteSpace(feuilleDeRoute)
                                            ? "(aucune feuille de route enregistrée)"
                                            : feuilleDeRoute)
                                        .FontColor(Colors.Grey.Darken3).Italic();
                                });

                                // ── Séparateur ────────────────────────────────────────
                                col.Item().PaddingTop(10).LineHorizontal(1).LineColor("#c0cfe0");

                                // ── Liste des membres ─────────────────────────────────
                                col.Item().PaddingTop(8).Column(mb =>
                                {
                                    mb.Item().Text("Liste des membres").Bold().FontSize(11).FontColor("#1a3a5c");
                                    if (dsMission.Tables["Membres"] != null)
                                    {
                                        foreach (DataRow r in dsMission.Tables["Membres"].Rows)
                                            mb.Item().PaddingLeft(12).PaddingTop(2)
                                                .Text($"--> {r["prenom"]} {r["nom"]}  ({r["role"]})");
                                    }
                                });

                                // ── Séparateur ────────────────────────────────────────
                                col.Item().PaddingTop(10).LineHorizontal(1).LineColor("#c0cfe0");

                                // ── Journal de bord ───────────────────────────────────
                                col.Item().PaddingTop(8).Column(jcol =>
                                {
                                    jcol.Item().Text("Journal de bord :").Bold().FontSize(11).FontColor("#1a3a5c");
                                    if (dsMission.Tables["Journal"] != null && dsMission.Tables["Journal"].Rows.Count > 0)
                                    {
                                        foreach (DataRow r in dsMission.Tables["Journal"].Rows)
                                            jcol.Item().PaddingLeft(8).PaddingTop(2)
                                                .Text($"Le {r["dateJ"]} --> {r["commentaires"]}");
                                    }
                                    else
                                    {
                                        jcol.Item().PaddingLeft(8).PaddingTop(2)
                                            .Text("(aucune entrée de journal)").Italic().FontColor(Colors.Grey.Darken1);
                                    }
                                });

                                // ── Séparateur ────────────────────────────────────────
                                col.Item().PaddingTop(10).LineHorizontal(1).LineColor("#c0cfe0");

                                // ── Dépenses effectuées ───────────────────────────────
                                col.Item().PaddingTop(8).Column(dcol =>
                                {
                                    dcol.Item().Text("Dépenses effectuées :").Bold().FontSize(11).FontColor("#1a3a5c");
                                    if (dsMission.Tables["Depenses"] != null && dsMission.Tables["Depenses"].Rows.Count > 0)
                                    {
                                        int i = 1;
                                        foreach (DataRow r in dsMission.Tables["Depenses"].Rows)
                                            dcol.Item().PaddingLeft(8).PaddingTop(2)
                                                .Text($"{i++}) le {r["dateD"]} : {r["motif"]} [{r["typeDepense"]}] -> {r["montant"]:N0} €");

                                        dcol.Item().PaddingTop(6).PaddingLeft(8)
                                            .Text($"Total dépenses : {totalDepensesVal.ToString("N0")} €  —  Solde restant : {solde.ToString("N0")} €")
                                            .Bold().FontColor("#1a3a5c");
                                    }
                                    else
                                    {
                                        dcol.Item().PaddingLeft(8).PaddingTop(2)
                                            .Text("(aucune dépense enregistrée)").Italic().FontColor(Colors.Grey.Darken1);
                                    }
                                });

                                // ── Séparateur ────────────────────────────────────────
                                col.Item().PaddingTop(10).LineHorizontal(1).LineColor("#c0cfe0");

                                // ── Contacts informateurs ─────────────────────────────
                                col.Item().PaddingTop(8).Column(ccol =>
                                {
                                    ccol.Item().Text("Contacts avec des informateurs :").Bold().FontSize(11).FontColor("#1a3a5c");
                                    if (dsMission.Tables["Contacts"] != null && dsMission.Tables["Contacts"].Rows.Count > 0)
                                    {
                                        int totalSommes = 0;
                                        foreach (DataRow r in dsMission.Tables["Contacts"].Rows)
                                        {
                                            int somme = Convert.ToInt32(r["sommeVersee"]);
                                            totalSommes += somme;
                                            string espece = r["especeInformateur"].ToString();
                                            string race = string.IsNullOrEmpty(espece) ? "" : $" (Race des {espece})";
                                            ccol.Item().PaddingLeft(8).PaddingTop(2)
                                                .Text($"Le {r["dateC"]} : rencontre avec {r["nomCode"]}{race} -> {somme.ToString("N0")} $ ({r["appreciation"]})");
                                        }
                                        ccol.Item().PaddingTop(6).PaddingLeft(8)
                                            .Text($"Total sommes versées : {totalSommes.ToString("N0")} $")
                                            .Bold().FontColor("#1a3a5c");
                                    }
                                    else
                                    {
                                        ccol.Item().PaddingLeft(8).PaddingTop(2)
                                            .Text("(aucun contact enregistré)").Italic().FontColor(Colors.Grey.Darken1);
                                    }
                                });

                                // ── Séparateur ────────────────────────────────────────
                                col.Item().PaddingTop(10).LineHorizontal(1).LineColor("#c0cfe0");

                                // ── Bilan des captures ────────────────────────────────
                                col.Item().PaddingTop(8).Column(bc =>
                                {
                                    bc.Item().Text("Bilan des captures :").Bold().FontSize(11).FontColor("#1a3a5c");
                                    bc.Item().PaddingTop(6).Table(table =>
                                    {
                                        table.ColumnsDefinition(columns =>
                                        {
                                            columns.RelativeColumn(3);
                                            columns.RelativeColumn(2);
                                            columns.RelativeColumn(2);
                                            columns.RelativeColumn(2);
                                        });

                                        table.Header(header =>
                                        {
                                            foreach (string titre in new[]
                                            {
                                                "Espèce", "Objectif initial",
                                                "Captures réalisées", "Taux de réussite"
                                            })
                                            {
                                                header.Cell().Element(c => CellStyle(c))
                                                    .Text(titre).SemiBold().FontColor(Colors.White).FontSize(9);
                                            }
                                        });

                                        if (dsMission.Tables["Captures"] != null)
                                        {
                                            bool pair = false;
                                            foreach (DataRow row in dsMission.Tables["Captures"].Rows)
                                            {
                                                string bg = pair ? "#eaf0f8" : "#ffffff";
                                                pair = !pair;
                                                int objectif = Convert.ToInt32(row["objectif"]);
                                                int captures = Convert.ToInt32(row["captures"]);
                                                double taux = objectif > 0 ? Math.Round((double)captures / objectif * 100, 1) : 0;

                                                table.Cell().Background(bg).BorderBottom(1).BorderColor("#d0d8e4").Padding(5)
                                                    .Text(row["espece"].ToString() + " (" + row["couleur"].ToString() + ")");
                                                table.Cell().Background(bg).BorderBottom(1).BorderColor("#d0d8e4").Padding(5).AlignCenter()
                                                    .Text(objectif.ToString());
                                                table.Cell().Background(bg).BorderBottom(1).BorderColor("#d0d8e4").Padding(5).AlignCenter()
                                                    .Text(captures.ToString());
                                                table.Cell().Background(bg).BorderBottom(1).BorderColor("#d0d8e4").Padding(5).AlignCenter()
                                                    .Text(taux + " %");
                                            }
                                        }
                                    });
                                });
                            });

                            // ══════════════════════════════════════════════════════════
                            // PIED DE PAGE
                            // ══════════════════════════════════════════════════════════
                            page.Footer().AlignCenter().Text(x =>
                            {
                                x.Span("Page ").FontSize(9).FontColor(Colors.Grey.Medium);
                                x.CurrentPageNumber().FontSize(9).FontColor(Colors.Grey.Medium);
                                x.Span(" / ").FontSize(9).FontColor(Colors.Grey.Medium);
                                x.TotalPages().FontSize(9).FontColor(Colors.Grey.Medium);
                            });
                        });
                    })
                    .GeneratePdf(cheminPdf);

                    MessageBox.Show("Le PDF a été généré avec succès !\nFichier enregistré : " + cheminPdf,
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = cheminPdf,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la génération du PDF : " + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private QuestPDF.Infrastructure.IContainer CellStyle(QuestPDF.Infrastructure.IContainer container)
        {
            return container
                .Background("#104E8B")
                .Padding(5)
                .AlignCenter()
                .AlignMiddle();
        }

        private void btnGenererPDF_Click(object sender, EventArgs e)
        {
            this.CreePDF();
        }
    }
}
