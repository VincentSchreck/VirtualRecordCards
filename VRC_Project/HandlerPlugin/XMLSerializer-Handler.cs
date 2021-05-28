using VRC.Application;
using System.Xml.Serialization;
using VRC.Domain;
using System.IO;

namespace VRC.HandlerPlugin
{
    public class XMLSerializer_Handler : FileFormatHandler
    {
        public RecordcardSet Deserialize(string content)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(RecordcardSet));

         
            using (StringReader textReader = new StringReader(content))
            { 
                
                return (RecordcardSet) xmlSerializer.Deserialize(textReader);
            }
        }

        public string Serialize(RecordcardSet recordcardSet)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(recordcardSet.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, recordcardSet);
                return textWriter.ToString();
            }
        }
    }
}
