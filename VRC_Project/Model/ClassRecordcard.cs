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
            string type = "", Question = "";
            if (content != null)
            { 
                type = content.getRecordCardType();
                Question = content.getQuestion();
            }

            string result = type ;
            result += "|" + LimitiereWord(Topic) + "|";

            if (content != null)
            {       
                result += LimitiereWord(Question);
            }
            return result;
        }

        private static string LimitiereWord(string eingabe)
        {
            string temp = eingabe;
            if (eingabe.Length > 8)
                temp += eingabe.Substring(0, 7);
            else
                temp += eingabe;
            return temp;
        }
    }
}
