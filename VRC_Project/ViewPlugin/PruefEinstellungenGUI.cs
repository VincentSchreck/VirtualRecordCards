using System;
using System.Windows.Forms;
using VRC.Application;

namespace VRC.ViewPlugin
{
    public partial class PruefEinstellungenGUI : Form
    {
        PruefEinstellungen pruefEinstellungen = new PruefEinstellungen();

        private static PruefEinstellungenGUI instance = null;
        private static readonly object padlock = new object();

        public static PruefEinstellungenGUI Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PruefEinstellungenGUI();
                    }
                    return instance;
                }
            }
        }

    private PruefEinstellungenGUI()
        {
            InitializeComponent();
        }

        private void btnKarteikartensetSuchen_Click(object sender, EventArgs e)
        {
            txtBxPfadLadeKarteikartenset.Text = FrageXMLFileAb();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetzeEinstellungenSpeicherort();
            if (!string.IsNullOrWhiteSpace(pruefEinstellungen.Speicherort))
            {
                UebernehmeEinstellungAusDerGUI();
                BeendeFenster();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Dateipfad an.");
            }
        }

        private void SetzeEinstellungenSpeicherort()
        {
            pruefEinstellungen.Speicherort = txtBxPfadLadeKarteikartenset.Text;
        }

        private void UebernehmeEinstellungAusDerGUI()
        {
            pruefEinstellungen.WiederholungenErlauben = checkBoxWiederholungenZulassen.Checked;
            pruefEinstellungen.AnzahlWiederholungen = (uint)numericUpDownAnzWiederholungen.Value;
            pruefEinstellungen.NurFalschBeantwortete = checkBoxNurFalschBeantwortete.Checked;
            pruefEinstellungen.AlleKarteikarten = checkBox1.Checked;
            pruefEinstellungen.AnzahlGenerellKarteikarten = (uint)numericUpDownGenerelleAnzahl.Value;
            pruefEinstellungen.Zufallsreihenfolge = checkBoxZufallsreihenfolge.Checked;
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

        public PruefEinstellungen ErhaltePruefEinstellungen()
        {
            return pruefEinstellungen;
        }

        private void BeendeFenster()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
