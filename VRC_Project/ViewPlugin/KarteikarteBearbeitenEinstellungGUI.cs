using System;
using System.Windows.Forms;
using VRC.Application;

namespace VRC.ViewPlugin
{
    public partial class KarteikartenBearbeitenEinstellungGUI: Form
    {
        KarteikartenBearbeitenEinstellung karteikartenBearbeitenEinstellung = new KarteikartenBearbeitenEinstellung();
        public KarteikartenBearbeitenEinstellung Einstellung     
        => karteikartenBearbeitenEinstellung;

        public KarteikartenBearbeitenEinstellungGUI()
        {
            InitializeComponent();
        }

        private void btnKarteikartensetSuchen_Click(object sender, EventArgs e)
        {
            txtBxPfadLadeKarteikartenset.Text = FrageXMLFileAb();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SpeichereDateipfad();
            if (string.IsNullOrEmpty(karteikartenBearbeitenEinstellung.Speicherort))
                BeendeFenster();
            else
                MessageBox.Show("Bitte geben Sie einen gültigen Dateipfad an.");
        }

        /*
         *  Wie
         **/
        private void SpeichereDateipfad()
        {
            karteikartenBearbeitenEinstellung.Speicherort = txtBxPfadLadeKarteikartenset.Text;
        }

        private static string FrageXMLFileAb()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml Dateien (*.xml)|*.xml| Alle Dateien (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }

            return "";
        }

        private void BeendeFenster()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            this.Dispose();
        }

    }
}
