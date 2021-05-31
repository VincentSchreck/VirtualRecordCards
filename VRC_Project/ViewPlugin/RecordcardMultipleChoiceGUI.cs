using System;
using System.Collections.Generic;
using VRC.Domain;

namespace VRC.ViewPlugin
{
    public partial class RecordcardMultipleChoiceGUI : RecordCardTypeGUI
    {    
        public RecordcardMultipleChoiceGUI(RecordCardMultipleChoiceContent content)
        {
            InitializeComponent();
            txtBoxMCFrage.Text = content.ErhalteQuestion();
            foreach (var item in content.ErhalteMultipleChoiceListe())
            {
                checkedListBoxMCFrage.Items.Add(item);
            }
            txtBoxMCAntwort.Text = content.AnswerMultipleChoice;
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
                recordCardMultipleChoiceContent.FuegeMultipleChoiceWertHinzu(item.ToString());
            }
            recordCardMultipleChoiceContent.AnswerMultipleChoice = txtBoxMCAntwort.Text;
            return recordCardMultipleChoiceContent;
        }
    }
}
