using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRC.Klassen
{
    public partial class RecordcardAufzaehlung : UserControl
    {
        public RecordcardAufzaehlung()
        {
            InitializeComponent();
        }

        private void btnAufzaehlungAntwortHinzu_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtBoxAufzaehlungsitem.Text))
            {
                listBoxAntwort.Items.Add(txtBoxAufzaehlungsitem.Text);
            }
        }

        private void btnAufzaehlungLoeschen_Click(object sender, EventArgs e)
        {
            if(listBoxAntwort.SelectedIndex >= 0)
            {
                listBoxAntwort.Items.RemoveAt(listBoxAntwort.SelectedIndex);
                //TODO: Mehrere items gleichzeitig auswählen und löschen
            }
        }
    }
}
