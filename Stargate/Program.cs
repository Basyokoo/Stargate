using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stargate
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Volet1());
        }
    }

    // Small navigation helper included here so it's always compiled even if other files are excluded from the project file.
    public static class NavHelper
    {
        // Requested next volet: "volet2", "volet5", "volet6", "volet7", or null to return to dashboard
        public static string ProchainVolet { get; set; } = null;
    }

    // Minimal loading form used while long operations run. Kept here to ensure type is available at compile time.
    public class FormChargement : Form
    {
        private Label lblMessage;
        private Panel pnlContenu;

        public FormChargement(string message = "⏳  Chargement en cours")
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void InitializeComponent()
        {
            this.lblMessage = new Label();
            this.pnlContenu = new Panel();
            this.SuspendLayout();

            this.pnlContenu.BorderStyle = BorderStyle.None;
            this.pnlContenu.Location = new System.Drawing.Point(6, 6);
            this.pnlContenu.Name = "pnlContenu";
            this.pnlContenu.Size = new System.Drawing.Size(288, 38);
            this.pnlContenu.TabIndex = 0;

            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(10, 10);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "...";

            this.ClientSize = new System.Drawing.Size(300, 50);
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Controls.Add(this.pnlContenu);
            this.pnlContenu.Controls.Add(this.lblMessage);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
