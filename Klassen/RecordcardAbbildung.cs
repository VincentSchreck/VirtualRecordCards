using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VRC.Klassen
{
    public partial class RecordcardAbbildung : UserControl
    {
        public RecordcardAbbildung()
        {
            InitializeComponent();
        }

        private void btnAbbildungSuchen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png Dateien (*.png)|*.png| jpg Dateien (*.jpg)|*.jpg| Alle Dateien (*.*)|*.*"; ;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(ofd.FileName);
                if (info.Length > 1000000)
                {
                   string file = ofd.FileName; //Dateiname der ausgewählten Datei
                }
                else
                {
                    MessageBox.Show("Die ausgewählte Grafik überschreitet die maximale Dateigröße. Bitte wählen Sie eine Datei unter 1MB.");
                }
            }
        }

        private void txtBoxGrafikSuchen_Leave(object sender, EventArgs e)
        {
            //TODO: Grafikpfad auslesen und Grafik anzeigen
        }
    }
}
