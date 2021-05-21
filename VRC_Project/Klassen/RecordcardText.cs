using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRC.Klassen
{
    public partial class RecordcardText : UserControl
    {
        public RecordcardText()
        {
            InitializeComponent();
        }
        public RecordcardText(string frage, string antwort)
        {
            InitializeComponent();
            txtBoxTextFrage.Text = frage;
            txtBoxTextAntwort.Text = antwort;
        }

        public string getQuestion()
        {
            return txtBoxTextFrage.Text;
        }

        public string getAnswer()
        {
            return txtBoxTextAntwort.Text;
        }
    }
}
