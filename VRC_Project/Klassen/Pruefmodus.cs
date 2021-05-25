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
        private List<Recordcard> falschBeantworteteRecordcards, aktuelleRecordcards;
        uint generellAnzahlKarten;
        bool nurfalschewiederholen, zufall;
        int richtigeCount;

        private RecordcardSet originalRecordcardSet;
        private PruefEinstellungData pruefEinstellungData;
        private int aktuellerKarteikartenIndex = 0;


        public Pruefmodus(PruefEinstellungData uebergebenePruefEinstellungData)
        {
            InitializeComponent();
            pruefEinstellungData = uebergebenePruefEinstellungData;
            originalRecordcardSet = XMLHandler.DeserializeFromXML(FileHandler.Read(pruefEinstellungData.speicherortKarteikartenset));
            falschBeantworteteRecordcards = new List<Recordcard>();
            aktuelleRecordcards = new List<Recordcard>();

            //Einstellungen übernehmen
            if (pruefEinstellungData.wiederholungenErlauben)
                MaximalRunden = pruefEinstellungData.anzahlWiederholungen;
            zufall = pruefEinstellungData.zufallsreihenfolge;
            nurfalschewiederholen = pruefEinstellungData.nurFalschBeantwortete;
            generellAnzahlKarten = pruefEinstellungData.anzahlGenerellKarteikarten;

            //--Initiale Einstellungen anwenden--
            // Zufall
            if (zufall)
            {
               originalRecordcardSet.wendeZufallsreihenfolgeAn();
            }
            aktuelleRecordcards = originalRecordcardSet.RecordcardList;
            // Kartenbegrenzung
            if(!pruefEinstellungData.alleKarteikarten)
            {
                uint anzahl = generellAnzahlKarten;
                if (anzahl > originalRecordcardSet.RecordcardList.Count)
                    anzahl = (uint)originalRecordcardSet.RecordcardList.Count;

                aktuelleRecordcards = aktuelleRecordcards.GetRange(0, (int) anzahl);
            }

            // GO
            KarteikarteDarstellen();
        }

        private void KarteikarteDarstellen()
        {
            if ((aktuellerKarteikartenIndex) < aktuelleRecordcards.Count)
            {
                //not'ing

            }
            else
            {         
                if (aktuelleRunde < MaximalRunden)
                {
                    if (nurfalschewiederholen)
                    {
                        if(falschBeantworteteRecordcards.Count == 0)
                        {
                            //Ergebnis und Ende
                            MessageBox.Show("Richtig: " + richtigeCount + "Falsch: " + (originalRecordcardSet.RecordcardList.Count - richtigeCount));
                            this.Close();
                            this.Dispose();
                            return;
                        }
                        
                        aktuelleRecordcards = falschBeantworteteRecordcards;
                    }

                    //neue runde, neues glück
                    MessageBox.Show("Neue Runde");
                    aktuellerKarteikartenIndex = 0;
                    aktuelleRunde++;
                    falschBeantworteteRecordcards = new List<Recordcard>();
                }
                else
                {
                    //Ergebnis und Ende
                    MessageBox.Show("Richtig: " + richtigeCount + "Falsch: " + (originalRecordcardSet.RecordcardList.Count - richtigeCount));
                    this.Close();
                    this.Dispose();
                    return;
                }
            }

            Recordcard recordcard = aktuelleRecordcards[aktuellerKarteikartenIndex];
            // Typ der Karteikarte, auf die gewechselt wird
            panelaReif.Controls.Clear();
            panelaAnswerson.Controls.Clear();
            btnRichtig.Enabled = false;
            btnFalsch.Enabled = false;
            btnAnwortAnzeigen.Enabled = true;

            if (recordcard.content.GetType() == typeof(RecordCardTextContent))
            {
                textBoxFrage.Text = ((RecordCardTextContent)recordcard.content).getQuestion();
                TextBox txtBxAntwortEingegeben = new TextBox();
                txtBxAntwortEingegeben.Multiline = true;
                txtBxAntwortEingegeben.Name = "txtBxAntwortEingegeben";
                txtBxAntwortEingegeben.Dock = DockStyle.Fill;
                txtBxAntwortEingegeben.TabIndex = 1;
                panelaReif.Controls.Add(txtBxAntwortEingegeben);
            }
            else if (recordcard.content.GetType() == typeof(RecordCardAufzaehlungContent))
            {
                textBoxFrage.Text = ((RecordCardAufzaehlungContent)recordcard.content).getQuestion();
                TextBox txtBxAntwortEingegeben = new TextBox();
                txtBxAntwortEingegeben.Multiline = true;
                txtBxAntwortEingegeben.Name = "txtBxAntwortEingegeben";
                txtBxAntwortEingegeben.Dock = DockStyle.Fill;
                txtBxAntwortEingegeben.TabIndex = 1;
                panelaReif.Controls.Add(txtBxAntwortEingegeben);
            }
            else if (recordcard.content.GetType() == typeof(RecordCardMultipleChoiceContent))
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
            else if (recordcard.content.GetType() == typeof(RecordCardAbbildungContent))
            {
                textBoxFrage.Text = ((RecordCardAbbildungContent)recordcard.content).getQuestion();
                // 
                // pictureBoxAntwortGegeben
                // 
                PictureBox pictureBoxAntwortGegeben = new PictureBox();
                //this.pictureBoxAntwortGegeben.Location = new System.Drawing.Point(12, 222);
                pictureBoxAntwortGegeben.Name = "pictureBoxAntwortGegeben";
                pictureBoxAntwortGegeben.Dock = DockStyle.Fill;
                pictureBoxAntwortGegeben.TabIndex = 3;
                pictureBoxAntwortGegeben.TabStop = false;
                pictureBoxAntwortGegeben.BackColor = Color.White;
                pictureBoxAntwortGegeben.BorderStyle = BorderStyle.FixedSingle;
                panelaReif.Controls.Add(pictureBoxAntwortGegeben);
            }
            Refresh();
        }

        private void btnAnwortAnzeigen_Click(object sender, EventArgs e)
        {
            Recordcard recordcard = aktuelleRecordcards[aktuellerKarteikartenIndex];
            // Typ der Karteikarte, auf die gewechselt wird
            panelaAnswerson.Controls.Clear();

            if (recordcard.content.GetType() == typeof(RecordCardTextContent))
            {
                TextBox txtBxMusterloesung = new TextBox();
                txtBxMusterloesung.Multiline = true;
                txtBxMusterloesung.Name = "txtBxAntwortEingegeben";
                txtBxMusterloesung.Dock = DockStyle.Fill;
                txtBxMusterloesung.TabIndex = 1;
                panelaAnswerson.Controls.Add(txtBxMusterloesung);
                txtBxMusterloesung.Text = ((RecordCardTextContent)recordcard.content).AnswerText;
            }
            else if (recordcard.content.GetType() == typeof(RecordCardAufzaehlungContent))
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
            else if (recordcard.content.GetType() == typeof(RecordCardMultipleChoiceContent))
            {
                TextBox txtBxMusterloesung = new TextBox();
                txtBxMusterloesung.Multiline = true;
                txtBxMusterloesung.Name = "txtBxAntwortEingegeben";
                txtBxMusterloesung.Dock = DockStyle.Fill;
                txtBxMusterloesung.TabIndex = 1;
                panelaAnswerson.Controls.Add(txtBxMusterloesung);
                txtBxMusterloesung.Text = ((RecordCardMultipleChoiceContent)recordcard.content).AnswerMultipleChoice;
            }
            else if (recordcard.content.GetType() == typeof(RecordCardAbbildungContent))
            {
                textBoxFrage.Text = ((RecordCardAbbildungContent)recordcard.content).getQuestion();
                PictureBox pictureBoxAntwortGegeben = new PictureBox();
                try
                {
                    pictureBoxAntwortGegeben.Image = Image.FromFile(((RecordCardAbbildungContent)recordcard.content).ImagePath);
                }
                catch(Exception ex)
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
            Refresh();
            btnRichtig.Enabled = true;
            btnFalsch.Enabled = true;
            btnAnwortAnzeigen.Enabled = false;
        }

        private void btnRichtig_Click(object sender, EventArgs e)
        {
            richtigeCount++;
            aktuellerKarteikartenIndex++;
            KarteikarteDarstellen();
        }

        private void btnFalsch_Click(object sender, EventArgs e)
        {
            falschBeantworteteRecordcards.Add(aktuelleRecordcards[aktuellerKarteikartenIndex]);
            aktuellerKarteikartenIndex++;
            KarteikarteDarstellen(); 
        }
    }
}
