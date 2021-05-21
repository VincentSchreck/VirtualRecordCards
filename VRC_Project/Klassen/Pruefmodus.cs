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
            switch (recordcard.KarteikartenTyp)
            {
                case KarteikartenTyp.Text:
                    {
                        textBoxFrage.Text = recordcard.QuestionText;
                        // 
                        // txtBxAntwortEingegeben
                        // 
                        TextBox txtBxAntwortEingegeben = new TextBox();
                        //txtBxAntwortEingegeben.Location = new System.Drawing.Point(12, 221);
                        txtBxAntwortEingegeben.Multiline = true;
                        txtBxAntwortEingegeben.Name = "txtBxAntwortEingegeben";
                        txtBxAntwortEingegeben.Dock = DockStyle.Fill;
                        txtBxAntwortEingegeben.TabIndex = 1;
                        panelaReif.Controls.Add(txtBxAntwortEingegeben);
                    }
                    break;
                case KarteikartenTyp.Aufzaehlung:
                    {
                        textBoxFrage.Text = recordcard.QuestionAufzaehlung;
                        // 
                        // txtBxAntwortEingegeben
                        // 
                        TextBox txtBxAntwortEingegeben = new TextBox();
                        //txtBxAntwortEingegeben.Location = new System.Drawing.Point(12, 221);
                        txtBxAntwortEingegeben.Multiline = true;
                        txtBxAntwortEingegeben.Name = "txtBxAntwortEingegeben";
                        txtBxAntwortEingegeben.Dock = DockStyle.Fill;
                        txtBxAntwortEingegeben.TabIndex = 1;
                        panelaReif.Controls.Add(txtBxAntwortEingegeben);
                    }
                    break;
                case KarteikartenTyp.MultipleChoice:
                    // 
                    // checkedListBoxAntwortEingegeben
                    // 
                    CheckedListBox checkedListBoxAntwortEingegeben = new CheckedListBox();
                    checkedListBoxAntwortEingegeben.FormattingEnabled = true;
                    //this.checkedListBoxAntwortEingegeben.Location = new System.Drawing.Point(12, 222);
                    checkedListBoxAntwortEingegeben.Name = "checkedListBoxAntwortEingegeben";
                    checkedListBoxAntwortEingegeben.Dock = DockStyle.Fill;
                    checkedListBoxAntwortEingegeben.TabIndex = 3;
                    textBoxFrage.Text = recordcard.QuestionMultipleChoice;
                    panelaReif.Controls.Add(checkedListBoxAntwortEingegeben);
                    foreach (var item in recordcard.ChoicesMultipleChoice)
                    {
                        checkedListBoxAntwortEingegeben.Items.Add(item);
                    }
                    break;
                case KarteikartenTyp.Abbildung:
                    textBoxFrage.Text = recordcard.QuestionAbbildung;
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
                    break;
            }
            Refresh();
        }

        private void btnAnwortAnzeigen_Click(object sender, EventArgs e)
        {
            Recordcard recordcard = aktuelleRecordcards[aktuellerKarteikartenIndex];
            // Typ der Karteikarte, auf die gewechselt wird
            panelaAnswerson.Controls.Clear();
            switch (recordcard.KarteikartenTyp)
            {
                case KarteikartenTyp.Text:
                    {
                        // 
                        // txtBxAntwortEingegeben
                        // 
                        TextBox txtBxMusterloesung = new TextBox();
                        //txtBxAntwortEingegeben.Location = new System.Drawing.Point(12, 221);
                        txtBxMusterloesung.Multiline = true;
                        txtBxMusterloesung.Name = "txtBxAntwortEingegeben";
                        txtBxMusterloesung.Dock = DockStyle.Fill;
                        txtBxMusterloesung.TabIndex = 1;
                        panelaAnswerson.Controls.Add(txtBxMusterloesung);
                        txtBxMusterloesung.Text = recordcard.AnswerText;
                    }
                    break;
                case KarteikartenTyp.Aufzaehlung:
                    {
                        ListBox lstBxMusterloesung = new ListBox();
                        foreach (var item in recordcard.AnswerAufzaehlung)
                        {
                            lstBxMusterloesung.Items.Add(item);
                        }
                        lstBxMusterloesung.Name = "txtBxAntwortEingegeben";
                        lstBxMusterloesung.Dock = DockStyle.Fill;
                        lstBxMusterloesung.TabIndex = 1;
                        panelaAnswerson.Controls.Add(lstBxMusterloesung);
                    }
                    break;
                case KarteikartenTyp.MultipleChoice:
                    {
                        TextBox txtBxMusterloesung = new TextBox();
                        txtBxMusterloesung.Multiline = true;
                        txtBxMusterloesung.Name = "txtBxAntwortEingegeben";
                        txtBxMusterloesung.Dock = DockStyle.Fill;
                        txtBxMusterloesung.TabIndex = 1;
                        panelaAnswerson.Controls.Add(txtBxMusterloesung);
                        txtBxMusterloesung.Text = recordcard.AnswerMultipleChoice;
                    }
                    break;
                case KarteikartenTyp.Abbildung:
                    textBoxFrage.Text = recordcard.QuestionAbbildung;
                    PictureBox pictureBoxAntwortGegeben = new PictureBox();
                    try
                    {
                        pictureBoxAntwortGegeben.Image = Image.FromFile(recordcard.AnswerAbbildung);
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
                    break;
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
