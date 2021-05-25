using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VRC.Model
{
    public interface RecordcardContent
    {
        string getQuestion();
        string getRecordCardType();
    }

    //public enum KarteikartenTyp
    //{
    //    Text,
    //    Abbildung,
    //    Aufzaehlung,
    //    MultipleChoice
    //}

    public class Recordcard
    {
        public Recordcard()
        {
            Topic = "";
        }

        public Recordcard(RecordcardContent recordCardContent)
        {
            this.content = recordCardContent;
        }

        public RecordcardContent content;


        private string _topic = "";
        public string Topic
        {
            get
            {
                return _topic;
            }
            set
            {
                _topic = value;
            }
        }

        public string getListboxName()
        {

            string type = "";
            if (content != null)
                type = content.getRecordCardType();

            string result = type + "|";

            if (Topic.Length > 8)
                result += Topic.Substring(0, 7);
            else
                result += Topic;

            result += "|";


            String Question = "";

            if (content != null)
                Question = content.getQuestion();

            //switch (KarteikartenTyp)
            //{
            //    case KarteikartenTyp.Abbildung:
            //        Question = QuestionAbbildung;
            //        break;
            //    case KarteikartenTyp.Aufzaehlung:
            //        Question = QuestionAufzaehlung;
            //        break;
            //    case KarteikartenTyp.MultipleChoice:
            //        Question = QuestionMultipleChoice;
            //        break;
            //    case KarteikartenTyp.Text:
            //        Question = QuestionText;
            //        break;
            //}

            if (Question.Length > 8)
                result += Question.Substring(0, 7);
            else
                result += Question;

            return result;
        }
    }
}
