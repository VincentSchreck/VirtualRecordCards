using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VRC.Handler
{
    public static class FileHandler
    {
        public static string read(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception(); //TODO Create Own Exception
            }
            return File.ReadAllText(path);
        }

        public static void write(string XMLText, string path)
        {
            File.WriteAllText(path, XMLText);
        }
    }
}