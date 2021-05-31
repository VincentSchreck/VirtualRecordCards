using System;
using System.Windows.Forms;

namespace VRC.ViewPlugin
{
    public partial class HauptMenu : Form
    {
        public HauptMenu()
        {
            InitializeComponent();
        }

        KarteikartenBearbeitenEinstellungGUI KarteiKarteBearbeitenEinstellungOeffner;
        PruefmodusGUI PruefmodusFensterOeffner;
        KarteikartenEditorGUI KarteikartenEditorFensterOeffner;
        
        private void btnPruefmodus_Click(object sender, EventArgs e)
        {
            OeffnePruefModus();
        }

        private void btnKarteikarteErstellen_Click(object sender, EventArgs e)
        {
            OeffneKarteiKartenEditor();
        }

        private void btnKarteikarteBearbeiten_Click(object sender, EventArgs e)
        {
            OeffneKarteikartenEditorZumBearbeiten();
        }

        private void OeffneKarteikartenEditorZumBearbeiten()
        {
            KarteiKarteBearbeitenEinstellungOeffner = new KarteikartenBearbeitenEinstellungGUI();
            KarteiKarteBearbeitenEinstellungOeffner.ShowDialog(this);
            if (KarteiKarteBearbeitenEinstellungOeffner.DialogResult == DialogResult.OK)
            {
                try
                {
                    KarteikartenEditorFensterOeffner = new KarteikartenEditorGUI(KarteiKarteBearbeitenEinstellungOeffner.Einstellung.Speicherort);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fehler beim Lesen der Datei");
                    return;
                }
                KarteikartenEditorFensterOeffner.ShowDialog(this);
            }
        }

        private void OeffnePruefModus()
        {
            PruefEinstellungenGUI.Instanz.ShowDialog(this);
            if (PruefEinstellungenGUI.Instanz.DialogResult == DialogResult.OK)
            {
                PruefmodusFensterOeffner = new PruefmodusGUI(PruefEinstellungenGUI.Instanz.ErhaltePruefEinstellungen());
                PruefmodusFensterOeffner.ShowDialog(this);
            }
        }

        private void OeffneKarteiKartenEditor()
        {
            KarteikartenEditorFensterOeffner = new KarteikartenEditorGUI();
            KarteikartenEditorFensterOeffner.ShowDialog(this);
        }
    }
}
