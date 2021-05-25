using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VRC.Model
{
    public class RecordCardAbbildungContent : RecordcardContent
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
