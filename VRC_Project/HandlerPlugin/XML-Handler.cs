using System;
using System.Xml;
using VRC.Application;
using VRC.Domain;

namespace VRC.HandlerPlugin
{
    public class XMLHandler : FileFormatHandler
    {
        public RecordcardSet Deserialize(string content)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(content);

            return DeserializeFromXML(xmlDocument);
        }

        private RecordcardSet DeserializeFromXML(XmlDocument xmlDocument)
        {
            RecordcardSet recordcardSet = new RecordcardSet();

            if (xmlDocument.HasChildNodes && xmlDocument.FirstChild.Name == "recordcardset")
            {
                XmlElement recordcardsetNode = xmlDocument.DocumentElement;
                recordcardSet.Fachbezeichnung = recordcardsetNode.GetAttribute("subject");

                foreach (XmlElement recordcardnode in recordcardsetNode.GetElementsByTagName("recordcard"))
                {
                    if (recordcardnode.Name == "recordcard")
                    {
                        Recordcard recordcard = new Recordcard();
                        recordcard.Thema = recordcardnode.GetAttribute("topic");
                        String type = recordcardnode.GetAttribute("type");

                        if (type == "Text")
                        {
                            RecordCardTextContent recordCardContentText = new RecordCardTextContent();

                            XmlNodeList questionNodes = recordcardnode.GetElementsByTagName("questionText");
                            XmlNodeList answerNodes = recordcardnode.GetElementsByTagName("answerText");
                            XmlElement questionNode = null, answerNode = null;

                            if (questionNodes.Count > 0)
                            {
                                questionNode = (XmlElement)questionNodes.Item(0);
                                recordCardContentText.QuestionText = questionNode.InnerText;
                            }

                            if (answerNodes.Count > 0)
                            {
                                answerNode = (XmlElement)answerNodes.Item(0);
                                recordCardContentText.AnswerText = answerNode.InnerText;
                            }

                            recordcard.content = recordCardContentText;
                        }
                        else if (type == "Abbildung")
                        {
                            RecordCardAbbildungContent content = new RecordCardAbbildungContent();

                            XmlNodeList questionNodes = recordcardnode.GetElementsByTagName("questionAbbildung");
                            XmlNodeList answerNodes = recordcardnode.GetElementsByTagName("answerAbbildung");
                            XmlElement questionNode = null, answerNode = null;

                            if (questionNodes.Count > 0)
                            {
                                questionNode = (XmlElement)questionNodes.Item(0);
                                content.QuestionAbbildung = questionNode.InnerText;
                            }

                            if (answerNodes.Count > 0)
                            {
                                answerNode = (XmlElement)answerNodes.Item(0);
                                content.ImagePath = answerNode.InnerText;
                            }

                            recordcard.content = content;
                        }
                        else if (type == "Aufzaehlung")
                        {
                           RecordCardAufzaehlungContent content = new RecordCardAufzaehlungContent();


                            XmlNodeList questionNodes = recordcardnode.GetElementsByTagName("questionAufzaehlung");
                            XmlNodeList answerNodes = recordcardnode.GetElementsByTagName("answerAufzaehlung");
                            XmlElement questionNode = null, answerNode = null;

                            if (questionNodes.Count > 0)
                            {
                                questionNode = (XmlElement)questionNodes.Item(0);
                                content.QuestionAufzaehlung = questionNode.InnerText;
                            }

                            if (answerNodes.Count > 0)
                            {
                                answerNode = (XmlElement)answerNodes.Item(0);
                                foreach (XmlElement answerItem in answerNode.GetElementsByTagName("item"))
                                {
                                    content.addAnswerValue(answerItem.InnerText);
                                }
                            }

                            recordcard.content = content;
                        }
                        else if (type == "MultipleChoice")
                        {
                          RecordCardMultipleChoiceContent content = new RecordCardMultipleChoiceContent();

                            XmlNodeList questionNodes = recordcardnode.GetElementsByTagName("questionMultipleChoice");
                            XmlNodeList choicesNodes = recordcardnode.GetElementsByTagName("choicesMultipleChoice");
                            XmlNodeList answerNodes = recordcardnode.GetElementsByTagName("answerMultipleChoice");
                            XmlElement questionNode = null, answerNode = null, choiceNode = null;

                            if (questionNodes.Count > 0)
                            {
                                questionNode = (XmlElement)questionNodes.Item(0);
                                content.QuestionMultipleChoice = questionNode.InnerText;
                            }

                            if (choicesNodes.Count > 0)
                            {
                                choiceNode = (XmlElement)choicesNodes.Item(0);
                                foreach (XmlElement choiceItem in choiceNode.GetElementsByTagName("item"))
                                {
                                    content.addMultipleChoiceValue(choiceItem.InnerText);
                                }
                            }

                            if (answerNodes.Count > 0)
                            {
                                answerNode = (XmlElement)answerNodes.Item(0);
                                content.AnswerMultipleChoice = answerNode.InnerText;
                            }
                            recordcard.content = content;
                        }

                        recordcardSet.RecordcardList.Add(recordcard);
                    }
                }
            }

            return recordcardSet;
        }

        public string Serialize(RecordcardSet recordcardSet)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode recordcardsetNode = xmlDocument.CreateElement("recordcardset");
            XmlAttribute subjectAttribute = xmlDocument.CreateAttribute("subject");
            subjectAttribute.Value = recordcardSet.Fachbezeichnung;
            recordcardsetNode.Attributes.Append(subjectAttribute);
            xmlDocument.AppendChild(recordcardsetNode);

            foreach (Recordcard recordcard in recordcardSet.RecordcardList)
            {
                XmlNode recordcardNode = xmlDocument.CreateElement("recordcard");

                XmlAttribute topicAttribute = xmlDocument.CreateAttribute("topic");
                topicAttribute.Value = recordcard.Thema;
                recordcardNode.Attributes.Append(topicAttribute);

                if (recordcard.content.GetType() == typeof(RecordCardTextContent))
                {
                    XmlElement questionTextElement = xmlDocument.CreateElement("questionText");
                    questionTextElement.InnerText = ((RecordCardTextContent)recordcard.content).QuestionText;
                    recordcardNode.AppendChild(questionTextElement);

                    XmlElement answerTextElement = xmlDocument.CreateElement("answerText");
                    answerTextElement.InnerText = ((RecordCardTextContent)recordcard.content).AnswerText;
                    recordcardNode.AppendChild(answerTextElement);

                    XmlAttribute typeAttribute = xmlDocument.CreateAttribute("type");
                    typeAttribute.Value = "Text";
                    recordcardNode.Attributes.Append(typeAttribute);
                }

                else if (recordcard.content.GetType() == typeof(RecordCardAbbildungContent))
                {
                    XmlElement questionAbbildungElement = xmlDocument.CreateElement("questionAbbildung");
                    questionAbbildungElement.InnerText = ((RecordCardAbbildungContent)recordcard.content).QuestionAbbildung;
                    recordcardNode.AppendChild(questionAbbildungElement);

                    XmlElement answerAbbildungElement = xmlDocument.CreateElement("answerAbbildung");
                    answerAbbildungElement.InnerText = ((RecordCardAbbildungContent)recordcard.content).ImagePath;
                    recordcardNode.AppendChild(answerAbbildungElement);

                    XmlAttribute typeAttribute = xmlDocument.CreateAttribute("type");
                    typeAttribute.Value = "Abbildung";
                    recordcardNode.Attributes.Append(typeAttribute);
                }

                else if (recordcard.content.GetType() == typeof(RecordCardAufzaehlungContent))
                {
                    XmlElement questionAufzaehlungElement = xmlDocument.CreateElement("questionAufzaehlung");
                    questionAufzaehlungElement.InnerText = ((RecordCardAufzaehlungContent)recordcard.content).QuestionAufzaehlung;
                    recordcardNode.AppendChild(questionAufzaehlungElement);


                    XmlElement answerAufzaehlungElement = xmlDocument.CreateElement("answerAufzaehlung");
                    foreach (string item in ((RecordCardAufzaehlungContent)recordcard.content).getAnswerAufzaehlung())
                    {
                        XmlNode itemAufzaehlungElement = xmlDocument.CreateElement("item");
                        itemAufzaehlungElement.InnerText = item;
                        answerAufzaehlungElement.AppendChild(itemAufzaehlungElement);
                    }
                    recordcardNode.AppendChild(answerAufzaehlungElement);

                    XmlAttribute typeAttribute = xmlDocument.CreateAttribute("type");
                    typeAttribute.Value = "Aufzaehlung";
                    recordcardNode.Attributes.Append(typeAttribute);
                }

                else if (recordcard.content.GetType() == typeof(RecordCardMultipleChoiceContent))
                {
                    XmlElement questionMultipleChoiceElement = xmlDocument.CreateElement("questionMultipleChoice");
                    questionMultipleChoiceElement.InnerText = ((RecordCardMultipleChoiceContent)recordcard.content).QuestionMultipleChoice;
                    recordcardNode.AppendChild(questionMultipleChoiceElement);

                    XmlElement choicesMultipleChoiceElement = xmlDocument.CreateElement("choicesMultipleChoice");
                    foreach (string item in ((RecordCardMultipleChoiceContent)recordcard.content).ChoicesMultipleChoice)
                    {
                        XmlNode itemMultipleChoiceElement = xmlDocument.CreateElement("item");
                        itemMultipleChoiceElement.InnerText = item;
                        choicesMultipleChoiceElement.AppendChild(itemMultipleChoiceElement);
                    }
                    recordcardNode.AppendChild(choicesMultipleChoiceElement);

                    XmlNode answerMultipleChoiceElement = xmlDocument.CreateElement("answerMultipleChoice");
                    answerMultipleChoiceElement.InnerText = ((RecordCardMultipleChoiceContent)recordcard.content).AnswerMultipleChoice;
                    recordcardNode.AppendChild(answerMultipleChoiceElement);

                    XmlAttribute typeAttribute = xmlDocument.CreateAttribute("type");
                    typeAttribute.Value = "MultipleChoice";
                    recordcardNode.Attributes.Append(typeAttribute);

                }

                recordcardsetNode.AppendChild(recordcardNode);
            }

            return xmlDocument.InnerXml;
        }
    }
}
