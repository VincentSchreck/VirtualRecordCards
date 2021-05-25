using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VRC.Model;

namespace VRC.Klassen
{
    public partial class RecordcardAbbildungGUI : RecordCardTypeGUI
    {
        public RecordcardAbbildungGUI()
        {
            InitializeComponent();
        }

        public RecordcardAbbildungGUI(RecordCardAbbildungContent content)
        {
            InitializeComponent();
            txtBoxTextFrage.Text = content.getQuestion();
            txtBoxGrafikSuchen.Text = content.ImagePath;

            if (!string.IsNullOrWhiteSpace(txtBoxGrafikSuchen.Text))
            {
                //TODO: testen ob das file wirklich png oder allgemein ein Bild ist
                //pictureBoxAntwort.Image = Image.FromFile(txtBoxGrafikSuchen.Text);
            }
        }

        public RecordcardAbbildungGUI(string frage, string antwort)
        {
            InitializeComponent();
            txtBoxTextFrage.Text = frage;
            txtBoxGrafikSuchen.Text = antwort;

            if (!string.IsNullOrWhiteSpace(txtBoxGrafikSuchen.Text))
            {
                //TODO: testen ob das file wirklich png oder allgemein ein Bild ist
                //pictureBoxAntwort.Image = Image.FromFile(txtBoxGrafikSuchen.Text);
            }
        }

        public string getQuestion()
        {
            return txtBoxTextFrage.Text;
        }

        public string getAnswer()
        {
            return txtBoxGrafikSuchen.Text;
        }

        private void btnAbbildungSuchen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png Dateien (*.png)|*.png| jpg Dateien (*.jpg)|*.jpg| Alle Dateien (*.*)|*.*"; ;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(ofd.FileName);
                if (info.Length < 10000000)
                {
                    txtBoxGrafikSuchen.Text = ofd.FileName; //Dateiname der ausgewählten Datei
                    pictureBoxAntwort.Image = Image.FromFile(txtBoxGrafikSuchen.Text);
                }
                else
                {
                    MessageBox.Show("Die ausgewählte Grafik überschreitet die maximale Dateigröße. Bitte wählen Sie eine Datei unter 10MB.");
                }
            }
        }

        public override RecordcardContent EntnehmeContent()
        {
            RecordCardAbbildungContent content = new RecordCardAbbildungContent();
            content.QuestionAbbildung = txtBoxTextFrage.Text;
            content.ImagePath = txtBoxGrafikSuchen.Text;
            return content;
        }
    }
}
