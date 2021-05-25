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

        #region Einteilungsvariablen
        //private string _questionAbbildung;
        //public string QuestionAbbildung
        //{
        //    get
        //    {
        //        return _questionAbbildung;
        //    }
        //    set
        //    {
        //        _questionAbbildung = value;
        //    }
        //}

        //private string _answerAbbildung;
        //public string AnswerAbbildung
        //{
        //    get
        //    {
        //        return _answerAbbildung;
        //    }
        //    set
        //    {
        //        _answerAbbildung = value;
        //    }
        //}

        //private string _questionText;
        //public string QuestionText
        //{
        //    get
        //    {
        //        return _questionText;
        //    }
        //    set
        //    {
        //        _questionText = value;
        //    }
        //}

        //private string _answerText;
        //public string AnswerText
        //{
        //    get
        //    {
        //        return _answerText;
        //    }
        //    set
        //    {
        //        _answerText = value;
        //    }
        //}

        //private string _questionAufzaehlung;
        //public string QuestionAufzaehlung
        //{
        //    get
        //    {
        //        return _questionAufzaehlung;
        //    }
        //    set
        //    {
        //        _questionAufzaehlung = value;
        //    }
        //}

        //private List<string> _answerAufzaehlung;
        //public List<string> AnswerAufzaehlung
        //{
        //    get
        //    {
        //        return _answerAufzaehlung;
        //    }
        //    set
        //    {
        //        _answerAufzaehlung = value;
        //    }
        //}

        //private string _questionMultipleChoice;
        //public string QuestionMultipleChoice
        //{
        //    get
        //    {
        //        return _questionMultipleChoice;
        //    }
        //    set
        //    {
        //        _questionMultipleChoice = value;
        //    }
        //}

        //private List<string> _choicesMultipleChoice;
        //public List<string> ChoicesMultipleChoice
        //{
        //    get
        //    {
        //        return _choicesMultipleChoice;
        //    }
        //    set
        //    {
        //        _choicesMultipleChoice = value;
        //    }
        //}

        //private string _answerMultipleChoice;
        //public string AnswerMultipleChoice
        //{
        //    get
        //    {
        //        return _answerMultipleChoice;
        //    }
        //    set
        //    {
        //        _answerMultipleChoice = value;
        //    }
        //}
        #endregion

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
