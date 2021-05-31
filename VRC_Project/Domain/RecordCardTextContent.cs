namespace VRC.Domain
{
    public class RecordCardTextContent : RecordCardContent
    {
        private string _answerText = "";
        private string _questionText = "";

        public string AnswerText
        {
            get
            {
                return _answerText;
            }
            set
            {
                _answerText = value;
            }

        }

        public string QuestionText
        {
            get
            {
                return _questionText;
            }
            set
            {
                _questionText = value;
            }
        }

        public string ErhalteQuestion()
        {
            return QuestionText;
        }

        public string ErhalteRecordCardType()
        {
            return "Text";
        }

    }
}

