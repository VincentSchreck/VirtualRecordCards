
namespace VRC.Domain
{
    public interface RecordCardContent
    {
        string getQuestion();
        string getRecordCardType();
    }

    public class Recordcard
    {
        private string _thema;
        public string Thema
        {
            get
            {
                return _thema;
            }
            set
            {
                _thema = value;
            }
        }

        public RecordCardContent content;

        public Recordcard()
        {
            Thema = "";
        }

        public Recordcard(RecordCardContent recordCardContent)
        {
            this.content = recordCardContent;
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
            result += "|" + LimitiereWord(Thema) + "|";

            if (content != null)
            {       
                result += LimitiereWord(Question);
            }
            return result;
        }

        private static string LimitiereWord(string eingabe)
        {
            string temp = "";
            if (eingabe.Length > 8)
                temp += eingabe.Substring(0, 7);
            else
                temp += eingabe;
            return temp;
        }
    }
}
