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
    public partial class RecordcardMultipleChoice : UserControl
    {
        public RecordcardMultipleChoice()
        {
            InitializeComponent();
        }

        private void btnAntwortHinzufuegen_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxMCAntwortMoeglichkeit.Text))
            {
                checkedListBoxMCFrage.Items.Add(txtBoxMCAntwortMoeglichkeit.Text);
                //TODO: Mehrzeilige Antwortmöglichkeiten sollen mehrere Antworten ergeben
                //TODO: Fällt mir irgendwann wieder ein...
            }
        }

        private void btnAntwortLoeschen_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMCFrage.SelectedIndex >= 0)
            {
                checkedListBoxMCFrage.Items.RemoveAt(checkedListBoxMCFrage.SelectedIndex);
                //TODO: Mehrere items gleichzeitig auswählen und löschen
            }
        }
    }
}
