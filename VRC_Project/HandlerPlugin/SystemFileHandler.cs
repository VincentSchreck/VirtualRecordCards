using System;
using System.IO;
using VRC.Application;

namespace VRC.Handler
{
    public class SystemFileHandler : FileHandler
    {
        public override string Lade(string Pfad)
        {
            if (!File.Exists(Pfad))
            {
                throw new Exception(); //TODO Create Own Exception
            }
            return File.ReadAllText(Pfad);
        }

        public override void Schreibe(string Inhalt, string Pfad)
        {
            File.WriteAllText(Pfad, Inhalt);
        }
    }
}