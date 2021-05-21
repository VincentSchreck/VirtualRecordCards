using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRC.Model;

namespace VRC.Klassen
{
    public partial class KarteikartenBearbeitenEinstellung: Form
    {
        public KarteikartenBearbeitenEinstellung()
        {
            InitializeComponent();
        }

        public string speicherort = "";

        private void btnKarteikartensetSuchen_Click(object sender, EventArgs e)
        {
            // Speichern
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml Dateien (*.xml)|*.xml| Alle Dateien (*.*)|*.*"; ;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                speicherort = ofd.FileName; //Dateiname der ausgewählten Datei
                txtBxPfadLadeKarteikartenset.Text = speicherort;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(speicherort))
            {            
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Dateipfad an.");
            }
        }
    }
}
