using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRC.Model
{
    public class Recordcard
    {
        public Recordcard()
        {
            Topic = "";
            Question = "";
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

        private string _question;
        public string Question
        {
            get
            {
                return _question;
            }
            set
            {
                _question = value;
            }
        }

        private string _answer;
        public string Answer
        {
            get
            {
                return _answer;
            }
            set
            {
                _answer = value;
            }
        }

        public string toString()
        {

            string str = "";

            if (Topic.Length > 8)
                str += Topic.Substring(0, 7);
            else
                str += Topic;

            str += "|";

            if (Question.Length > 8)
                str += Question.Substring(0, 7);
            else
                str += Question;

            return str;
        }
    }
}
