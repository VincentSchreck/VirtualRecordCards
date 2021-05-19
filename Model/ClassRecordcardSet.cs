using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRC.Model
{
    public class RecordcardSet
    {
        public List<Recordcard> RecordcardList;

        public RecordcardSet()
        {
            RecordcardList = new List<Recordcard>();
        }

        public string Subject = "";


        private static Random rng = new Random();
        //Fisher-Yates shuffle:
        public void wendeZufallsreihenfolgeAn()
        {
            int n = RecordcardList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Recordcard value = RecordcardList[k];
                RecordcardList[k] = RecordcardList[n];
                RecordcardList[n] = value;
            }
        }
    }
}
