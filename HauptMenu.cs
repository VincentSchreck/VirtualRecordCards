using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRC.Klassen;

namespace VRC
{
    public partial class HauptMenu : Form
    {
        public HauptMenu()
        {
            InitializeComponent();
        }

        KarteikartenBearbeitenEinstellung KarteiKarteBearbeitenOeffner;
        PruefEinstellungenGUI PruefEinstellungenFensterOeffner;
        Pruefmodus PruefmodusFensterOeffner;
        KarteikartenErstellen KarteikartenErstellerFensterOeffner;
        KarteikartenBearbeiten karteikartenBearbeiterFensterOeffner;
        
        private void btnPruefmodus_Click(object sender, EventArgs e)
        {
            PruefEinstellungenFensterOeffner = new PruefEinstellungenGUI();
            PruefEinstellungenFensterOeffner.ShowDialog(this);
            if(PruefEinstellungenFensterOeffner.DialogResult == DialogResult.OK)
            {
                PruefmodusFensterOeffner = new Pruefmodus(PruefEinstellungenFensterOeffner.pruefEinstellungData);
                PruefmodusFensterOeffner.ShowDialog(this);
            }
        }

        private void btnKarteikarteErstellen_Click(object sender, EventArgs e)
        {
            KarteikartenErstellerFensterOeffner = new KarteikartenErstellen();
            KarteikartenErstellerFensterOeffner.ShowDialog(this);
        }

        private void btnKarteikarteBearbeiten_Click(object sender, EventArgs e)
        {
            KarteiKarteBearbeitenOeffner = new KarteikartenBearbeitenEinstellung();
            KarteiKarteBearbeitenOeffner.ShowDialog(this);
            if (KarteiKarteBearbeitenOeffner.DialogResult == DialogResult.OK)
            {
                karteikartenBearbeiterFensterOeffner = new KarteikartenBearbeiten(KarteiKarteBearbeitenOeffner.speicherort);
                karteikartenBearbeiterFensterOeffner.ShowDialog(this);
            }
        }
    }
}
