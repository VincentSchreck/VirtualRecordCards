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
    public partial class PruefEinstellungenGUI : Form
    {
        public PruefEinstellungenGUI()
        {
            InitializeComponent();
        }

        public PruefEinstellungData pruefEinstellungData = new PruefEinstellungData();
        string speicherort = "";

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
                pruefEinstellungData.speicherortKarteikartenset = speicherort;
                pruefEinstellungData.wiederholungenErlauben = checkBoxWiederholungenZulassen.Checked;
                pruefEinstellungData.anzahlWiederholungen = (uint)numericUpDownAnzWiederholungen.Value;
                pruefEinstellungData.nurFalschBeantwortete = checkBoxNurFalschBeantwortete.Checked;
                pruefEinstellungData.alleKarteikarten = checkBox1.Checked;
                pruefEinstellungData.anzahlGenerellKarteikarten = (uint)numericUpDownGenerelleAnzahl.Value;
                pruefEinstellungData.zufallsreihenfolge = checkBoxZufallsreihenfolge.Checked;
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Dateipfad an.");
            }

        }

        private void checkBoxWiederholungenZulassen_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownAnzWiederholungen.Enabled = checkBoxWiederholungenZulassen.Checked;
            checkBoxNurFalschBeantwortete.Enabled = checkBoxWiederholungenZulassen.Checked;
            lblWieOft.Enabled = checkBoxWiederholungenZulassen.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownGenerelleAnzahl.Enabled = !checkBox1.Checked;
        }
    }
}
