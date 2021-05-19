using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRC.Model
{
    public enum KarteikartenTyp
    {
        Abbildung,
        Text,
        Aufzaehlung,
        MultipleChoice
    }

    public class Recordcard
    {
        public Recordcard()
        {
            Topic = "";

            QuestionAbbildung = "";
            AnswerAbbildung = "";

            QuestionText = "";
            AnswerText = "";

            QuestionAufzaehlung = "";
            AnswerAufzaehlung = new List<string>();

            QuestionMultipleChoice = "";
            ChoicesMultipleChoice = new List<string>();
            AnswerMultipleChoice = "";
        }

        private KarteikartenTyp _karteikartenTyp;
        public KarteikartenTyp KarteikartenTyp
        {
            get
            {
                return _karteikartenTyp;
            }
            set
            {
                _karteikartenTyp = value;
            }
        }


        private string _topic;
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
        private string _questionAbbildung;
        public string QuestionAbbildung
        {
            get
            {
                return _questionAbbildung;
            }
            set
            {
                _questionAbbildung = value;
            }
        }

        private string _answerAbbildung;
        public string AnswerAbbildung
        {
            get
            {
                return _answerAbbildung;
            }
            set
            {
                _answerAbbildung = value;
            }
        }

        private string _questionText;
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

        private string _answerText;
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

        private string _questionAufzaehlung;
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

        private List<string> _answerAufzaehlung;
        public List<string> AnswerAufzaehlung
        {
            get
            {
                return _answerAufzaehlung;
            }
            set
            {
                _answerAufzaehlung = value;
            }
        }

        private string _questionMultipleChoice;
        public string QuestionMultipleChoice
        {
            get
            {
                return _questionMultipleChoice;
            }
            set
            {
                _questionMultipleChoice = value;
            }
        }

        private List<string> _choicesMultipleChoice;
        public List<string> ChoicesMultipleChoice
        {
            get
            {
                return _choicesMultipleChoice;
            }
            set
            {
                _choicesMultipleChoice = value;
            }
        }

        private string _answerMultipleChoice;
        public string AnswerMultipleChoice
        {
            get
            {
                return _answerMultipleChoice;
            }
            set
            {
                _answerMultipleChoice = value;
            }
        }
        #endregion
    }
}
