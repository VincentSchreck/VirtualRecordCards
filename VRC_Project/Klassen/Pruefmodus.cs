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
    public partial class Pruefmodus : Form
    {
        private uint MaximalRunden = 1, aktuelleRunde = 1;
        private List<Recordcard> falschBeantworteteRecordcards = new List<Recordcard>(),
            aktuelleRecordcards = new List<Recordcard>();
        uint generellAnzahlKarten;
        bool nurfalschewiederholen, zufall;
        int richtigeCount;

        private RecordcardSet originalRecordcardSet;
        private int aktuellerKarteikartenIndex = 0;


        public Pruefmodus(PruefEinstellungData uebergebenePruefEinstellungData)
        {
            InitializeComponent();
            Uebernehme(uebergebenePruefEinstellungData);
            KarteikarteDarstellen();
        }

        private void Uebernehme(PruefEinstellungData uebergebenePruefEinstellungData)
        {
            LeseKarteikartenSammlungAus(uebergebenePruefEinstellungData);
            UebernehmeEinfacheEinstellungenAus(uebergebenePruefEinstellungData);
            ÜbernehmeZufallsEinstellungenAus(uebergebenePruefEinstellungData);
            BegrenzeKartenUeber(uebergebenePruefEinstellungData);
        }


        private void btnAnwortAnzeigen_Click(object sender, EventArgs e)
        {
            ZeigeAntwortDerAktuellenKarteikarte();
            KarteikarteAufgedecktModus();
        }
        private void btnRichtig_Click(object sender, EventArgs e)
        {
            richtigeCount++;
            aktuellerKarteikartenIndex++;
            KarteikarteDarstellen();
        }

        private void btnFalsch_Click(object sender, EventArgs e)
        {
            FuegeAktuellteKarteZuFalschenHinzu();
            aktuellerKarteikartenIndex++;
            KarteikarteDarstellen();
        }


        /* 
         *  Wie
         */
        private void ZeigeAntwortDerAktuellenKarteikarte()
        {
            Recordcard recordcard = aktuelleRecordcards[aktuellerKarteikartenIndex];
            panelaAnswerson.Controls.Clear();
            if (recordcard.content.GetType() == typeof(RecordCardTextContent))
            {
                ZeigeTextAntwort(recordcard);
            }
            else if (recordcard.content.GetType() == typeof(RecordCardAufzaehlungContent))
            {
                ZeigeAufzaehlungAntwort(recordcard);
            }
            else if (recordcard.content.GetType() == typeof(RecordCardMultipleChoiceContent))
            {
                ZeigeMultipleChoiceAntwort(recordcard);
            }
            else if (recordcard.content.GetType() == typeof(RecordCardAbbildungContent))
            {
                ZeigeAbbildungAntwort(recordcard);
            }
            Refresh();
        }

        private void KarteikarteDarstellen()
        {
            if (PruefeRundenEnde())
            {
                if (PruefeAbfrageEnde())
                {
                    BeendeMitErgebnisAusgabe();
                    return;
                }
                BehandelFalschBeantworteteFallsEingestellt();
                StarteNeueRunde();
            }

            ZeigeFrageDerAktuellenKarteikarte();
            KarteikarteVerdecktModus();
        }

        private void BehandelFalschBeantworteteFallsEingestellt()
        {
            if (nurfalschewiederholen)
            {
                if (falschBeantworteteRecordcards.Count == 0)
                {
                    BeendeMitErgebnisAusgabe();
                    return;
                }
                aktuelleRecordcards = falschBeantworteteRecordcards;
            }
        }

        private void StarteNeueRunde()
        {
            MessageBox.Show("Neue Runde");
            aktuellerKarteikartenIndex = 0;
            aktuelleRunde++;
            falschBeantworteteRecordcards = new List<Recordcard>();
        }

        private void BeendeMitErgebnisAusgabe()
        {
            MessageBox.Show("Richtig: " + richtigeCount + "Falsch: " + (originalRecordcardSet.RecordcardList.Count - richtigeCount));
            this.Close();
            this.Dispose();
            return;
        }

        private bool PruefeAbfrageEnde()
        {
            return aktuelleRunde >= MaximalRunden;
        }

        private bool PruefeRundenEnde()
        {
            return (aktuellerKarteikartenIndex) >= aktuelleRecordcards.Count;
        }

        private void ZeigeFrageDerAktuellenKarteikarte()
        {
            Recordcard recordcard = aktuelleRecordcards[aktuellerKarteikartenIndex];
            if (recordcard.content.GetType() == typeof(RecordCardTextContent))
            {
                ZeigeTextFrage(recordcard);
            }
            else if (recordcard.content.GetType() == typeof(RecordCardAufzaehlungContent))
            {
                ZeigeAufzaehlungFrage(recordcard);
            }
            else if (recordcard.content.GetType() == typeof(RecordCardMultipleChoiceContent))
            {
                ZeigeMultipleChoiceFrage(recordcard);
            }
            else if (recordcard.content.GetType() == typeof(RecordCardAbbildungContent))
            {
                ZeigeAbbildungFrage(recordcard);
            }
            Refresh();
        }

        private void KarteikarteVerdecktModus()
        {
            panelaReif.Controls.Clear();
            panelaAnswerson.Controls.Clear();
            btnRichtig.Enabled = false;
            btnFalsch.Enabled = false;
            btnAnwortAnzeigen.Enabled = true;
        }

        private void KarteikarteAufgedecktModus()
        {
            btnRichtig.Enabled = true;
            btnFalsch.Enabled = true;
            btnAnwortAnzeigen.Enabled = false;
        }

        private void ZeigeAbbildungFrage(Recordcard recordcard)
        {
            textBoxFrage.Text = ((RecordCardAbbildungContent)recordcard.content).getQuestion();
            PictureBox pictureBoxAntwortGegeben = new PictureBox();
            pictureBoxAntwortGegeben.Name = "pictureBoxAntwortGegeben";
            pictureBoxAntwortGegeben.Dock = DockStyle.Fill;
            pictureBoxAntwortGegeben.TabIndex = 3;
            pictureBoxAntwortGegeben.TabStop = false;
            pictureBoxAntwortGegeben.BackColor = Color.White;
            pictureBoxAntwortGegeben.BorderStyle = BorderStyle.FixedSingle;
            panelaReif.Controls.Add(pictureBoxAntwortGegeben);
        }

        private void ZeigeMultipleChoiceFrage(Recordcard recordcard)
        {
            CheckedListBox checkedListBoxAntwortEingegeben = new CheckedListBox();
            checkedListBoxAntwortEingegeben.FormattingEnabled = true;
            checkedListBoxAntwortEingegeben.Name = "checkedListBoxAntwortEingegeben";
            checkedListBoxAntwortEingegeben.Dock = DockStyle.Fill;
            checkedListBoxAntwortEingegeben.TabIndex = 3;
            textBoxFrage.Text = ((RecordCardMultipleChoiceContent)recordcard.content).getQuestion();
            panelaReif.Controls.Add(checkedListBoxAntwortEingegeben);
            foreach (var item in ((RecordCardMultipleChoiceContent)recordcard.content).getMultipleChoiceList())
            {
                checkedListBoxAntwortEingegeben.Items.Add(item);
            }
        }

        private void ZeigeAufzaehlungFrage(Recordcard recordcard)
        {
            textBoxFrage.Text = ((RecordCardAufzaehlungContent)recordcard.content).getQuestion();
            TextBox txtBxAntwortEingegeben = new TextBox();
            txtBxAntwortEingegeben.Multiline = true;
            txtBxAntwortEingegeben.Name = "txtBxAntwortEingegeben";
            txtBxAntwortEingegeben.Dock = DockStyle.Fill;
            txtBxAntwortEingegeben.TabIndex = 1;
            panelaReif.Controls.Add(txtBxAntwortEingegeben);
        }

        private void ZeigeTextFrage(Recordcard recordcard)
        {
            textBoxFrage.Text = ((RecordCardTextContent)recordcard.content).getQuestion();
            TextBox txtBxAntwortEingegeben = new TextBox();
            txtBxAntwortEingegeben.Multiline = true;
            txtBxAntwortEingegeben.Name = "txtBxAntwortEingegeben";
            txtBxAntwortEingegeben.Dock = DockStyle.Fill;
            txtBxAntwortEingegeben.TabIndex = 1;
            panelaReif.Controls.Add(txtBxAntwortEingegeben);
        }

        private void FuegeAktuellteKarteZuFalschenHinzu()
        {
            if(!falschBeantworteteRecordcards.Contains(aktuelleRecordcards[aktuellerKarteikartenIndex]))
                falschBeantworteteRecordcards.Add(aktuelleRecordcards[aktuellerKarteikartenIndex]);
        }

        private void ZeigeAbbildungAntwort(Recordcard recordcard)
        {
            textBoxFrage.Text = ((RecordCardAbbildungContent)recordcard.content).getQuestion();
            PictureBox pictureBoxAntwortGegeben = new PictureBox();
            try
            {
                pictureBoxAntwortGegeben.Image = Image.FromFile(((RecordCardAbbildungContent)recordcard.content).ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pictureBoxAntwortGegeben.Name = "pictureBoxAntwortGegeben";
            pictureBoxAntwortGegeben.Dock = DockStyle.Fill;
            pictureBoxAntwortGegeben.TabIndex = 3;
            pictureBoxAntwortGegeben.TabStop = false;
            pictureBoxAntwortGegeben.BackColor = Color.White;
            panelaReif.Controls.Add(pictureBoxAntwortGegeben);
        }

        private void ZeigeMultipleChoiceAntwort(Recordcard recordcard)
        {
            TextBox txtBxMusterloesung = new TextBox();
            txtBxMusterloesung.Multiline = true;
            txtBxMusterloesung.Name = "txtBxAntwortEingegeben";
            txtBxMusterloesung.Dock = DockStyle.Fill;
            txtBxMusterloesung.TabIndex = 1;
            panelaAnswerson.Controls.Add(txtBxMusterloesung);
            txtBxMusterloesung.Text = ((RecordCardMultipleChoiceContent)recordcard.content).AnswerMultipleChoice;
        }

        private void ZeigeAufzaehlungAntwort(Recordcard recordcard)
        {
            ListBox lstBxMusterloesung = new ListBox();
            foreach (var item in ((RecordCardAufzaehlungContent)recordcard.content).getAnswerAufzaehlung())
            {
                lstBxMusterloesung.Items.Add(item);
            }
            lstBxMusterloesung.Name = "txtBxAntwortEingegeben";
            lstBxMusterloesung.Dock = DockStyle.Fill;
            lstBxMusterloesung.TabIndex = 1;
            panelaAnswerson.Controls.Add(lstBxMusterloesung);
        }

        private void ZeigeTextAntwort(Recordcard recordcard)
        {
            TextBox txtBxMusterloesung = new TextBox();
            txtBxMusterloesung.Multiline = true;
            txtBxMusterloesung.Name = "txtBxAntwortEingegeben";
            txtBxMusterloesung.Dock = DockStyle.Fill;
            txtBxMusterloesung.TabIndex = 1;
            panelaAnswerson.Controls.Add(txtBxMusterloesung);
            txtBxMusterloesung.Text = ((RecordCardTextContent)recordcard.content).AnswerText;
        }

        private void LeseKarteikartenSammlungAus(PruefEinstellungData uebergebenePruefEinstellungData)
        {
            originalRecordcardSet = XMLHandler.DeserializeFromXML(FileHandler.Read(uebergebenePruefEinstellungData.speicherortKarteikartenset));
        }

        private void UebernehmeEinfacheEinstellungenAus(PruefEinstellungData uebergebenePruefEinstellungData)
        {
            if (uebergebenePruefEinstellungData.wiederholungenErlauben)
                MaximalRunden = uebergebenePruefEinstellungData.anzahlWiederholungen;

            nurfalschewiederholen = uebergebenePruefEinstellungData.nurFalschBeantwortete;
            generellAnzahlKarten = uebergebenePruefEinstellungData.anzahlGenerellKarteikarten;
        }

        private void BegrenzeKartenUeber(PruefEinstellungData uebergebenePruefEinstellungData)
        {
            if (!uebergebenePruefEinstellungData.alleKarteikarten)
            {
                uint anzahl = generellAnzahlKarten;
                if (anzahl > originalRecordcardSet.RecordcardList.Count)
                    anzahl = (uint)originalRecordcardSet.RecordcardList.Count;

                aktuelleRecordcards = aktuelleRecordcards.GetRange(0, (int)anzahl);
            }
        }

        private void ÜbernehmeZufallsEinstellungenAus(PruefEinstellungData uebergebenePruefEinstellungData)
        {
            zufall = uebergebenePruefEinstellungData.zufallsreihenfolge;
            if (zufall)
            {
                originalRecordcardSet.wendeZufallsreihenfolgeAn();
            }
            aktuelleRecordcards = originalRecordcardSet.RecordcardList;
        }

    }
}
