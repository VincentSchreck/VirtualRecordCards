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
using VRC.Handler;
using System.IO;

namespace VRC.Klassen
{
    public partial class KarteikartenBearbeiten : Form
    {

        private RecordcardSet ObjRecordcardSet;

        private int aktuellerKarteikartenIndex = -1;

        private RecordcardText recordcardText;
        private RecordcardAufzaehlung recordcardAufzaehlung;
        private RecordcardMultipleChoice recordcardMultipleChoice;
        private RecordcardAbbildung recordcardAbbildung;
        private String FilePath;// = @"Test\Test.xml"; //TODO FILEDIALOG..

        public KarteikartenBearbeiten(string speicherort)
        {
            InitializeComponent();

            //GET Test.xml
            //String currentpath = System.IO.Directory.GetCurrentDirectory();
            //var directory = new DirectoryInfo(currentpath ?? Directory.GetCurrentDirectory());
            //while (directory != null && !directory.GetFiles("*.sln").Any())
            //{
            //    directory = directory.Parent;
            //}
            //FilePath = Path.Combine(directory.FullName, @"Test\Test.xml");

            FilePath = speicherort;

            ObjRecordcardSet = XMLHandler.DeserializeFromXML(FileHandler.Read(FilePath));
            txtBxFach.Text = ObjRecordcardSet.Subject;
            listBxKarteikarten.Items.Clear();
            foreach (Recordcard card in ObjRecordcardSet.RecordcardList)
            {
                listBxKarteikarten.Items.Add(card.getListboxName());
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBxKarteikarten.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
            listBxKarteikarten.BeginUpdate();
            if (listBxKarteikarten.SelectedIndex >= 0)
            {
                if(aktuellerKarteikartenIndex  != -1)
                {
                    Recordcard aktuelleRecordcard = ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex];
                    aktuelleRecordcard.Topic = txtBxThema.Text;

                    switch (aktuelleRecordcard.KarteikartenTyp)
                    {
                        case KarteikartenTyp.Text:
                            aktuelleRecordcard.QuestionText = recordcardText.getQuestion();
                            aktuelleRecordcard.AnswerText = recordcardText.getAnswer();
                            break;
                        case KarteikartenTyp.Aufzaehlung:
                            aktuelleRecordcard.QuestionAufzaehlung = recordcardAufzaehlung.getQuestion();
                            aktuelleRecordcard.AnswerAufzaehlung = recordcardAufzaehlung.getAnswer();
                            break;
                        case KarteikartenTyp.MultipleChoice:
                            aktuelleRecordcard.QuestionMultipleChoice = recordcardMultipleChoice.getQuestion();
                            aktuelleRecordcard.ChoicesMultipleChoice = recordcardMultipleChoice.getMultipleChoices();
                            aktuelleRecordcard.AnswerMultipleChoice = recordcardMultipleChoice.getAnswer();
                            break;
                        case KarteikartenTyp.Abbildung:
                            aktuelleRecordcard.QuestionAbbildung = recordcardAbbildung.getQuestion();
                            aktuelleRecordcard.AnswerAbbildung = recordcardAbbildung.getAnswer();
                            break;
                    }
                    Refresh();

                    listBxKarteikarten.Items[aktuellerKarteikartenIndex] = aktuelleRecordcard.getListboxName();

                }

                Recordcard recordcard = ObjRecordcardSet.RecordcardList[listBxKarteikarten.SelectedIndex];
                txtBxThema.Text = recordcard.Topic;

                tabControl1.Controls.Clear();
                // Typ der Karteikarte, auf die gewechselt wird
                switch (recordcard.KarteikartenTyp)
                {
                    case KarteikartenTyp.Text:
                        recordcardText = new RecordcardText(recordcard.QuestionText, recordcard.AnswerText);
                        this.tabControl1.Controls.Add(recordcardText);
                        break;
                    case KarteikartenTyp.Aufzaehlung:
                        recordcardAufzaehlung = new RecordcardAufzaehlung(recordcard.QuestionAufzaehlung, recordcard.AnswerAufzaehlung);
                        this.tabControl1.Controls.Add(recordcardAufzaehlung);
                        break;
                    case KarteikartenTyp.MultipleChoice:
                        recordcardMultipleChoice = new RecordcardMultipleChoice(recordcard.QuestionMultipleChoice, recordcard.ChoicesMultipleChoice, recordcard.AnswerMultipleChoice);
                        this.tabControl1.Controls.Add(recordcardMultipleChoice);
                        break;
                    case KarteikartenTyp.Abbildung:
                        recordcardAbbildung = new RecordcardAbbildung(recordcard.QuestionAbbildung, recordcard.AnswerAbbildung);
                        this.tabControl1.Controls.Add(recordcardAbbildung);
                        break;
                }
                Refresh();

                aktuellerKarteikartenIndex = listBxKarteikarten.SelectedIndex;
            }
            listBxKarteikarten.EndUpdate();
            listBxKarteikarten.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void btnNeueKarteikarte_Click(object sender, EventArgs e)
        {
            if(comBoxKarteikartentyp.SelectedIndex != -1)
            {

                // Neue Karteikarte erstellen und die, die gerade bearbeitet wird speichern
                if (aktuellerKarteikartenIndex != -1)
                {
                    switch (ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].KarteikartenTyp)
                    {
                        case KarteikartenTyp.Text:
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].QuestionText = recordcardText.getQuestion();
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].AnswerText = recordcardText.getAnswer();
                            break;
                        case KarteikartenTyp.Abbildung:
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].QuestionAbbildung = recordcardAbbildung.getQuestion();
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].AnswerAbbildung = recordcardAbbildung.getAnswer();
                            break;
                        case KarteikartenTyp.Aufzaehlung:
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].QuestionAufzaehlung = recordcardAufzaehlung.getQuestion();
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].AnswerAufzaehlung = recordcardAufzaehlung.getAnswer();
                            break;
                        case KarteikartenTyp.MultipleChoice:
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].QuestionMultipleChoice = recordcardMultipleChoice.getQuestion();
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].ChoicesMultipleChoice = recordcardMultipleChoice.getMultipleChoices();
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].AnswerMultipleChoice = recordcardMultipleChoice.getAnswer();
                            break;
                    }
                }

                // Art der Karteikarte auslesen und neue Karteikarte erstellen
                tabControl1.Controls.Clear();

                Recordcard recordcard = new Recordcard();
                recordcard.Topic = txtBxThema.Text;

                switch (comBoxKarteikartentyp.SelectedIndex)
                {
                    case 0:
                        recordcardText = new RecordcardText();
                        this.tabControl1.Controls.Add(recordcardText);
                        recordcard.KarteikartenTyp = KarteikartenTyp.Text;
                        break;
                    case 1:
                        recordcardAufzaehlung = new RecordcardAufzaehlung();
                        this.tabControl1.Controls.Add(recordcardAufzaehlung);
                        recordcard.KarteikartenTyp = KarteikartenTyp.Aufzaehlung;
                        break;
                    case 2:
                        recordcardMultipleChoice = new RecordcardMultipleChoice();
                        this.tabControl1.Controls.Add(recordcardMultipleChoice);
                        recordcard.KarteikartenTyp = KarteikartenTyp.MultipleChoice;
                        break;
                    case 3:
                        recordcardAbbildung = new RecordcardAbbildung();
                        this.tabControl1.Controls.Add(recordcardAbbildung);
                        recordcard.KarteikartenTyp = KarteikartenTyp.Abbildung;
                        break;
                }
                Refresh();

                ObjRecordcardSet.RecordcardList.Add(recordcard);

                listBxKarteikarten.Items.Clear();
                foreach(Recordcard card in ObjRecordcardSet.RecordcardList) 
                {
                    listBxKarteikarten.Items.Add(card.getListboxName());
                }
                aktuellerKarteikartenIndex = listBxKarteikarten.Items.Count - 1;
            }
        }

        private void btnKarteikarteLoeschen_Click(object sender, EventArgs e)
        {
            // Aktuelle Karteikarte löschen und die vorherige in der Reihe anzeigen
            if(listBxKarteikarten.SelectedIndex >= 0)
            {
                ObjRecordcardSet.RecordcardList.RemoveAt(listBxKarteikarten.SelectedIndex);
                listBxKarteikarten.Items.RemoveAt(listBxKarteikarten.SelectedIndex);
                //TODO: stimmt noch nicht.
                //aktuellerKarteikartenIndex--;
                txtBxThema.Text = "";
                //listBxKarteikarten.SelectedIndex = -1;
                aktuellerKarteikartenIndex = -1;

                tabControl1.Controls.Clear();
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Wollen Sie die aktuelle Sammlung speichern und das Fenster schließen?", "Speichern und schließen?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (aktuellerKarteikartenIndex != -1)
                {
                    // Neue Karteikarte erstellen und die, die gerade bearbeitet wird speichern
                    Recordcard aktuelleRecordcard = ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex];
                    aktuelleRecordcard.Topic = txtBxThema.Text;
                    listBxKarteikarten.Items[aktuellerKarteikartenIndex] = aktuelleRecordcard.getListboxName();

                    switch (ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].KarteikartenTyp)
                    {
                        case KarteikartenTyp.Text:
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].QuestionText = recordcardText.getQuestion();
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].AnswerText = recordcardText.getAnswer();
                            break;
                        case KarteikartenTyp.Abbildung:
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].QuestionAbbildung = recordcardAbbildung.getQuestion();
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].AnswerAbbildung = recordcardAbbildung.getAnswer();
                            break;
                        case KarteikartenTyp.Aufzaehlung:
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].QuestionAufzaehlung = recordcardAufzaehlung.getQuestion();
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].AnswerAufzaehlung = recordcardAufzaehlung.getAnswer();
                            break;
                        case KarteikartenTyp.MultipleChoice:
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].QuestionMultipleChoice = recordcardMultipleChoice.getQuestion();
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].ChoicesMultipleChoice = recordcardMultipleChoice.getMultipleChoices();
                            ObjRecordcardSet.RecordcardList[aktuellerKarteikartenIndex].AnswerMultipleChoice = recordcardMultipleChoice.getAnswer();
                            break;
                    }
                }

                ObjRecordcardSet.Subject = txtBxFach.Text;
                FileHandler.write(XMLHandler.SerializeToXML(ObjRecordcardSet).InnerXml, FilePath);

                // Fenster schließen
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                //TODO: Später bei der Optimierung löschen
            }

        }

        private void btnVerwerfen_Click(object sender, EventArgs e)
        {
            // Abfragefenster Öffnen, ggf löschen und fenster schließen
            DialogResult dialogResult = MessageBox.Show("Wollen Sie die aktuelle Sammlung verwerfen?", "Verwerfen und schließen?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                //TODO: Später bei der Optimierung löschen
            }
        }

        private void txtBxFach_Leave(object sender, EventArgs e)
        {
            //TODO: String auslesen. Welches Fach
        }

        private void txtBxThema_Leave(object sender, EventArgs e)
        {
            //TODO: String auslesen. Welches Thema
        }

        private void comBoxKarteikartentyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tabControl1.Controls.Clear();

            //switch (comBoxKarteikartentyp.SelectedIndex)
            //{
            //    case 0:
            //        RecordcardText recordcardText = new RecordcardText();
            //        this.tabControl1.Controls.Add(recordcardText);
            //        break;
            //    case 1:
            //        RecordcardAufzaehlung recordcardAufzaehlung = new RecordcardAufzaehlung();
            //        this.tabControl1.Controls.Add(recordcardAufzaehlung);
            //        break;
            //    case 2:
            //        RecordcardMultipleChoice recordcardMultipleChoice = new RecordcardMultipleChoice();
            //        this.tabControl1.Controls.Add(recordcardMultipleChoice);
            //        break;
            //    case 3:
            //        RecordcardAbbildung recordcardAbbildung = new RecordcardAbbildung();
            //        this.tabControl1.Controls.Add(recordcardAbbildung);
            //        break;
            //}
            //Refresh();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
