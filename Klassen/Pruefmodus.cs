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
        public Pruefmodus(PruefEinstellungData uebergebenePruefEinstellungData)
        {
            InitializeComponent();
            pruefEinstellungData = uebergebenePruefEinstellungData;
            recordcardSet = XMLHandler.DeserializeFromXML(FileHandler.Read(pruefEinstellungData.speicherortKarteikartenset));
            KarteikarteDarstellen();
        }

        private RecordcardSet recordcardSet;
        private PruefEinstellungData pruefEinstellungData;
        private int aktuellerKarteikartenIndex = 0;

        private void KarteikarteDarstellen()
        {
            Recordcard recordcard = recordcardSet.RecordcardList[aktuellerKarteikartenIndex];
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
            Recordcard recordcard = recordcardSet.RecordcardList[aktuellerKarteikartenIndex];
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
                        // txtBxAntwortEingegeben
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
                        // checkedListBoxAntwortEingegeben
                        TextBox txtBxMusterloesung = new TextBox();
                        //txtBxAntwortEingegeben.Location = new System.Drawing.Point(12, 221);
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
                    // 
                    // pictureBoxAntwortGegeben
                    // 
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
            //TODO: zu richtig beantworteten Karteikarten hinzufügen
            if ((aktuellerKarteikartenIndex + 1) < recordcardSet.RecordcardList.Count)
            {
                aktuellerKarteikartenIndex++;
                KarteikarteDarstellen();
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btnFalsch_Click(object sender, EventArgs e)
        {
            //TODO: zu falsch beantworteten Karteikarten hinzufügen
            if ((aktuellerKarteikartenIndex + 1) < recordcardSet.RecordcardList.Count)
            {
                aktuellerKarteikartenIndex++;
                KarteikarteDarstellen();
            }
            else
            {
                MessageBox.Show("");
            }
        }
    }
}



//// 
//// pictureBoxAntwortGegeben
//// 
//this.pictureBoxAntwortGegeben.Location = new System.Drawing.Point(12, 222);
//this.pictureBoxAntwortGegeben.Name = "pictureBoxAntwortGegeben";
//this.pictureBoxAntwortGegeben.Size = new System.Drawing.Size(390, 187);
//this.pictureBoxAntwortGegeben.TabIndex = 3;
//this.pictureBoxAntwortGegeben.TabStop = false;

//// 
//// checkedListBoxAntwortEingegeben
//// 
//this.checkedListBoxAntwortEingegeben.FormattingEnabled = true;
//this.checkedListBoxAntwortEingegeben.Location = new System.Drawing.Point(12, 222);
//this.checkedListBoxAntwortEingegeben.Name = "checkedListBoxAntwortEingegeben";
//this.checkedListBoxAntwortEingegeben.Size = new System.Drawing.Size(390, 184);
//this.checkedListBoxAntwortEingegeben.TabIndex = 3;

//// 
//// txtBxAntwortEingegeben
//// 
//this.txtBxAntwortEingegeben.Location = new System.Drawing.Point(12, 221);
//this.txtBxAntwortEingegeben.Multiline = true;
//this.txtBxAntwortEingegeben.Name = "txtBxAntwortEingegeben";
//this.txtBxAntwortEingegeben.Size = new System.Drawing.Size(390, 188);
//this.txtBxAntwortEingegeben.TabIndex = 1;