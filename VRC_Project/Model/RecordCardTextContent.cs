using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VRC.Model
{
    public class RecordCardTextContent : RecordcardContent
    {
        private string _answerText;
        private string _questionText;

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


        public string getQuestion()
        {
            return QuestionText;
        }


        public string getRecordCardType()
        {
            return "Text";
        }

    }
}
