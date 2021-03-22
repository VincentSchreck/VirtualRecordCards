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

    }
}
