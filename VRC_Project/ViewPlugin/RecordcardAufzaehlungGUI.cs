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
            txtBoxTextFrage.Text = content.ErhalteQuestion();
            foreach (var item in content.ErhalteAnswerAufzaehlung())
            {
                listBoxAntwort.Items.Add(item);
            }
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
                content.FuegeAntwortHinzu(item.ToString());
            }
            return content;
        }
    }
}
