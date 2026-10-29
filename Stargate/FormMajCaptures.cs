using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Stargate
{
    /// <summary>
    /// Popup de mise à jour des captures d'aliens pour une mission.
    /// Une ligne par espèce avec un NumericUpDown éditable.
    /// </summary>
    public partial class FormMajCaptures : Form
    {
        private string nomPlanete;
        private int numeroMission;
        private DataSet dsMission;

        // Liste des lignes : (idEspece, NUD)
        private List<(int idEspece, NumericUpDown nud)> lignes = new List<(int, NumericUpDown)>();

        public bool Succes { get; private set; } = false;

        // Constructeur sans paramètre requis par le designer Visual Studio
        public FormMajCaptures() : this("", 0, new DataSet()) { }

        public FormMajCaptures(string nomPlanete, int numeroMission, DataSet dsMission)
        {
            this.nomPlanete = nomPlanete;
            this.numeroMission = numeroMission;
            this.dsMission = dsMission;

            InitializeComponent();

            btnValider.FlatAppearance.BorderColor = Color.FromArgb(60, 160, 100);
            btnAnnuler.FlatAppearance.BorderColor = Color.FromArgb(160, 60, 60);

            ChargerCaptures();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ChargerCaptures()
        {
            pnlScroll.Controls.Clear();
            lignes.Clear();

            if (dsMission.Tables["Captures"] == null) return;

            Color bgDark    = Color.FromArgb(10, 15, 30);
            Color bgAlt     = Color.FromArgb(18, 25, 45);
            Color textWhite = Color.FromArgb(230, 235, 255);
            Color textGray  = Color.FromArgb(140, 155, 180);

            int y = 5;
            int i = 0;

            foreach (DataRow r in dsMission.Tables["Captures"].Rows)
            {
                Color bgLigne = (i % 2 == 0) ? bgAlt : bgDark;
                int idEspece = Convert.ToInt32(r["idEspeceEnnemi"]);
                int objectif = Convert.ToInt32(r["objectif"]);
                int capturesActuelles = Convert.ToInt32(r["captures"]);
                string nomEspece = r["espece"].ToString() + " (" + r["couleur"].ToString() + ")";

                Panel pnlLigne = new Panel
                {
                    Location = new Point(0, y),
                    Size = new Size(500, 36),
                    BackColor = bgLigne
                };

                Label lblEspece = new Label
                {
                    Text = nomEspece,
                    ForeColor = textWhite,
                    Font = new Font("Segoe UI", 9F),
                    Location = new Point(5, 9),
                    Size = new Size(265, 20),
                    AutoEllipsis = true
                };

                Label lblObjectif = new Label
                {
                    Text = objectif.ToString(),
                    ForeColor = textGray,
                    Font = new Font("Segoe UI", 9F),
                    Location = new Point(275, 9),
                    Size = new Size(60, 20),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                NumericUpDown nud = new NumericUpDown
                {
                    Location = new Point(345, 6),
                    Size = new Size(120, 24),
                    Minimum = 0,
                    Maximum = 99999,
                    Value = capturesActuelles,
                    BackColor = Color.FromArgb(30, 45, 80),
                    ForeColor = Color.FromArgb(80, 220, 120),
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    BorderStyle = BorderStyle.FixedSingle,
                    TabIndex = i
                };

                pnlLigne.Controls.AddRange(new Control[] { lblEspece, lblObjectif, nud });
                pnlScroll.Controls.Add(pnlLigne);

                lignes.Add((idEspece, nud));
                y += 40;
                i++;
            }

            if (y < 340)
                pnlScroll.AutoScroll = false;
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Stargate.db"))
                {
                    conn.Open();
                    using (SQLiteTransaction tx = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (var (idEspece, nud) in lignes)
                            {
                                int nouvCaptures = (int)nud.Value;

                                SQLiteCommand cmdCheck = new SQLiteCommand(
                                    "SELECT COUNT(*) FROM Capturer WHERE nomPlanete=@p AND numeroMission=@n AND idEspeceEnnemi=@id",
                                    conn, tx);
                                cmdCheck.Parameters.AddWithValue("@p", nomPlanete);
                                cmdCheck.Parameters.AddWithValue("@n", numeroMission);
                                cmdCheck.Parameters.AddWithValue("@id", idEspece);
                                int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                                if (count > 0)
                                {
                                    SQLiteCommand cmdUpd = new SQLiteCommand(
                                        "UPDATE Capturer SET nombre=@nb WHERE nomPlanete=@p AND numeroMission=@n AND idEspeceEnnemi=@id",
                                        conn, tx);
                                    cmdUpd.Parameters.AddWithValue("@nb", nouvCaptures);
                                    cmdUpd.Parameters.AddWithValue("@p", nomPlanete);
                                    cmdUpd.Parameters.AddWithValue("@n", numeroMission);
                                    cmdUpd.Parameters.AddWithValue("@id", idEspece);
                                    cmdUpd.ExecuteNonQuery();
                                }
                                else if (nouvCaptures > 0)
                                {
                                    SQLiteCommand cmdIns = new SQLiteCommand(
                                        "INSERT INTO Capturer (nomPlanete, numeroMission, idEspeceEnnemi, nombre) VALUES (@p, @n, @id, @nb)",
                                        conn, tx);
                                    cmdIns.Parameters.AddWithValue("@p", nomPlanete);
                                    cmdIns.Parameters.AddWithValue("@n", numeroMission);
                                    cmdIns.Parameters.AddWithValue("@id", idEspece);
                                    cmdIns.Parameters.AddWithValue("@nb", nouvCaptures);
                                    cmdIns.ExecuteNonQuery();
                                }
                            }

                            tx.Commit();
                            MessageBox.Show("Captures mises à jour avec succès !",
                                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Succes = true;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch
                        {
                            tx.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
