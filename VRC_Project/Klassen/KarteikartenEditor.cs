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

namespace VRC.Klassen
{
    public partial class KarteikartenEditor : Form
    {
        private RecordcardSet recordcardSammlung = new RecordcardSet();
        private int aktuellerKarteikartenIndex = -1;
        private RecordCardTypeGUI contentGUI;
        private String FilePath;

        /*
         * Was
         * */

        public KarteikartenEditor()
        {
            InitializeComponent();
        }

        public KarteikartenEditor(string speicherort)
        {
            InitializeComponent();
            SpeicherUndLadeDateipfad(speicherort);
            StelleKarteikartensammlungDar();
            PasseButtonsnamenAufBearbeitenAn();
        }

        private void btnNeueKarteikarte_Click(object sender, EventArgs e)
        {
            SpeichereDerzeitigeKarteikarteAb();
            ZeigeKarteikarteAn(NeueKarteiKarte());
            KarteikartenIndexReset();
            SetzeKarteikartenIndexUndAktualisiereAnzeige(recordcardSammlung.RecordcardList.Count - 1);
        }


        private void ZeigeKarteikarteAn(Recordcard recordcard)
        {
            EntnehmeContentGUIDarstellungAus(recordcard);
            ResetDerKarteikartenListe();       
        }

        private void btnKarteikarteLoeschen_Click(object sender, EventArgs e)
        {
            if (listBxKarteikarten.SelectedIndex < 0) return;
            LoescheDerzeitigeKarteikarte();
            ResetDerThemaAnzeige();
            SetzeKarteikartenIndexUndAktualisiereAnzeige(0);
        }


        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (!MessageFrageObSicher("Wollen Sie die aktuelle Sammlung speichern und das Fenster schließen?", "Speichern und schließen?")) return;
            SpeichereDerzeitigeKarteikarteAb();
            SpeicherortAbfrageFallsNeueDatei();
            ÜbernehmeThemaInDieKarteikartensammlung();
            SpeichereKarteikartenSammlungAb();
            BeendeFenster();
        }



        private void btnVerwerfen_Click(object sender, EventArgs e)
        {
            if (!MessageFrageObSicher("Wollen Sie die aktuelle Sammlung verwerfen?", "Verwerfen und schließen?")) return;
            BeendeFenster();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBxKarteikarten.SelectedIndex < 0) return;
            ErlaubeSelectedIndexChangedFunktion(false);
            listBxKarteikarten.BeginUpdate();
            SpeichereDerzeitigeKarteikarteAb();
            EntnehmeContentGUIDarstellungAus(recordcardSammlung.RecordcardList[listBxKarteikarten.SelectedIndex]);
            SetzeKarteikartenIndexUndAktualisiereAnzeige(listBxKarteikarten.SelectedIndex);
            listBxKarteikarten.EndUpdate();
            ErlaubeSelectedIndexChangedFunktion(true);
        }

        private void ErlaubeSelectedIndexChangedFunktion(bool value)
        {
            if(value==false)
                listBxKarteikarten.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
            else
                listBxKarteikarten.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void comBoxKarteikartentyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tabControl1.Controls.Clear();

            //switch (comBoxKarteikartentyp.SelectedIndex)
            //{
            //    case (int)KarteikartenTyp.Text:
            //        this.tabControl1.Controls.Add(new RecordCardText().GetControls());
            //        break;
            //    case (int)KarteikartenTyp.Abbildung:
            //        this.tabControl1.Controls.Add(new RecordCardAbbildung().GetControls());
            //        break;

            //    case 0:
            //        RecordcardTextGUI recordcardText = new RecordcardTextGUI();
            //        this.tabControl1.Controls.Add(recordcardText);
            //        break;
            //    case 1:
            //        RecordcardAufzaehlungGUI recordcardAufzaehlung = new RecordcardAufzaehlungGUI();
            //        this.tabControl1.Controls.Add(recordcardAufzaehlung);
            //        break;
            //    case 2:
            //        RecordcardMultipleChoiceGUI recordcardMultipleChoice = new RecordcardMultipleChoiceGUI();
            //        this.tabControl1.Controls.Add(recordcardMultipleChoice);
            //        break;
            //    case 3:
            //        RecordcardAbbildungGUI recordcardAbbildung = new RecordcardAbbildungGUI();
            //        this.tabControl1.Controls.Add(recordcardAbbildung);
            //        break;
            //}
            //Refresh();
        }
    /*
     * Wie
     * 
     * 
     * */  
        private void StelleKarteikartensammlungDar()
        {
            txtBxFach.Text = recordcardSammlung.Subject;
            listBxKarteikarten.Items.Clear();
            foreach (Recordcard card in recordcardSammlung.RecordcardList)
            {
                listBxKarteikarten.Items.Add(card.getListboxName());
            }
        }

        private void SpeicherUndLadeDateipfad(string speicherort)
        {
            FilePath = speicherort;
            recordcardSammlung = XMLHandler.DeserializeFromXML(FileHandler.Read(FilePath));
        }

        private void PasseButtonsnamenAufBearbeitenAn()
        {
            btnSpeichern.Text = "Bearbeitung speichern";
            btnVerwerfen.Text = "Bearbeitung verwerfen";
        }

        private void KarteikartenIndexReset()
        {
            aktuellerKarteikartenIndex = listBxKarteikarten.Items.Count - 1;
        }

        private void SetzeKarteikartenIndexUndAktualisiereAnzeige(int value)
        {
            aktuellerKarteikartenIndex = value;
            lblAnzVonKarten.Text = (aktuellerKarteikartenIndex + 1) + "/" + recordcardSammlung.RecordcardList.Count();
        }

        private void ResetDerKarteikartenListe()
        {
            listBxKarteikarten.Items.Clear();
            foreach (Recordcard card in recordcardSammlung.RecordcardList)
            {
                listBxKarteikarten.Items.Add(card.getListboxName());
            }
        }

        private Recordcard NeueKarteiKarte()
        {
            Recordcard recordcard = new Recordcard();
            recordcard.Topic = txtBxThema.Text;
            recordcardSammlung.RecordcardList.Add(recordcard);

            switch (comBoxKarteikartentyp.SelectedIndex)
            {
                case 0:
                    recordcard.content = new RecordCardTextContent();
                    break;
                case 1:
                    recordcard.content = new RecordCardAbbildungContent();
                    break;
                case 2:
                    recordcard.content = new RecordCardAufzaehlungContent();
                    break;
                case 3:
                    recordcard.content = new RecordCardMultipleChoiceContent();
                    break;
                default:
                    return null;
            }
            return recordcard;
        }

        private void SpeichereDerzeitigeKarteikarteAb()
        {
            if (aktuellerKarteikartenIndex != -1)
            {
                Recordcard aktuelleRecordcard = recordcardSammlung.RecordcardList[aktuellerKarteikartenIndex];
                aktuelleRecordcard.Topic = txtBxThema.Text;
                aktuelleRecordcard.content = contentGUI.EntnehmeContent();
                listBxKarteikarten.Items[aktuellerKarteikartenIndex] = aktuelleRecordcard.getListboxName();             
            }
        }

        private void EntnehmeContentGUIDarstellungAus(Recordcard recordcard)
        {
            if (recordcard.content.GetType() == typeof(RecordCardTextContent))
                contentGUI = new RecordcardTextGUI((RecordCardTextContent)recordcard.content);
            else if (recordcard.content.GetType() == typeof(RecordCardAbbildungContent))
                contentGUI = new RecordcardAbbildungGUI((RecordCardAbbildungContent)recordcard.content);
            else if (recordcard.content.GetType() == typeof(RecordCardAufzaehlungContent))
                contentGUI = new RecordcardAufzaehlungGUI((RecordCardAufzaehlungContent)recordcard.content);
            else if (recordcard.content.GetType() == typeof(RecordCardMultipleChoiceContent))
                contentGUI = new RecordcardMultipleChoiceGUI((RecordCardMultipleChoiceContent)recordcard.content);

            txtBxThema.Text = recordcard.Topic;

            tabControl1.Controls.Clear();
            this.tabControl1.Controls.Add(contentGUI);
            Refresh();
        }

        private void LoescheDerzeitigeKarteikarte()
        {
            recordcardSammlung.RecordcardList.RemoveAt(listBxKarteikarten.SelectedIndex);
            listBxKarteikarten.Items.RemoveAt(listBxKarteikarten.SelectedIndex);
            aktuellerKarteikartenIndex = -1;
            tabControl1.Controls.Clear();
            contentGUI = null;
        }

        private void ResetDerThemaAnzeige()
        {
            txtBxThema.Text = "";
        }

        private void ÜbernehmeThemaInDieKarteikartensammlung()
        {
            recordcardSammlung.Subject = txtBxFach.Text;
        }

        private void BeendeFenster()
        {
            this.Dispose();
        }

        private void SpeichereKarteikartenSammlungAb()
        {
            FileHandler.write(XMLHandler.SerializeToXML(recordcardSammlung).InnerXml, FilePath);
        }

        private void SpeicherortAbfrageFallsNeueDatei()
        {
            if (FilePath == null)
            {
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.Filter = "xml Dateien (*.xml)|*.xml| Alle Dateien (*.*)|*.*"; ;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FilePath = ofd.FileName; //Dateiname der ausgewählten Datei
                }
            }
        }

        private static bool MessageFrageObSicher(string text, string title)
        {
            var dialogResult = MessageBox.Show(text, title, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
