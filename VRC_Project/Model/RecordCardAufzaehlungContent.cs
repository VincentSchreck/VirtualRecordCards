using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VRC.Model
{
    public class RecordCardAufzaehlungContent : RecordcardContent
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

        public XmlNode GebeInhalteZurueckInXML(XmlDocument document, XmlNode recordcardNode)
        {


            return recordcardNode;
        }

        public string getQuestion()
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
