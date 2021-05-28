namespace VRC.Application
{
    public class KarteikartenBearbeitenEinstellung
    {
        private string _speicherort = "";

        public string Speicherort { get => _speicherort; set => _speicherort = value; }

        public bool PruefePfad()
        {
            if (string.IsNullOrWhiteSpace(Speicherort))
                return false;

            return true;
        }
    }
}
