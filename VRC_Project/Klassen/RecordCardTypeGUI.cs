using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRC.Model;

namespace VRC.Klassen
{
    public abstract class RecordCardTypeGUI : UserControl
    {
        public RecordCardTypeGUI()
        {
            
        }

        public abstract RecordcardContent EntnehmeContent();
    }
}
