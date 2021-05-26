using System;
using System.Collections.Generic;
using VRC.Domain;

namespace VRC.ViewPlugin
{
    public partial class RecordcardMultipleChoiceGUI : RecordCardTypeGUI
    {
        public RecordcardMultipleChoiceGUI()
        {
            InitializeComponent();
        }
        



        public RecordcardMultipleChoiceGUI(RecordCardMultipleChoiceContent content)
        {
            InitializeComponent();
            txtBoxMCFrage.Text = content.getQuestion();
            foreach (var item in content.getMultipleChoiceList())
            {
                checkedListBoxMCFrage.Items.Add(item);
            }
            txtBoxMCAntwort.Text = content.AnswerMultipleChoice;
        }

        public RecordcardMultipleChoiceGUI(string frage, List<String> choices, string answer)
        {
            InitializeComponent();
            txtBoxMCFrage.Text = frage;
            foreach(var item in choices)
            {
                checkedListBoxMCFrage.Items.Add(item);
            }
            txtBoxMCAntwort.Text = answer;
        }


        public string getQuestion()
        {
            return txtBoxMCFrage.Text;
        }
        public List<string> getMultipleChoices()
        {
            List<String> antwortmoeglichkeit = new List<string>();
            foreach (var item in checkedListBoxMCFrage.Items)
            {
                antwortmoeglichkeit.Add(item.ToString());
            }

            return antwortmoeglichkeit;
        }

        public string getAnswer()
        {
            return txtBoxMCAntwort.Text;
        }

        private void btnAntwortHinzufuegen_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxMCAntwortMoeglichkeit.Text))
            {
                checkedListBoxMCFrage.Items.Add(txtBoxMCAntwortMoeglichkeit.Text);
                //TODO: Mehrzeilige Antwortmöglichkeiten sollen mehrere Antworten ergeben
                txtBoxMCAntwortMoeglichkeit.Text = "";
            }
        }

        private void btnAntwortLoeschen_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMCFrage.SelectedIndex >= 0)
            {
                checkedListBoxMCFrage.Items.RemoveAt(checkedListBoxMCFrage.SelectedIndex);
                //TODO: Mehrere items gleichzeitig auswählen und löschen
            }
        }

        public override RecordCardContent EntnehmeContent()
        {
            RecordCardMultipleChoiceContent recordCardMultipleChoiceContent = new RecordCardMultipleChoiceContent();
            recordCardMultipleChoiceContent.QuestionMultipleChoice = txtBoxMCFrage.Text;
            foreach (var item in checkedListBoxMCFrage.Items)
            {
                recordCardMultipleChoiceContent.addMultipleChoiceValue(item.ToString());
            }
            recordCardMultipleChoiceContent.AnswerMultipleChoice = txtBoxMCAntwort.Text;
            return recordCardMultipleChoiceContent;
        }
    }
}
