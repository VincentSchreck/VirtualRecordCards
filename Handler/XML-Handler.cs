using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using VRC.Model;

namespace VRC.Handler
{
    public static class XMLHandler
    {
        public static RecordcardSet DeserializeFromXML(string text)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(text);

            return DeserializeFromXML(xmlDocument);
        }

        public static RecordcardSet DeserializeFromXML(XmlDocument xmlDocument)
        {
            RecordcardSet recordcardSet = new RecordcardSet();

            if (xmlDocument.HasChildNodes && xmlDocument.FirstChild.Name == "recordcardset")
            {
                XmlElement recordcardsetNode = xmlDocument.GetElementById("recordcardset");
                recordcardSet.Subject = recordcardsetNode.GetAttribute("subject");

                foreach (XmlNode recordcardnode in recordcardsetNode.ChildNodes)
                {
                    if (recordcardnode.Name == "recordcard")
                    {
                        Recordcard recordcard = new Recordcard();
                        recordcard.Topic = recordcardsetNode.GetAttribute("topic");
                        //recordcard.Question = recordcardsetNode.GetAttribute("question");
                        //recordcard.Answer = recordcardsetNode.GetAttribute("answer");
                        recordcardSet.RecordcardList.Add(recordcard);
                    }
                }
            }

            return recordcardSet;
        }

        public static XmlDocument SerializeToXML(RecordcardSet recordcardSet)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode recordcardsetNode = xmlDocument.CreateElement("recordcardset");
            XmlAttribute subjectAttribute = xmlDocument.CreateAttribute("subject");
            subjectAttribute.Value = recordcardSet.Subject;
            recordcardsetNode.Attributes.Append(subjectAttribute);
            xmlDocument.AppendChild(recordcardsetNode);

            //TODO: Zeilenumbrüche werden beim Umwandeln in XML-Format nicht dargestellt, sondern nur als Leerzeichen.

            foreach (Recordcard recordcard in recordcardSet.RecordcardList)
            {
                XmlNode recordcardNode = xmlDocument.CreateElement("recordcard");

                XmlAttribute topicAttribute = xmlDocument.CreateAttribute("topic");
                topicAttribute.Value = recordcard.Topic;
                recordcardNode.Attributes.Append(topicAttribute);

                switch (recordcard.KarteikartenTyp)
                {
                    case KarteikartenTyp.Text:
                        XmlNode questionTextElement = xmlDocument.CreateElement("questionText");
                        questionTextElement.InnerText = recordcard.QuestionText;
                        recordcardNode.AppendChild(questionTextElement);

                        XmlNode answerTextElement = xmlDocument.CreateElement("answerText");
                        answerTextElement.InnerText = recordcard.AnswerText;
                        recordcardNode.AppendChild(answerTextElement);

                        //ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].QuestionText = recordcardText.getQuestion();
                        //ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].AnswerText = recordcardText.getAnswer();
                        break;
                    case KarteikartenTyp.Abbildung:
                        XmlNode questionAbbildungElement = xmlDocument.CreateElement("questionAbbildung");
                        questionAbbildungElement.InnerText = recordcard.QuestionAbbildung;
                        recordcardNode.AppendChild(questionAbbildungElement);

                        XmlNode answerAbbildungElement = xmlDocument.CreateElement("answerAbbildung");
                        answerAbbildungElement.InnerText = recordcard.AnswerAbbildung;
                        recordcardNode.AppendChild(answerAbbildungElement);

                        //ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].QuestionAbbildung = recordcardAbbildung.getQuestion();
                        //ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].AnswerAbbildung = recordcardAbbildung.getAnswer();
                        break;
                    case KarteikartenTyp.Aufzaehlung:
                        XmlNode questionAufzaehlungElement = xmlDocument.CreateElement("questionAufzaehlung");
                        questionAufzaehlungElement.InnerText = recordcard.QuestionAufzaehlung;
                        recordcardNode.AppendChild(questionAufzaehlungElement);


                        XmlNode answerAufzaehlungElement = xmlDocument.CreateElement("answerAufzaehlung");
                        foreach(string item in recordcard.AnswerAufzaehlung)
                        {
                            XmlNode itemAufzaehlungElement = xmlDocument.CreateElement("item");
                            itemAufzaehlungElement.InnerText = item;
                            answerAufzaehlungElement.AppendChild(itemAufzaehlungElement);
                            //recordcardNode.AppendChild(answerAbbildungAttribute);
                        }
                        recordcardNode.AppendChild(answerAufzaehlungElement);
                        break;
                    case KarteikartenTyp.MultipleChoice:
                        XmlNode questionMultipleChoiceElement = xmlDocument.CreateElement("questionMultipleChoice");
                        questionMultipleChoiceElement.InnerText = recordcard.QuestionMultipleChoice;
                        recordcardNode.AppendChild(questionMultipleChoiceElement);

                        XmlNode choicesMultipleChoiceElement = xmlDocument.CreateElement("choicesMultipleChoice");
                        foreach (string item in recordcard.ChoicesMultipleChoice)
                        {
                            XmlNode itemMultipleChoiceElement = xmlDocument.CreateElement("item");
                            itemMultipleChoiceElement.InnerText = item;
                            choicesMultipleChoiceElement.AppendChild(itemMultipleChoiceElement);
                        }
                        recordcardNode.AppendChild(choicesMultipleChoiceElement);

                        XmlNode answerMultipleChoiceElement = xmlDocument.CreateElement("answerMultipleChoice");
                        answerMultipleChoiceElement.InnerText = recordcard.AnswerMultipleChoice;
                        recordcardNode.AppendChild(answerMultipleChoiceElement);
                        break;
                }

                recordcardsetNode.AppendChild(recordcardNode);
            }

            return xmlDocument;
        }
    }
}
