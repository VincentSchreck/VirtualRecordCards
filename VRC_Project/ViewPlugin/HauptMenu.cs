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
            PruefEinstellungenGUI.Instance.ShowDialog(this);
            if(PruefEinstellungenGUI.Instance.DialogResult == DialogResult.OK)
            {
                PruefmodusFensterOeffner = new PruefmodusGUI(PruefEinstellungenGUI.Instance.ErhaltePruefEinstellungen());
                PruefmodusFensterOeffner.ShowDialog(this);
            }
        }

        private void btnKarteikarteErstellen_Click(object sender, EventArgs e)
        {
            KarteikartenEditorFensterOeffner = new KarteikartenEditorGUI();
            KarteikartenEditorFensterOeffner.ShowDialog(this);
        }

        private void btnKarteikarteBearbeiten_Click(object sender, EventArgs e)
        {
            KarteiKarteBearbeitenEinstellungOeffner = new KarteikartenBearbeitenEinstellungGUI();
            KarteiKarteBearbeitenEinstellungOeffner.ShowDialog(this);
            if (KarteiKarteBearbeitenEinstellungOeffner.DialogResult == DialogResult.OK)
            {
                try
                {
                    KarteikartenEditorFensterOeffner = new KarteikartenEditorGUI(KarteiKarteBearbeitenEinstellungOeffner.Einstellung.Speicherort);                   
                }
                catch(Exception)
                {
                    MessageBox.Show("Fehler beim Lesen der Datei");
                    return;
                }
                KarteikartenEditorFensterOeffner.ShowDialog(this);
            }
        }
    }
}
