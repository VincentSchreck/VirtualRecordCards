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


        public string ErhalteQuestion()
        {
            return QuestionAufzaehlung;
        }

        public List<string> ErhalteAnswerAufzaehlung()
        {
            if (AnswerAufzaehlung == null)
                AnswerAufzaehlung = new List<string>();

            return AnswerAufzaehlung;
        }

        public void FuegeAntwortHinzu(string item)
        {
            if (AnswerAufzaehlung == null)
                AnswerAufzaehlung = new List<string>();
            AnswerAufzaehlung.Add(item);
        }

        public string ErhalteRecordCardType()
        {
            return "Aufzaehlung";
        }
    }
}
