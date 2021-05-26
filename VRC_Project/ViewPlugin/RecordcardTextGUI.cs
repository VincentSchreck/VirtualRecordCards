using VRC.Domain;

namespace VRC.ViewPlugin
{


    public partial class RecordcardTextGUI : RecordCardTypeGUI
    {
        public RecordcardTextGUI()
        {
            InitializeComponent();
        }
        public RecordcardTextGUI(RecordCardTextContent content)
        {
            InitializeComponent();
            txtBoxTextFrage.Text = content.QuestionText;
            txtBoxTextAntwort.Text = content.AnswerText;
        }

        public RecordcardTextGUI(string question, string answer)
        {
            InitializeComponent();
            //this.recordCardText = recordCardText;
            txtBoxTextFrage.Text = question;
            txtBoxTextAntwort.Text = answer;
        }

        public string getQuestion()
        {
            return txtBoxTextFrage.Text;
        }

        public string getAnswer()
        {
            return txtBoxTextAntwort.Text;
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
