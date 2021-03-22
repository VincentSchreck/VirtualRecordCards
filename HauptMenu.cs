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

        Pruefmodus PruefmodusFensteroeffner;
        KarteikartenErstellen KarteikartenErstellerFensteroeffner;
        KarteikartenBearbeiten karteikartenBearbeiterFensteroeffner;
        

        private void btnPruefmodus_Click(object sender, EventArgs e)
        {
            PruefmodusFensteroeffner = new Pruefmodus();
            PruefmodusFensteroeffner.ShowDialog(this);
        }
        private void btnKarteikarteErstellen_Click(object sender, EventArgs e)
        {
            KarteikartenErstellerFensteroeffner = new KarteikartenErstellen();
            KarteikartenErstellerFensteroeffner.ShowDialog(this);
        }

        private void btnKarteikarteBearbeiten_Click(object sender, EventArgs e)
        {
            karteikartenBearbeiterFensteroeffner = new KarteikartenBearbeiten();
            karteikartenBearbeiterFensteroeffner.ShowDialog(this);
        }
    }
}
