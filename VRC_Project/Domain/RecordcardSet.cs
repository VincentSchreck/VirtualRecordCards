using System;
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

        public void EntferneRecordCardListe(Recordcard recordcard)
        {
            _recordcardList.Remove(recordcard);
        }

        public void EntferneRecordCardListeUeberIndex(int index)
        {
            _recordcardList.RemoveAt(index);
        }

        public void SetzeRecordCardListe()
        {

        }

        private static Random rng = new Random();

        //Fisher-Yates shuffle:
        public List<Recordcard> wendeZufallsreihenfolgeAufListeAn()
        {
            List<Recordcard> temp = _recordcardList;
            int n = temp.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Recordcard value = temp[k];
                temp[k] = temp[n];
                temp[n] = value;
            }
            return temp;
        }
    }
}
