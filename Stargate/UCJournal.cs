using System;
using System.Windows.Forms;

namespace Stargate
{
    // User Control représentant un événement du journal de bord
    // La navigation entre les événements se fait via liaison de données (BindingSource)
    public partial class UCJournal : UserControl
    {
        public UCJournal()
        {
            InitializeComponent();
        }

        // Propriétés publiques pour la liaison de données
        public string DateEvenement
        {
            get { return lblDate.Text; }
            set { lblDate.Text = value; }
        }

        public string Commentaire
        {
            get { return txtCommentaire.Text; }
            set { txtCommentaire.Text = value; }
        }
    }
}
