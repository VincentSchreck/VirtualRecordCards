
namespace VRC.Domain
{
    public interface RecordCardContent
    {
        string ErhalteQuestion();
        string ErhalteRecordCardType();
    }

    public class Recordcard
    {
        public string Thema { get; set; }

        public RecordCardContent content;

        public Recordcard(){}

        public string ErhalteRecordcardName()
        {
            string type = "", Question = "";
            if (content != null)
            { 
                type = content.ErhalteRecordCardType();
                Question = content.ErhalteQuestion();
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
