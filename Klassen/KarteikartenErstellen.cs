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
    public partial class KarteikartenErstellen : Form
    {
        public KarteikartenErstellen()
        {
            InitializeComponent();
        }

        private void btnSucheDatei_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml Dateien (*.xml)|*.xml| Alle Dateien (*.*)|*.*"; ;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string file = ofd.FileName; //Dateiname der ausgewählten Datei
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNeueKarteikarte_Click(object sender, EventArgs e)
        {
            //TODO: Neue Karteikarte erstellen und die, die gerade bearbeitet wird speichern
        }

        private void btnKarteikarteLoeschen_Click(object sender, EventArgs e)
        {
            //TODO: Aktuelle Karteikarte löschen und die vorherige in der Reihe anzeigen
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            string speicherort = txtBxDateispeicherort.Text;
            //TODO: Speichern
        }

        private void btnVerwerfen_Click(object sender, EventArgs e)
        {
            //TODO: Abfragefenster Öffnen, ggf löschen und fenster schließen
            DialogResult dialogResult = MessageBox.Show("Wollen Sie die aktuelle Sammlung verwerfen?", "Sicher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                //TODO: Später bei der Optimierung löschen
            }
        }
    }
}
