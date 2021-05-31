using System.Collections.Generic;
using VRC.Domain;

namespace VRC.Application
{
    public class Pruefmodus
    {
        public Pruefmodus()
        {

        }
        #region Eigenschaften
        private uint MaximalRunden = 1, aktuelleRunde = 1;
        private List<Recordcard> falschBeantworteteRecordcards = new List<Recordcard>(),
            aktuelleRecordcards = new List<Recordcard>();
        uint generellAnzahlKarten;
        bool nurfalschewiederholen, zufall;
        int richtigeCount;
        private RecordcardSet originalRecordcardSet, recordcardSammlung = new RecordcardSet();
        private int aktuellerKarteikartenIndex = 0;
        #endregion

<<<<<<< Updated upstream

        public void BehandelFalschBeantworteteFallsEingestellt()
        {
            if (nurfalschewiederholen)
            {
                aktuelleRecordcards = falschBeantworteteRecordcards;
            }
        }

        public void StarteNeueRunde()
        {
            aktuellerKarteikartenIndex = 0;
            aktuelleRunde++;
            falschBeantworteteRecordcards = new List<Recordcard>();
        }

=======
>>>>>>> Stashed changes
        public bool PruefeAbfrageEnde()
        {
            return aktuelleRunde >= MaximalRunden;
        }

        public bool PruefeFalschBehandelteModus()
        {
            return (nurfalschewiederholen && falschBeantworteteRecordcards.Count == 0);
        }


        public bool PruefeRundenEnde()
        {
            return (aktuellerKarteikartenIndex) >= aktuelleRecordcards.Count;
        }

        public int ErhalteAnzahlRichtiger()
        {
            return richtigeCount;
        }

        public RecordcardSet RecordCardSammlung
        {
            get => recordcardSammlung; private set => recordcardSammlung = value;
        }

        public int AktuellerKarteikartenIndex { get => aktuellerKarteikartenIndex; private set => aktuellerKarteikartenIndex = value; }

        public int ListCount { get => aktuelleRecordcards.Count; }

        public Recordcard AktuelleKarteikarte
        {
            get
            {
                if (aktuellerKarteikartenIndex < ListCount)
                    return aktuelleRecordcards[aktuellerKarteikartenIndex];
                else return null;
            }
        }
        public Pruefmodus(RecordCardListRandomizer randomizer, RecordcardSet recordcardSet)
        {
            this.randomizer = randomizer;
            originalRecordcardSet = recordcardSet;
        }

        public void BehandelFalschBeantworteteFallsEingestellt()
        {
            if (nurfalschewiederholen)
            {
                aktuelleRecordcards = falschBeantworteteRecordcards;
            }
        }

<<<<<<< Updated upstream
        public void Uebernehme(FileFormatHandler fileFormatHandler, FileHandler fileHandler, PruefEinstellungen uebergebenePruefEinstellungData)
=======
        public void StarteNeueRunde()
        {
            aktuellerKarteikartenIndex = 0;
            aktuelleRunde++;
            falschBeantworteteRecordcards = new List<Recordcard>();
        }
        
        public void Uebernehme(PruefEinstellungen uebergebenePruefEinstellungData)
>>>>>>> Stashed changes
        {
            LeseKarteikartenSammlungAus(fileFormatHandler, fileHandler, uebergebenePruefEinstellungData);
            UebernehmeEinfacheEinstellungenAus(uebergebenePruefEinstellungData);
            ÜbernehmeSammlungSamtZufallsEinstellungenAus(uebergebenePruefEinstellungData);
            BegrenzeKartenUeber(uebergebenePruefEinstellungData);
        }

        internal void nächsteKarteikarte(bool letzteWarRichtig)
        {
            if (letzteWarRichtig)
            {
                richtigeCount++;
            }
            else
            {
                FuegeAktuellteKarteZuFalschenHinzu();
            }
            aktuellerKarteikartenIndex++;
        }

        private void FuegeAktuellteKarteZuFalschenHinzu()
        {
            if (!falschBeantworteteRecordcards.Contains(aktuelleRecordcards[aktuellerKarteikartenIndex]))
                falschBeantworteteRecordcards.Add(aktuelleRecordcards[aktuellerKarteikartenIndex]);
        }

        #region Einstellungen
  
        private void LeseKarteikartenSammlungAus(FileFormatHandler fileFormatHandler, FileHandler fileHandler, PruefEinstellungen uebergebenePruefEinstellungData)
        {
            originalRecordcardSet = fileFormatHandler.Deserialize(fileHandler.Lade(uebergebenePruefEinstellungData.Speicherort));
        }

        private void UebernehmeEinfacheEinstellungenAus(PruefEinstellungen uebergebenePruefEinstellungData)
        {
            if (uebergebenePruefEinstellungData.WiederholungenErlauben)
                MaximalRunden = uebergebenePruefEinstellungData.AnzahlWiederholungen;

            nurfalschewiederholen = uebergebenePruefEinstellungData.NurFalschBeantwortete;
            generellAnzahlKarten = uebergebenePruefEinstellungData.AnzahlGenerellKarteikarten;
        }

        private void BegrenzeKartenUeber(PruefEinstellungen uebergebenePruefEinstellungData)
        {
            if (!uebergebenePruefEinstellungData.AlleKarteikarten)
            {
                uint anzahl = generellAnzahlKarten;
                if (anzahl > originalRecordcardSet.RecordcardList.Count)
                    anzahl = (uint)originalRecordcardSet.RecordcardList.Count;

                aktuelleRecordcards = aktuelleRecordcards.GetRange(0, (int)anzahl);
            }
        }

        private void ÜbernehmeSammlungSamtZufallsEinstellungenAus(PruefEinstellungen uebergebenePruefEinstellungData)
        {
            zufall = uebergebenePruefEinstellungData.Zufallsreihenfolge;
            aktuelleRecordcards = zufall ? originalRecordcardSet.wendeZufallsreihenfolgeAufListeAn()
                                         : aktuelleRecordcards = originalRecordcardSet.RecordcardList;
        }
        #endregion 
    }
}
