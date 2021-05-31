using VRC.Domain;

namespace VRC.ViewPlugin
{


    public partial class RecordcardTextGUI : RecordCardTypeGUI
    { 
        public RecordcardTextGUI(RecordCardTextContent content)
        {
            InitializeComponent();
            txtBoxTextFrage.Text = content.QuestionText;
            txtBoxTextAntwort.Text = content.AnswerText;
        }

        public override RecordCardContent EntnehmeContent()
        {
            RecordCardTextContent recordCardTextContent = new RecordCardTextContent();
            recordCardTextContent.QuestionText = txtBoxTextFrage.Text;
            recordCardTextContent.AnswerText = txtBoxTextAntwort.Text;
            return recordCardTextContent;
        }
    }
}
