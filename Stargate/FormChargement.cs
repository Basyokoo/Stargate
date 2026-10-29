using System.Drawing;
using System.Windows.Forms;

namespace Stargate
{
    /// <summary>
    /// Fenêtre de chargement animée à afficher pendant les opérations longues (requêtes BD, génération PDF…).
    /// Utilisation : Show(parent) avant l'opération, Close() après.
    /// </summary>
    public partial class FormChargement : Form
    {
        public FormChargement(string message = "⏳  Chargement en cours")
        {
            InitializeComponent();
            lblMessage.Text = message;

            // Dessiner une bordure bleue autour de la carte
            pnlContenu.Paint += (s, e) =>
            {
                using (var pen = new Pen(Color.FromArgb(40, 80, 160), 1))
                    e.Graphics.DrawRectangle(pen, 0, 0, pnlContenu.Width - 1, pnlContenu.Height - 1);
            };
        }
    }
}
