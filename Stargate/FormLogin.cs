using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using BCrypt.Net;

namespace Stargate
{
    /// <summary>
    /// Formulaire de connexion avec authentification BCrypt.
    /// Donne accès à la création de missions (volet 2).
    /// </summary>
    public partial class FormLogin : Form
    {
        public bool Authentifie { get; private set; } = false;

        private readonly string chaine = @"Data Source=Stargate.db";

        public FormLogin()
        {
            InitializeComponent();

            btnConnexion.FlatAppearance.BorderColor = Color.FromArgb(50, 130, 255);
            pnlCarte.Paint += (s, e) =>
            {
                using (var pen = new Pen(Color.FromArgb(40, 80, 160), 1))
                    e.Graphics.DrawRectangle(pen, 0, 0, pnlCarte.Width - 1, pnlCarte.Height - 1);
            };
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            lblErreur.Text = "";
            string login = txtLogin.Text.Trim();
            string mdpSaisi = txtMdp.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(mdpSaisi))
            {
                lblErreur.Text = "Identifiant et mot de passe requis.";
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(chaine))
                {
                    conn.Open();
                    string sql = "SELECT mdp FROM Admin WHERE login = @login";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    object resultat = cmd.ExecuteScalar();

                    if (resultat == null || resultat == DBNull.Value)
                    {
                        lblErreur.Text = "Identifiant ou mot de passe incorrect.";
                        txtMdp.Clear();
                        return;
                    }

                    string mdpStocke = resultat.ToString();
                    bool valide = BCrypt.Net.BCrypt.Verify(mdpSaisi, mdpStocke);

                    if (valide)
                    {
                        Authentifie = true;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        lblErreur.Text = "Identifiant ou mot de passe incorrect.";
                        txtMdp.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                lblErreur.Text = "Erreur de connexion à la base.";
                Console.WriteLine(ex.Message);
            }
        }

    }
}
