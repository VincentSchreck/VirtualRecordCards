using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRC.Model
{
    public class PruefEinstellungData
    {
        public bool alleKarteikarten;
        public bool wiederholungenErlauben;
        public bool nurFalschBeantwortete;
        public bool zufallsreihenfolge;
        public uint anzahlWiederholungen;
        public uint anzahlGenerellKarteikarten;
        public string speicherortKarteikartenset;
    }
}
