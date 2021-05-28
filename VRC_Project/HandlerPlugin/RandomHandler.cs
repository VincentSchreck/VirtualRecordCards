using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRC.Application;
using VRC.Domain;

namespace VRC.HandlerPlugin
{
    public class FisherYateShuffle : RecordCardListRandomizer
    {
        public List<Recordcard> randomize(List<Recordcard> recordcardList)
        {
            List<Recordcard> temp = recordcardList;

            int n = temp.Count;
            while (n > 1)
            {
                n--;
                int k = new System.Random().Next(n + 1);
                Recordcard value = temp[k];
                temp[k] = temp[n];
                temp[n] = value;
            }
            return temp;
        }
    }
}
