using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using BCrypt.Net;

namespace Stargate
{
    /// <summary>
    /// Formulaire de création d'un compte Admin.
    /// Hash le mot de passe avec BCrypt.Net avant insertion.
    /// </summary>
    public partial class FormCreerCompte : Form
    {
        public bool CompteCreé { get; private set; } = false;
        public string LoginCree { get; private set; } = "";

        private readonly string chaine = @"Data Source=Stargate.db";

        public FormCreerCompte()
        {
            InitializeComponent();

            btnValider.FlatAppearance.BorderColor = Color.FromArgb(60, 160, 100);
            btnAnnuler.FlatAppearance.BorderColor = Color.FromArgb(160, 60, 60);
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            lblErreur.ForeColor = Color.FromArgb(255, 80, 80);
            string login = txtLogin.Text.Trim();
            string mdp = txtMdp.Text;
            string mdpConfirm = txtMdpConfirm.Text;

            if (string.IsNullOrEmpty(login))
            { lblErreur.Text = "L'identifiant ne peut pas être vide."; return; }
            if (login.Length < 3)
            { lblErreur.Text = "L'identifiant doit faire au moins 3 caractères."; return; }
            if (string.IsNullOrEmpty(mdp))
            { lblErreur.Text = "Le mot de passe ne peut pas être vide."; return; }
            if (mdp.Length < 4)
            { lblErreur.Text = "Le mot de passe doit faire au moins 4 caractères."; return; }
            if (mdp != mdpConfirm)
            { lblErreur.Text = "Les mots de passe ne correspondent pas."; txtMdpConfirm.Clear(); return; }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(chaine))
                {
                    conn.Open();

                    SQLiteCommand cmdCheck = new SQLiteCommand("SELECT COUNT(*) FROM Admin WHERE login = @login", conn);
                    cmdCheck.Parameters.AddWithValue("@login", login);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                    { lblErreur.Text = "Cet identifiant existe déjà."; return; }

                    string hash = BCrypt.Net.BCrypt.HashPassword(mdp, workFactor: 10);

                    SQLiteCommand cmdInsert = new SQLiteCommand(
                        "INSERT INTO Admin (login, mdp) VALUES (@login, @mdp)", conn);
                    cmdInsert.Parameters.AddWithValue("@login", login);
                    cmdInsert.Parameters.AddWithValue("@mdp", hash);
                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show($"Compte '{login}' créé avec succès !\nVous pouvez maintenant vous connecter.",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginCree = login;
                    CompteCreé = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                lblErreur.Text = "Erreur : " + ex.Message;
            }
        }
    }
}
