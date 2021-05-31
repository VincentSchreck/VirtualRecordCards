using System.Collections.Generic;

namespace VRC.Domain
{
    public class RecordCardAufzaehlungContent : RecordCardContent
    {
        private string _questionAufzaehlung = "";
        private List<string> AnswerAufzaehlung;

        public string QuestionAufzaehlung
        {
            get
            {
                return _questionAufzaehlung;
            }
            set
            {
                _questionAufzaehlung = value;
            }
        }

        public RecordCardAufzaehlungContent()
        {
            AnswerAufzaehlung = new List<string>();
        }

<<<<<<< Updated upstream

        public string getQuestion()
=======
        public string ErhalteQuestion()
>>>>>>> Stashed changes
        {
            return QuestionAufzaehlung;
        }

        public List<string> getAnswerAufzaehlung()
        {
            if (AnswerAufzaehlung == null)
                AnswerAufzaehlung = new List<string>();

            return AnswerAufzaehlung;
        }

        public void addAnswerValue(string item)
        {
            if (AnswerAufzaehlung == null)
                AnswerAufzaehlung = new List<string>();
            AnswerAufzaehlung.Add(item);
        }
        public void removeAnswerValue(int index)
        {

            if (AnswerAufzaehlung.Count > index)
                AnswerAufzaehlung.RemoveAt(index);
        }

        public string getRecordCardType()
        {
            return "Aufzaehlung";
        }
    }
}
