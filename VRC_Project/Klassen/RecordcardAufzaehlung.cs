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
        public RecordcardAufzaehlung(string frage, List<String> antwort)
        {
            InitializeComponent();
            txtBoxTextFrage.Text = frage;
            foreach(var item in antwort)
            {
                listBoxAntwort.Items.Add(item);
            }
        }

        public string getQuestion()
        {
            return txtBoxTextFrage.Text;
        }

        public List<String> getAnswer()
        {
            List<String> antwortListe = new List<String>();
            foreach (var item in listBoxAntwort.Items)
            {
                antwortListe.Add(item.ToString());
            }

            return antwortListe;
        }

        private void btnAufzaehlungAntwortHinzu_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtBoxAufzaehlungsitem.Text))
            {
                listBoxAntwort.Items.Add(txtBoxAufzaehlungsitem.Text);
                txtBoxAufzaehlungsitem.Text = "";
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
