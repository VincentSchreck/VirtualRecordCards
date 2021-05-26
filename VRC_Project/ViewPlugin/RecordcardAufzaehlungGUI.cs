using System;
using System.Collections.Generic;
using VRC.Domain;

namespace VRC.ViewPlugin
{
    public partial class RecordcardAufzaehlungGUI : RecordCardTypeGUI
    {
        public RecordcardAufzaehlungGUI()
        {
            InitializeComponent();
        }

        public RecordcardAufzaehlungGUI(RecordCardAufzaehlungContent content)
        {
            InitializeComponent();
            txtBoxTextFrage.Text = content.getQuestion();
            foreach (var item in content.getAnswerAufzaehlung())
            {
                listBoxAntwort.Items.Add(item);
            }
        }

        public RecordcardAufzaehlungGUI(string frage, List<String> antwort)
        {
            InitializeComponent();
            txtBoxTextFrage.Text = frage;
            foreach(var item in antwort)
            {
                listBoxAntwort.Items.Add(item);
            }
        }

        public string getQuestion()
        {
            return txtBoxTextFrage.Text;
        }

        public List<String> getAnswer()
        {
            List<String> antwortListe = new List<String>();
            foreach (var item in listBoxAntwort.Items)
            {
                antwortListe.Add(item.ToString());
            }

            return antwortListe;
        }

        private void btnAufzaehlungAntwortHinzu_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtBoxAufzaehlungsitem.Text))
            {
                listBoxAntwort.Items.Add(txtBoxAufzaehlungsitem.Text);
                txtBoxAufzaehlungsitem.Text = "";
            }
        }

        private void btnAufzaehlungLoeschen_Click(object sender, EventArgs e)
        {
            if(listBoxAntwort.SelectedIndex >= 0)
            {
                listBoxAntwort.Items.RemoveAt(listBoxAntwort.SelectedIndex);
                //TODO: Mehrere items gleichzeitig auswählen und löschen
            }
        }


        public override RecordCardContent EntnehmeContent()
        {
            RecordCardAufzaehlungContent content = new RecordCardAufzaehlungContent();
            content.QuestionAufzaehlung = txtBoxTextFrage.Text;
            foreach (var item in listBoxAntwort.Items)
            {
                content.addAnswerValue(item.ToString());
            }
            return content;
        }
    }
}
