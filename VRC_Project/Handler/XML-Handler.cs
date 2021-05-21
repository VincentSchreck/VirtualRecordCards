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
                XmlElement recordcardsetNode = xmlDocument.DocumentElement;
                recordcardSet.Subject = recordcardsetNode.GetAttribute("subject");

                foreach (XmlElement recordcardnode in recordcardsetNode.GetElementsByTagName("recordcard"))
                {
                    if (recordcardnode.Name == "recordcard")
                    {
                        Recordcard recordcard = new Recordcard();
                        recordcard.Topic = recordcardnode.GetAttribute("topic");
                        String type = recordcardnode.GetAttribute("type");

                        if (type == "Text")
                            {
                                recordcard.KarteikartenTyp = KarteikartenTyp.Text;

                                XmlNodeList questionNodes = recordcardsetNode.GetElementsByTagName("questionText");
                                XmlNodeList answerNodes = recordcardsetNode.GetElementsByTagName("answerText");
                                XmlElement questionNode = null, answerNode = null;

                                if (questionNodes.Count > 0)
                                {
                                    questionNode = (XmlElement)questionNodes.Item(0);
                                    recordcard.QuestionText = questionNode.InnerText;
                                }

                                if (answerNodes.Count > 0)
                                {
                                    answerNode = (XmlElement)answerNodes.Item(0);
                                    recordcard.AnswerText = answerNode.InnerText;
                                }
                            }
                            else if (type == "Abbildung")
                            {
                                recordcard.KarteikartenTyp = KarteikartenTyp.Abbildung;

                                XmlNodeList questionNodes = recordcardsetNode.GetElementsByTagName("questionAbbildung");
                                XmlNodeList answerNodes = recordcardsetNode.GetElementsByTagName("answerAbbildung");
                                XmlElement questionNode = null, answerNode = null;

                                if (questionNodes.Count > 0)
                                {
                                    questionNode = (XmlElement)questionNodes.Item(0);
                                    recordcard.QuestionAbbildung = questionNode.InnerText;
                                }

                                if (answerNodes.Count > 0)
                                {
                                    answerNode = (XmlElement)answerNodes.Item(0);
                                    recordcard.AnswerAbbildung = answerNode.InnerText;
                                }
                            }
                            else if (type == "Aufzaehlung")
                            {
                                recordcard.KarteikartenTyp = KarteikartenTyp.Aufzaehlung;

                                XmlNodeList questionNodes = recordcardsetNode.GetElementsByTagName("questionAufzaehlung");
                                XmlNodeList answerNodes = recordcardsetNode.GetElementsByTagName("answerAufzaehlung");
                                XmlElement questionNode = null, answerNode = null;

                                if (questionNodes.Count > 0)
                                {
                                    questionNode = (XmlElement)questionNodes.Item(0);
                                    recordcard.QuestionAufzaehlung = questionNode.InnerText;
                                }

                                if (answerNodes.Count > 0)
                                {
                                    List<String> items = new List<String>();
                                    answerNode = (XmlElement)answerNodes.Item(0);
                                    foreach(XmlElement answerItem in answerNode.GetElementsByTagName("item"))
                                    {
                                        items.Add(answerItem.InnerText);
                                    }

                                    recordcard.AnswerAufzaehlung = items;
                                }
                        }
                            else if (type == "MultipleChoice")
                            {
                                recordcard.KarteikartenTyp = KarteikartenTyp.MultipleChoice;

                                XmlNodeList questionNodes = recordcardsetNode.GetElementsByTagName("questionMultipleChoice");
                                XmlNodeList choicesNodes = recordcardsetNode.GetElementsByTagName("choicesMultipleChoice");
                                XmlNodeList answerNodes = recordcardsetNode.GetElementsByTagName("answerMultipleChoice");
                                XmlElement questionNode = null, answerNode = null, choiceNode = null;

                                if (questionNodes.Count > 0)
                                {
                                    questionNode = (XmlElement)questionNodes.Item(0);
                                    recordcard.QuestionMultipleChoice = questionNode.InnerText;
                                }

                                if (choicesNodes.Count > 0)
                                {
                                    List<String> items = new List<String>();
                                    choiceNode = (XmlElement)choicesNodes.Item(0);
                                    foreach (XmlElement choiceItem in choiceNode.GetElementsByTagName("item"))
                                    {
                                        items.Add(choiceItem.InnerText);
                                    }

                                    recordcard.ChoicesMultipleChoice = items;
                                }

                                if (answerNodes.Count > 0)
                                    {
                                        answerNode = (XmlElement)answerNodes.Item(0);
                                        recordcard.AnswerMultipleChoice = answerNode.InnerText;
                                    }
                                }

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
                        {
                            XmlElement questionTextElement = xmlDocument.CreateElement("questionText");
                            questionTextElement.InnerText = recordcard.QuestionText;
                            recordcardNode.AppendChild(questionTextElement);

                            XmlElement answerTextElement = xmlDocument.CreateElement("answerText");
                            answerTextElement.InnerText = recordcard.AnswerText;
                            recordcardNode.AppendChild(answerTextElement);

                            XmlAttribute typeAttribute = xmlDocument.CreateAttribute("type");
                            typeAttribute.Value = "Text";
                            recordcardNode.Attributes.Append(typeAttribute);
                        }
                        break;
                    case KarteikartenTyp.Abbildung:
                        {
                            XmlElement questionAbbildungElement = xmlDocument.CreateElement("questionAbbildung");
                            questionAbbildungElement.InnerText = recordcard.QuestionAbbildung;
                            recordcardNode.AppendChild(questionAbbildungElement);

                            XmlElement answerAbbildungElement = xmlDocument.CreateElement("answerAbbildung");
                            answerAbbildungElement.InnerText = recordcard.AnswerAbbildung;
                            recordcardNode.AppendChild(answerAbbildungElement);

                            XmlAttribute typeAttribute = xmlDocument.CreateAttribute("type");
                            typeAttribute.Value = "Abbildung";
                            recordcardNode.Attributes.Append(typeAttribute);
                        }
                        //ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].QuestionAbbildung = recordcardAbbildung.getQuestion();
                        //ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].AnswerAbbildung = recordcardAbbildung.getAnswer();
                        break;
                    case KarteikartenTyp.Aufzaehlung:
                        {
                            XmlElement questionAufzaehlungElement = xmlDocument.CreateElement("questionAufzaehlung");
                            questionAufzaehlungElement.InnerText = recordcard.QuestionAufzaehlung;
                            recordcardNode.AppendChild(questionAufzaehlungElement);


                            XmlElement answerAufzaehlungElement = xmlDocument.CreateElement("answerAufzaehlung");
                            foreach (string item in recordcard.AnswerAufzaehlung)
                            {
                                XmlNode itemAufzaehlungElement = xmlDocument.CreateElement("item");
                                itemAufzaehlungElement.InnerText = item;
                                answerAufzaehlungElement.AppendChild(itemAufzaehlungElement);
                                //recordcardNode.AppendChild(answerAbbildungAttribute);
                            }
                            recordcardNode.AppendChild(answerAufzaehlungElement);

                            XmlAttribute typeAttribute = xmlDocument.CreateAttribute("type");
                            typeAttribute.Value = "Aufzaehlung";
                            recordcardNode.Attributes.Append(typeAttribute);
                        }
                        break;
                    case KarteikartenTyp.MultipleChoice:
                        {
                            XmlElement questionMultipleChoiceElement = xmlDocument.CreateElement("questionMultipleChoice");
                            questionMultipleChoiceElement.InnerText = recordcard.QuestionMultipleChoice;
                            recordcardNode.AppendChild(questionMultipleChoiceElement);

                            XmlElement choicesMultipleChoiceElement = xmlDocument.CreateElement("choicesMultipleChoice");
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

                            XmlAttribute typeAttribute = xmlDocument.CreateAttribute("type");
                            typeAttribute.Value = "MultipleChoice";
                            recordcardNode.Attributes.Append(typeAttribute);
                        }
                        break;
                }

                recordcardsetNode.AppendChild(recordcardNode);
            }

            return xmlDocument;
        }
    }
}
