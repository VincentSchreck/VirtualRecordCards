using System;
using System.IO;
using VRC.Application;

namespace VRC.HandlerPlugin
{
    public class SystemFileHandler : FileHandler
    {
        public string Lade(string Pfad)
        {
            if (!File.Exists(Pfad))
            {
                throw new Exception();
            }
            return File.ReadAllText(Pfad);
        }

        public void Schreibe(string Inhalt, string Pfad)
        {
            File.WriteAllText(Pfad, Inhalt);
        }
    }
}