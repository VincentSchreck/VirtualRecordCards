using System;
using System.Linq;
using System.Windows.Forms;
using VRC.Application;
using VRC.Domain;
using VRC.Handler;

namespace VRC.ViewPlugin
{
    public partial class KarteikartenEditorGUI : Form
    {
        KarteikartenEditor karteikartenEditor = new KarteikartenEditor();

        private RecordCardTypeGUI contentGUI;

        /*
         * Was
         * */

        public KarteikartenEditorGUI()
        {
            InitializeComponent();
        }

        public KarteikartenEditorGUI(string speicherort)
        {
            InitializeComponent();
            SpeicherUndLadeDateipfad(speicherort);
            StelleKarteikartensammlungDar();
            PasseButtonsnamenAufBearbeitenAn();
        }

        public void aktualisiereGUI()
        {
            StelleKarteikartensammlungDar();
            ZeigeAktuelleKarteikarte();
            AktualisiereAnzeige();
        }

        private void ZeigeAktuelleKarteikarte()
        {
            EntnehmeContentGUIDarstellungAus(karteikartenEditor.AktuelleKarteikarte);
        }

        private void btnNeueKarteikarte_Click(object sender, EventArgs e)
        {
            SpeichereDerzeitigeKarteikarteAb();
            SetzeKarteikartenIndexAuf(NeueKarteikarte());
            aktualisiereGUI();
        }

        private void btnKarteikarteLoeschen_Click(object sender, EventArgs e)
        {
            if (listBxKarteikarten.SelectedIndex < 0) return;
            LoescheDerzeitigeKarteikarte();
            ResetContentGUI();
            StelleKarteikartensammlungDar();
            AktualisiereAnzeige();
        }


        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (!MessageFrageObSicher("Wollen Sie die aktuelle Sammlung speichern und das Fenster schließen?", "Speichern und schließen?")) return;
            SpeichereDerzeitigeKarteikarteAb();
            SpeicherortAbfrageFallsNeueDatei();
            ÜbernehmeFachInDieKarteikartensammlung();
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
            if (listBxKarteikarten.SelectedIndex < 0) 
                return;
            ErlaubeSelectedIndexChangedFunktion(false);
            listBxKarteikarten.BeginUpdate();
            SpeichereDerzeitigeKarteikarteAb();
            SetzeKarteikartenIndexAuf(listBxKarteikarten.SelectedIndex);
            EntnehmeContentGUIDarstellungAus(karteikartenEditor.AktuelleKarteikarte);
            AktualisiereAnzeige();
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

        /*
         * Wie
         * 
         * 
         * */

        private void StelleKarteikartensammlungDar()
        {
            txtBxFach.Text = karteikartenEditor.ErhalteFachbezeichnung();
            listBxKarteikarten.Items.Clear();
            foreach (Recordcard card in karteikartenEditor.ErhalteKarteikartenSammlung())
            {
                listBxKarteikarten.Items.Add(card.getListboxName());
            }
        } //siehe untere Funktion

        private void SpeicherUndLadeDateipfad(string speicherort)
        {
            karteikartenEditor.FilePath = speicherort;
            karteikartenEditor.LadeKarteikartenSammlung(new SystemFileHandler(), new XMLHandler(), speicherort);        
        }

        private void PasseButtonsnamenAufBearbeitenAn()
        {
            btnSpeichern.Text = "Bearbeitung speichern";
            btnVerwerfen.Text = "Bearbeitung verwerfen";
        }

        private void SetzeKarteikartenIndexAuf(int value)
        {
            karteikartenEditor.SetzeKarteikartenIndex(value);
        }

        private void AktualisiereAnzeige() 
        {
            lblAnzVonKarten.Text = (karteikartenEditor.AktuellerKarteikartenIndex + 1) + "/" + karteikartenEditor.ListCount;
        }

        private int NeueKarteikarte()
        {
            RecordCardContent content;
            switch (comBoxKarteikartentyp.SelectedIndex)
            {
                case 0:
                    content = new RecordCardTextContent();
                    break;
                case 1:
                    content = new RecordCardAbbildungContent();
                    break;
                case 2:
                    content = new RecordCardAufzaehlungContent();
                    break;
                case 3:
                    content = new RecordCardMultipleChoiceContent();
                    break;
                default:
                    throw new Exception(); //TODO HANDLE
            }
            return karteikartenEditor.NeueKarteikarte(txtBxThema.Text, content);
        }

        private void SpeichereDerzeitigeKarteikarteAb()
        {
            if(contentGUI != null)
                karteikartenEditor.SpeichereAktuelleKarteikarteAb(txtBxThema.Text, contentGUI.EntnehmeContent());
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

            txtBxThema.Text = recordcard.Thema;

            tabControl1.Controls.Clear();
            this.tabControl1.Controls.Add(contentGUI);
            Refresh();
        }

        private void LoescheDerzeitigeKarteikarte()
        {
            karteikartenEditor.LoescheKarteikarte(karteikartenEditor.AktuelleKarteikarte);       
        }

        private void ResetContentGUI()
        {
            tabControl1.Controls.Clear();
            contentGUI = null;
            txtBxThema.Text = "";
        }

        private void ÜbernehmeFachInDieKarteikartensammlung()
        {
            karteikartenEditor.SetzeFachbezeichnung(txtBxFach.Text);
        }

        private void SpeichereKarteikartenSammlungAb()
        {
            karteikartenEditor.SpeichereKarteikartenSammlung( new SystemFileHandler(), new XMLHandler(), karteikartenEditor.FilePath);
        }

        private void SpeicherortAbfrageFallsNeueDatei()
        {
            if (karteikartenEditor.FilePath == null)
            {
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.Filter = "xml Dateien (*.xml)|*.xml| Alle Dateien (*.*)|*.*"; ;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    karteikartenEditor.FilePath = ofd.FileName; //Dateiname der ausgewählten Datei
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

        private void BeendeFenster()
        {
            this.Dispose();
        }
    }
}
