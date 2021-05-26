using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VRC.Application;
using VRC.Domain;
using VRC.Handler;

namespace VRC.ViewPlugin
{
    public partial class PruefmodusGUI : Form
    {
        Pruefmodus pruefmodus = new Pruefmodus();

        public PruefmodusGUI(PruefEinstellungen uebergebenePruefEinstellungData)
        {
            InitializeComponent();
            pruefmodus.Uebernehme(new XMLHandler(), new SystemFileHandler(), uebergebenePruefEinstellungData) ;
            KarteikarteDarstellen();
        }

        private void btnAnwortAnzeigen_Click(object sender, EventArgs e)
        {
            ZeigeAntwortDerAktuellenKarteikarte();
            KarteikarteAufgedecktModus();
        }
        private void btnRichtig_Click(object sender, EventArgs e)
        {
            pruefmodus.nächsteKarteikarte(true);
            KarteikarteDarstellen();
        }

        private void btnFalsch_Click(object sender, EventArgs e)
        {
            pruefmodus.nächsteKarteikarte(false);
            KarteikarteDarstellen();
        }


        /* 
         *  Wie
         */

        private void KarteikarteDarstellen()
        {
            if (pruefmodus.PruefeRundenEnde())
            {
                if (pruefmodus.PruefeAbfrageEnde())
                {
                    BeendeMitErgebnisAusgabe();
                    return;
                }
                if (pruefmodus.PruefeFalschBehandelteModus())
                {
                    BeendeMitErgebnisAusgabe();
                    return;
                }

                pruefmodus.BehandelFalschBeantworteteFallsEingestellt();
                MessageBox.Show("Neue Runde");
                pruefmodus.StarteNeueRunde();
            }

            ZeigeFrageDerAktuellenKarteikarte();
            KarteikarteVerdecktModus();
        }

        private void BeendeMitErgebnisAusgabe()
        {
            MessageBox.Show("Richtig: " + pruefmodus.ErhalteAnzahlRichtiger() + "Falsch: " + (pruefmodus.ListCount-pruefmodus.ErhalteAnzahlRichtiger()));
            this.Close();
            this.Dispose();
            return;
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

        #region ZeigeFrage
        private void ZeigeFrageDerAktuellenKarteikarte()
        {
            Recordcard recordcard = pruefmodus.AktuelleKarteikarte;
            if (recordcard.content.GetType() == typeof(RecordCardTextContent))
            {
                ZeigeTextFrage(((RecordCardTextContent)recordcard.content).getQuestion());
            }
            else if (recordcard.content.GetType() == typeof(RecordCardAbbildungContent))
            {
                ZeigeAbbildungFrage(((RecordCardAbbildungContent)recordcard.content).getQuestion());
            }
            else if (recordcard.content.GetType() == typeof(RecordCardAufzaehlungContent))
            {
                ZeigeAufzaehlungFrage(((RecordCardAufzaehlungContent)recordcard.content).getQuestion());
            }
            else if (recordcard.content.GetType() == typeof(RecordCardMultipleChoiceContent))
            {
                ZeigeMultipleChoiceFrage(((RecordCardMultipleChoiceContent)recordcard.content).getQuestion(),
                                         ((RecordCardMultipleChoiceContent)recordcard.content).getMultipleChoiceList());
            }

            Refresh();
        }

        private void ZeigeTextFrage(string question)
        {
            textBoxFrage.Text = question;
            TextBox txtBxAntwortEingegeben = new TextBox();
            txtBxAntwortEingegeben.Multiline = true;
            txtBxAntwortEingegeben.Name = "txtBxAntwortEingegeben";
            txtBxAntwortEingegeben.Dock = DockStyle.Fill;
            txtBxAntwortEingegeben.TabIndex = 1;
            panelaReif.Controls.Add(txtBxAntwortEingegeben);
        }

        private void ZeigeAbbildungFrage(string question)
        {
            textBoxFrage.Text = question;
            PictureBox pictureBoxAntwortGegeben = new PictureBox();
            pictureBoxAntwortGegeben.Name = "pictureBoxAntwortGegeben";
            pictureBoxAntwortGegeben.Dock = DockStyle.Fill;
            pictureBoxAntwortGegeben.TabIndex = 3;
            pictureBoxAntwortGegeben.TabStop = false;
            pictureBoxAntwortGegeben.BackColor = Color.White;
            pictureBoxAntwortGegeben.BorderStyle = BorderStyle.FixedSingle;
            panelaReif.Controls.Add(pictureBoxAntwortGegeben);
        }

        private void ZeigeAufzaehlungFrage(string question)
        {
            textBoxFrage.Text = question;
            TextBox txtBxAntwortEingegeben = new TextBox();
            txtBxAntwortEingegeben.Multiline = true;
            txtBxAntwortEingegeben.Name = "txtBxAntwortEingegeben";
            txtBxAntwortEingegeben.Dock = DockStyle.Fill;
            txtBxAntwortEingegeben.TabIndex = 1;
            panelaReif.Controls.Add(txtBxAntwortEingegeben);
        }

        private void ZeigeMultipleChoiceFrage(string question, List<string> multipleChoices)
        {
            CheckedListBox checkedListBoxAntwortEingegeben = new CheckedListBox();
            checkedListBoxAntwortEingegeben.FormattingEnabled = true;
            checkedListBoxAntwortEingegeben.Name = "checkedListBoxAntwortEingegeben";
            checkedListBoxAntwortEingegeben.Dock = DockStyle.Fill;
            checkedListBoxAntwortEingegeben.TabIndex = 3;
            textBoxFrage.Text = question;
            panelaReif.Controls.Add(checkedListBoxAntwortEingegeben);
            foreach (var item in multipleChoices)
            {
                checkedListBoxAntwortEingegeben.Items.Add(item);
            }
        }

        #endregion

        #region ZeigeAntwort

        private void ZeigeAntwortDerAktuellenKarteikarte()
        {
            Recordcard recordcard = pruefmodus.AktuelleKarteikarte;
            panelaAnswerson.Controls.Clear();
            if (recordcard.content.GetType() == typeof(RecordCardTextContent))
            {
                ZeigeTextAntwort(((RecordCardTextContent)recordcard.content).AnswerText);
            }
            else if (recordcard.content.GetType() == typeof(RecordCardAbbildungContent))
            {
                ZeigeAbbildungAntwort(((RecordCardAbbildungContent)recordcard.content).ImagePath);
            }
            else if (recordcard.content.GetType() == typeof(RecordCardAufzaehlungContent))
            {
                ZeigeAufzaehlungAntwort(((RecordCardAufzaehlungContent)recordcard.content).getAnswerAufzaehlung());
            }
            else if (recordcard.content.GetType() == typeof(RecordCardMultipleChoiceContent))
            {
                ZeigeMultipleChoiceAntwort(((RecordCardMultipleChoiceContent)recordcard.content).AnswerMultipleChoice);
            }

            Refresh();
        }

        private void ZeigeTextAntwort(string Antwort)
        {
            TextBox txtBxMusterloesung = new TextBox();
            txtBxMusterloesung.Multiline = true;
            txtBxMusterloesung.Name = "txtBxAntwortEingegeben";
            txtBxMusterloesung.Dock = DockStyle.Fill;
            txtBxMusterloesung.TabIndex = 1;
            panelaAnswerson.Controls.Add(txtBxMusterloesung);
            txtBxMusterloesung.Text = Antwort;
        }

        private void ZeigeAbbildungAntwort(string imagepath)
        {
            PictureBox pictureBoxAntwortGegeben = new PictureBox();
            try
            {
                pictureBoxAntwortGegeben.Image = Image.FromFile(imagepath);
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

        private void ZeigeAufzaehlungAntwort(List<string> Antwortliste)
        {
            ListBox lstBxMusterloesung = new ListBox();
            foreach (var item in Antwortliste)
            {
                lstBxMusterloesung.Items.Add(item);
            }
            lstBxMusterloesung.Name = "txtBxAntwortEingegeben";
            lstBxMusterloesung.Dock = DockStyle.Fill;
            lstBxMusterloesung.TabIndex = 1;
            panelaAnswerson.Controls.Add(lstBxMusterloesung);
        }

        private void ZeigeMultipleChoiceAntwort(string Antwort)
        {
            TextBox txtBxMusterloesung = new TextBox();
            txtBxMusterloesung.Multiline = true;
            txtBxMusterloesung.Name = "txtBxAntwortEingegeben";
            txtBxMusterloesung.Dock = DockStyle.Fill;
            txtBxMusterloesung.TabIndex = 1;
            panelaAnswerson.Controls.Add(txtBxMusterloesung);
            txtBxMusterloesung.Text = Antwort;
        }

        #endregion 
    }
}
