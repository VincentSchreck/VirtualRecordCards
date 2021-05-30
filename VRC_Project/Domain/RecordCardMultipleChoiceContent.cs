using System.Collections.Generic;

namespace VRC.Domain
{
    public class RecordCardMultipleChoiceContent : RecordCardContent
    {
        private string _questionMultipleChoice = "";
        private List<string> _choicesMultipleChoice;
        private string _answerMultipleChoice = "";

        public RecordCardMultipleChoiceContent()
        {
            ChoicesMultipleChoice = new List<string>();
        }

        public string getQuestion()
        {
            return _questionMultipleChoice;
        }

        public string getRecordCardType()
        {
            return "Multiple Choice";
        }

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


    }
}
