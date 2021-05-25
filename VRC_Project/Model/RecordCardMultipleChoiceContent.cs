using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VRC.Model
{
    public class RecordCardMultipleChoiceContent : RecordcardContent
    {
        private string _questionMultipleChoice = "";
        private List<string> _choicesMultipleChoice;
        private string _answerMultipleChoice = "";

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

        public RecordCardMultipleChoiceContent()
        {
            ChoicesMultipleChoice = new List<string>();
        }

        public string getQuestion()
        {
            return _questionMultipleChoice;
        }

        public void addMultipleChoiceValue(string item)
        {
            if (_choicesMultipleChoice == null)
                _choicesMultipleChoice = new List<string>();
            _choicesMultipleChoice.Add(item);
        }

        public void removeMultipleChoiceValue(int index)
        {
            if (_choicesMultipleChoice == null)
                _choicesMultipleChoice = new List<string>();

            if(_choicesMultipleChoice.Count > index)
            _choicesMultipleChoice.RemoveAt(index);
        }

        public List<string> getMultipleChoiceList()
        {
            if (_choicesMultipleChoice == null)
                _choicesMultipleChoice = new List<string>();

            return _choicesMultipleChoice;
        }

        public string getRecordCardType()
        {
            return "Multiple Choice";
        }

    }
}
