using VRC.Domain;

namespace VRC.Application
{
    public static class LoadSaveRecordCard
    {
        public static void SpeichereKarteikartenSammlung(FileHandler fileHandler, FileFormatHandler fileFormatHandler, RecordcardSet recordCardSet,string path)
        {
            fileHandler.Schreibe(fileFormatHandler.Serialize(recordCardSet), path);
        }

        public static RecordcardSet LeseKarteikartenSammlungAus(FileFormatHandler fileFormatHandler, FileHandler fileHandler, string path)
        {
            return fileFormatHandler.Deserialize(fileHandler.Lade(path));
        }
    }
}
