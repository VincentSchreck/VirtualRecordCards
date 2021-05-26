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
        PruefEinstellungenGUI PruefEinstellungenFensterOeffner;
        PruefmodusGUI PruefmodusFensterOeffner;
        KarteikartenEditorGUI KarteikartenEditorFensterOeffner;
        
        private void btnPruefmodus_Click(object sender, EventArgs e)
        {
            PruefEinstellungenFensterOeffner = new PruefEinstellungenGUI();
            PruefEinstellungenFensterOeffner.ShowDialog(this);
            if(PruefEinstellungenFensterOeffner.DialogResult == DialogResult.OK)
            {
                PruefmodusFensterOeffner = new PruefmodusGUI(PruefEinstellungenFensterOeffner.ErhaltePruefEinstellungen());
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
