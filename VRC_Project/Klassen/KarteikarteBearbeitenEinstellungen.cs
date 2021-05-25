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
        private string _speicherort = "";

        public string Speicherort { get => _speicherort; set => _speicherort = value; }

        public KarteikartenBearbeitenEinstellung()
        {
            InitializeComponent();
        }

        private void btnKarteikartensetSuchen_Click(object sender, EventArgs e)
        {
            SpeichereDateipfad(OeffneXMLFileDialog());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PruefePfadUndBeende();
        }



        /*
         *  Wie
         **/

        private void PruefePfadUndBeende()
        {
            if (!string.IsNullOrWhiteSpace(_speicherort))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                this.Dispose();
            }
            else
                MessageBox.Show("Bitte geben Sie einen gültigen Dateipfad an.");
        }

        private void SpeichereDateipfad(string path)
        {
            _speicherort = path;
            txtBxPfadLadeKarteikartenset.Text = path;
        }

        private static string OeffneXMLFileDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml Dateien (*.xml)|*.xml| Alle Dateien (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }

            return "";
        }


    }
}
