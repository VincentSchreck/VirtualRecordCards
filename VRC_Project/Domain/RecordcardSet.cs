using System.Collections.Generic;

namespace VRC.Domain
{
    public class RecordcardSet
    {

        private List<Recordcard> _recordcardList;
        public List<Recordcard> RecordcardList { get => _recordcardList; private set => _recordcardList = value; }

        public RecordcardSet()
        {
            _recordcardList = new List<Recordcard>();
        }

        public string Fachbezeichnung = "";

        public void FuegeRecordCardListeHinzu(Recordcard recordcard)
        {
            _recordcardList.Add(recordcard);
        }

        public void EntferneRecordCardAusListe(Recordcard recordcard)
        {
            _recordcardList.Remove(recordcard);
        }

    }
}
