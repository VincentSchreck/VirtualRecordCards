using System.Collections.Generic;
using VRC.Domain;

namespace VRC.Application
{
    public interface FileHandler
    {
        string Lade(string Pfad);

        void Schreibe(string content, string Pfad);
    }

    public interface FileFormatHandler
    {
        string Serialize(RecordcardSet recordcardSet);

        RecordcardSet Deserialize(string content);
    }

    public class KarteikartenEditor
    {
        private RecordcardSet recordcardSammlung = new RecordcardSet();
        private int aktuellerKarteikartenIndex = -1;

        public RecordcardSet RecordCardSammlung { get => recordcardSammlung; set => recordcardSammlung = value; }
        public int AktuellerKarteikartenIndex { get => aktuellerKarteikartenIndex; private set => aktuellerKarteikartenIndex = value; }

        public Recordcard AktuelleKarteikarte {
            get{ 
                if (aktuellerKarteikartenIndex < ListCount)
                    return recordcardSammlung.RecordcardList[aktuellerKarteikartenIndex]; else return null;
        } }

        public int ListCount { get => recordcardSammlung.RecordcardList.Count; }

        public KarteikartenEditor()
        {
          
        }

        public void SetzeFachbezeichnung(string Fach)
        {
            recordcardSammlung.Fachbezeichnung = Fach;
        }
        
        public string ErhalteFachbezeichnung()
        {
            return recordcardSammlung.Fachbezeichnung;
        }

        public List<Recordcard> ErhalteKarteikartenSammlung()
        {
            return recordcardSammlung.RecordcardList;
        }

        public int NeueKarteikarte(string thema, RecordCardContent content)
        {
            Recordcard recordcard = new Recordcard();
            recordcard.Thema = thema;
            recordcard.content = content;
            recordcardSammlung.RecordcardList.Add(recordcard); 
            return ListCount - 1;
        }

        public void KarteikartenIndexReset()
        {
            aktuellerKarteikartenIndex = ListCount - 1;
        }

        public void SetzeKarteikartenIndex(int value)
        {
            aktuellerKarteikartenIndex = value;
        }

        public void FuegeKarteikartehinzu(Recordcard recordcard)
        {
            recordcardSammlung.FuegeRecordCardListeHinzu(recordcard);
        }

        public void SpeichereAktuelleKarteikarteAb(string thema, RecordCardContent content)
        {
            if (0 <= aktuellerKarteikartenIndex && aktuellerKarteikartenIndex < ListCount)
            {
                recordcardSammlung.RecordcardList[aktuellerKarteikartenIndex].Thema = thema;
                recordcardSammlung.RecordcardList[aktuellerKarteikartenIndex].content = content;
            }
        }

        public void SpeichereKarteikarteAb(int index, string thema, RecordCardContent content)
        {
            if (index < ListCount)
            {
                recordcardSammlung.RecordcardList[index].Thema = thema;
                recordcardSammlung.RecordcardList[index].content = content;
            }
        }

        public void LoescheKarteikarte(Recordcard recordcard)
        {
            recordcardSammlung.EntferneRecordCardListe(recordcard);
            aktuellerKarteikartenIndex = -1;

        }

        public void LoescheKarteikarteIndex(int index)
        {
            recordcardSammlung.EntferneRecordCardListeUeberIndex(index);
            aktuellerKarteikartenIndex = -1;
        }
    }
}
