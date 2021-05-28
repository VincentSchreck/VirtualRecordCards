namespace VRC.Application
{
    public class PruefEinstellungen
    {
        private string _speicherort = "";
        private bool alleKarteikarten;
        private bool wiederholungenErlauben;
        private bool nurFalschBeantwortete;
        private bool zufallsreihenfolge;
        private uint anzahlWiederholungen;
        private uint anzahlGenerellKarteikarten;

        public string Speicherort { get => _speicherort; set => _speicherort = value; }
        public bool AlleKarteikarten { get => alleKarteikarten; set => alleKarteikarten = value; }
        public bool WiederholungenErlauben { get => wiederholungenErlauben; set => wiederholungenErlauben = value; }
        public bool NurFalschBeantwortete { get => nurFalschBeantwortete; set => nurFalschBeantwortete = value; }
        public bool Zufallsreihenfolge { get => zufallsreihenfolge; set => zufallsreihenfolge = value; }
        public uint AnzahlWiederholungen { get => anzahlWiederholungen; set => anzahlWiederholungen = value; }
        public uint AnzahlGenerellKarteikarten { get => anzahlGenerellKarteikarten; set => anzahlGenerellKarteikarten = value; }

        public bool PruefePfad()
        {
            if (string.IsNullOrWhiteSpace(Speicherort))
                return false;

            return true;
        }

    }
}
