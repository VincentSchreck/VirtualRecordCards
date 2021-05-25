using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRC.Model;

namespace VRC.Klassen
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
        public override RecordcardContent EntnehmeContent()
        {
            RecordCardTextContent recordCardTextContent = new RecordCardTextContent();
            recordCardTextContent.QuestionText = txtBoxTextFrage.Text;
            recordCardTextContent.AnswerText = txtBoxTextAntwort.Text;
            return recordCardTextContent;
        }
    }
}
