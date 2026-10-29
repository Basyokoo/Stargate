using StargateControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StargateControlLibrary.Planet;

namespace Stargate
{
    public partial class volet6 : Form
    {
        // Création d'un connecteur à la base de données Stargate.db
        // do not initialize at field declaration to avoid loading SQLite at design-time
        SQLiteConnection conn;
        DataTable dtPlanetes = new DataTable();

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
        private void nav_Races_Click(object s, EventArgs e)    { NavHelper.ProchainVolet = "volet5"; this.Close(); }
        private void nav_Planetes_Click(object s, EventArgs e) { /* déjà ici */ }
        private void nav_Stats_Click(object s, EventArgs e)    { NavHelper.ProchainVolet = "volet7"; this.Close(); }

        public volet6()
        {
            InitializeComponent();
        }

        private void volet5_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Ajout des NavItems dans la sidebar
            AjouterNavItems();

            try
            {
                // Initialize the SQLite connection at runtime (not at design-time)
                conn = new SQLiteConnection("Data Source=Stargate.db;Version=3;");
                string sql = "SELECT * FROM Planete";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn))
                {
                    adapter.Fill(dtPlanetes);
                }

                int tag = 0;
                foreach (DataRow row in dtPlanetes.Rows)
                {
                    string dataBazOnStr = row["dataBazOn"].ToString();
                    string presencePorte = (dataBazOnStr == "0" || !dataBazOnStr.StartsWith("-")) ? "oui" : "non";

                    string nomPlanete = row["nom"] != DBNull.Value ? row["nom"].ToString() : "Inconnue";

                    string imgPlanete = System.IO.Path.Combine(
                        Application.StartupPath, "Planetes", nomPlanete + ".png");

                    StargateControlLibrary.Planet planet = new Planet(
                        nomPlanete,
                        row["temperature"].ToString(),
                        row["gravite"].ToString(),
                        presencePorte,
                        imgPlanete,
                        tag
                    );

                    planet.afficheur = AfficherPlanet;
                    flpPlanet.Controls.Add(planet);
                    tag++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement déconnecté : " + ex.Message);
            }
        }

        private void AfficherPlanet(object sender, EventArgs e)
        {
            Button btnClique = sender as Button;
            if (btnClique != null && btnClique.Tag != null)
            {
                int indexLigne = Convert.ToInt32(btnClique.Tag);

                if (indexLigne >= 0 && indexLigne < dtPlanetes.Rows.Count)
                {
                    DataRow rowPlanete = dtPlanetes.Rows[indexLigne];

                    string nomPlanete = rowPlanete["nom"].ToString();

                    List<List<string>> listeEspecesInfo = new List<List<string>>();
                    DataTable dtEspeces = new DataTable();

                    string sqlEspeces = @"
                                        SELECT
                                            E.id,
                                            E.nom AS NomEspece,
                                            E.couleur,
                                            H.pourcentage,
                                            A.datePremierContact,
                                            A.degreBienveillance,
                                            A.instrumentMusique,
                                            EN.typeArme,
                                            EN.degreAgressivite
                                        FROM Habiter H
                                        INNER JOIN Espece E ON H.idEspece = E.id
                                        LEFT JOIN Allie A ON E.id = A.idEspece
                                        LEFT JOIN Ennemi EN ON E.id = EN.idEspece
                                        WHERE LOWER(H.nomPlanete) = LOWER(@nom)";

                    try
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlEspeces, conn))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@nom", nomPlanete.Trim());
                            adapter.Fill(dtEspeces);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur SQL lors du tri des espèces : " + ex.Message);
                        return;
                    }

                    foreach (DataRow rowEsp in dtEspeces.Rows)
                    {
                        string estMechant = "oui";
                        string degres = rowEsp["degreAgressivite"] != DBNull.Value ? rowEsp["degreAgressivite"].ToString() : "0";
                        string armeOuInstru = rowEsp["typeArme"] != DBNull.Value ? rowEsp["typeArme"].ToString() : "Aucune";
                        string dateContact = "";
                        string pct = rowEsp["pourcentage"] != DBNull.Value ? rowEsp["pourcentage"].ToString() : "0";

                        if (rowEsp["datePremierContact"] != DBNull.Value && !string.IsNullOrEmpty(rowEsp["datePremierContact"].ToString()))
                        {
                            estMechant = "non";
                            degres = rowEsp["degreBienveillance"] != DBNull.Value ? rowEsp["degreBienveillance"].ToString() : "0";
                            armeOuInstru = rowEsp["instrumentMusique"] != DBNull.Value ? rowEsp["instrumentMusique"].ToString() : "Aucun";
                            dateContact = rowEsp["datePremierContact"].ToString();
                        }

                        string couleur = rowEsp["couleur"] != DBNull.Value ? rowEsp["couleur"].ToString() : "";

                        List<string> unAlien = new List<string>
                        {
                            rowEsp["NomEspece"].ToString(),
                            rowEsp["id"].ToString(),
                            degres,
                            armeOuInstru,
                            estMechant,
                            dateContact,
                            pct,
                            couleur
                        };

                        listeEspecesInfo.Add(unAlien);
                    }

                    string imgDetail = System.IO.Path.Combine(
                        Application.StartupPath, "Planetes", nomPlanete + ".png");
                    flpPlanet.Visible = false;

                    // Bouton retour — positionné dans pnlContenu, sous le titre
                    Button btnRetour = new Button();
                    btnRetour.Text      = "←  Retour à la liste des planètes";
                    btnRetour.BackColor = System.Drawing.Color.FromArgb(28, 55, 115);
                    btnRetour.ForeColor = System.Drawing.Color.FromArgb(210, 230, 255);
                    btnRetour.FlatStyle = FlatStyle.Flat;
                    btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 100, 200);
                    btnRetour.FlatAppearance.BorderSize  = 1;
                    btnRetour.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
                    btnRetour.Cursor    = Cursors.Hand;
                    btnRetour.Location  = new System.Drawing.Point(0, 62);
                    btnRetour.Size      = new System.Drawing.Size(pnlContenu.ClientSize.Width, 44);
                    btnRetour.Anchor    = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                    // PlanetInfo remplit tout l'espace sous le bouton
                    PlanetInfo infoUC = new PlanetInfo(nomPlanete, "Multi-espèces", "100%", imgDetail, listeEspecesInfo);
                    infoUC.Location = new System.Drawing.Point(0, 62 + 50);
                    infoUC.Size     = new System.Drawing.Size(pnlContenu.ClientSize.Width, pnlContenu.ClientSize.Height - 62 - 50);
                    infoUC.Anchor   = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                    var infoUCRef = infoUC;
                    btnRetour.Click += (s2, e2) =>
                    {
                        pnlContenu.Controls.Remove(infoUCRef);
                        pnlContenu.Controls.Remove(btnRetour);
                        flpPlanet.Visible = true;
                    };

                    pnlContenu.Controls.Add(infoUC);
                    pnlContenu.Controls.Add(btnRetour);
                    infoUC.BringToFront();
                    btnRetour.BringToFront();
                }
            }
        }

        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);

        //    if (this.WindowState == FormWindowState.Normal)
        //    {
        //        this.WindowState = FormWindowState.Maximized;
        //    }
        //}
    }
}