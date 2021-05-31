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

        public string ErhalteQuestion()
        {
            return _questionMultipleChoice;
        }

        public void FuegeMultipleChoiceWertHinzu(string item)
        {
            if (_choicesMultipleChoice == null)
                _choicesMultipleChoice = new List<string>();
            _choicesMultipleChoice.Add(item);
        }

        public List<string> ErhalteMultipleChoiceListe()
        {
            if (_choicesMultipleChoice == null)
                _choicesMultipleChoice = new List<string>();

            return _choicesMultipleChoice;
        }

        public string ErhalteRecordCardType()
        {
            return "Multiple Choice";
        }

    }
}
