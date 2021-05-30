namespace VRC.Domain
{
    public class RecordCardAbbildungContent : RecordCardContent
    {
        private string _imagePath = "";
        private string _questionAbbildung = "";

        public string ImagePath
        {
            get {
                return _imagePath;
            }
            set {
                _imagePath = value;
            }
           
        }

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


        public string getQuestion()
        {
            return QuestionAbbildung;
        }

        public string getRecordCardType()
        {
            return "Abbildung";
        }

    }
}

