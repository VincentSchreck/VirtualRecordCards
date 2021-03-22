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
                        recordcard.Question = recordcardsetNode.GetAttribute("question");
                        recordcard.Answer = recordcardsetNode.GetAttribute("answer");
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

            foreach (Recordcard recordcard in recordcardSet.RecordcardList)
            {
                XmlNode recordcardNode = xmlDocument.CreateElement("recordcard");

                XmlAttribute topicAttribute = xmlDocument.CreateAttribute("topic");
                topicAttribute.Value = recordcard.Topic;
                recordcardNode.Attributes.Append(topicAttribute);

                XmlAttribute questionAttribute = xmlDocument.CreateAttribute("question");
                questionAttribute.Value = recordcard.Question;
                recordcardNode.Attributes.Append(questionAttribute);

                XmlAttribute answerAttribute = xmlDocument.CreateAttribute("answer");
                answerAttribute.Value = recordcard.Answer;
                recordcardNode.Attributes.Append(answerAttribute);

                recordcardsetNode.AppendChild(recordcardNode);
            }

            return xmlDocument;
        }
    }
}
