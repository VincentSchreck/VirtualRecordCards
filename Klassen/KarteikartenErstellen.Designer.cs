
namespace VRC.Klassen
{
    partial class KarteikartenErstellen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKarteikarteLoeschen = new System.Windows.Forms.Button();
            this.btnNeueKarteikarte = new System.Windows.Forms.Button();
            this.btnSucheDatei = new System.Windows.Forms.Button();
            this.txtBxDateispeicherort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBxKarteikarten = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxFach = new System.Windows.Forms.TextBox();
            this.txtBxThema = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnVerwerfen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxKarteikartentyp = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnKarteikarteLoeschen
            // 
            this.btnKarteikarteLoeschen.Location = new System.Drawing.Point(500, 415);
            this.btnKarteikarteLoeschen.Name = "btnKarteikarteLoeschen";
            this.btnKarteikarteLoeschen.Size = new System.Drawing.Size(241, 23);
            this.btnKarteikarteLoeschen.TabIndex = 4;
            this.btnKarteikarteLoeschen.Text = "Karteikarte löschen";
            this.btnKarteikarteLoeschen.UseVisualStyleBackColor = true;
            this.btnKarteikarteLoeschen.Click += new System.EventHandler(this.btnKarteikarteLoeschen_Click);
            // 
            // btnNeueKarteikarte
            // 
            this.btnNeueKarteikarte.Location = new System.Drawing.Point(500, 382);
            this.btnNeueKarteikarte.Name = "btnNeueKarteikarte";
            this.btnNeueKarteikarte.Size = new System.Drawing.Size(241, 23);
            this.btnNeueKarteikarte.TabIndex = 5;
            this.btnNeueKarteikarte.Text = "Neue Karteikarte";
            this.btnNeueKarteikarte.UseVisualStyleBackColor = true;
            this.btnNeueKarteikarte.Click += new System.EventHandler(this.btnNeueKarteikarte_Click);
            // 
            // btnSucheDatei
            // 
            this.btnSucheDatei.Location = new System.Drawing.Point(709, 25);
            this.btnSucheDatei.Name = "btnSucheDatei";
            this.btnSucheDatei.Size = new System.Drawing.Size(75, 23);
            this.btnSucheDatei.TabIndex = 1;
            this.btnSucheDatei.Text = "Suche";
            this.btnSucheDatei.UseVisualStyleBackColor = true;
            this.btnSucheDatei.Click += new System.EventHandler(this.btnSucheDatei_Click);
            // 
            // txtBxDateispeicherort
            // 
            this.txtBxDateispeicherort.Location = new System.Drawing.Point(164, 27);
            this.txtBxDateispeicherort.Name = "txtBxDateispeicherort";
            this.txtBxDateispeicherort.Size = new System.Drawing.Size(539, 20);
            this.txtBxDateispeicherort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dateispeicherort auswählen:";
            // 
            // listBxKarteikarten
            // 
            this.listBxKarteikarten.FormattingEnabled = true;
            this.listBxKarteikarten.Location = new System.Drawing.Point(12, 382);
            this.listBxKarteikarten.Name = "listBxKarteikarten";
            this.listBxKarteikarten.Size = new System.Drawing.Size(444, 56);
            this.listBxKarteikarten.TabIndex = 6;
            this.listBxKarteikarten.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fach:";
            // 
            // txtBxFach
            // 
            this.txtBxFach.Location = new System.Drawing.Point(57, 65);
            this.txtBxFach.Name = "txtBxFach";
            this.txtBxFach.Size = new System.Drawing.Size(150, 20);
            this.txtBxFach.TabIndex = 8;
            this.txtBxFach.Enter += new System.EventHandler(this.txtBxFach_Leave);
            this.txtBxFach.Leave += new System.EventHandler(this.txtBxFach_Leave);
            // 
            // txtBxThema
            // 
            this.txtBxThema.Location = new System.Drawing.Point(287, 66);
            this.txtBxThema.Name = "txtBxThema";
            this.txtBxThema.Size = new System.Drawing.Size(197, 20);
            this.txtBxThema.TabIndex = 10;
            this.txtBxThema.Enter += new System.EventHandler(this.txtBxThema_Leave);
            this.txtBxThema.Leave += new System.EventHandler(this.txtBxThema_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thema:";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(551, 463);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 41);
            this.btnSpeichern.TabIndex = 11;
            this.btnSpeichern.Text = "Sammlung speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnVerwerfen
            // 
            this.btnVerwerfen.Location = new System.Drawing.Point(650, 463);
            this.btnVerwerfen.Name = "btnVerwerfen";
            this.btnVerwerfen.Size = new System.Drawing.Size(75, 41);
            this.btnVerwerfen.TabIndex = 11;
            this.btnVerwerfen.Text = "Sammlung verwerfen";
            this.btnVerwerfen.UseVisualStyleBackColor = true;
            this.btnVerwerfen.Click += new System.EventHandler(this.btnVerwerfen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Karteikartentyp:";
            // 
            // comBoxKarteikartentyp
            // 
            this.comBoxKarteikartentyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxKarteikartentyp.FormattingEnabled = true;
            this.comBoxKarteikartentyp.Items.AddRange(new object[] {
            "Text",
            "Auflistung",
            "Multiple-Choice",
            "Abbildung"});
            this.comBoxKarteikartentyp.Location = new System.Drawing.Point(589, 69);
            this.comBoxKarteikartentyp.Name = "comBoxKarteikartentyp";
            this.comBoxKarteikartentyp.Size = new System.Drawing.Size(195, 21);
            this.comBoxKarteikartentyp.TabIndex = 13;
            this.comBoxKarteikartentyp.SelectedIndexChanged += new System.EventHandler(this.comBoxKarteikartentyp_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(9, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(775, 280);
            this.tabControl1.TabIndex = 3;
            // 
            // KarteikartenErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.comBoxKarteikartentyp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerwerfen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.txtBxThema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxFach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBxKarteikarten);
            this.Controls.Add(this.btnNeueKarteikarte);
            this.Controls.Add(this.btnKarteikarteLoeschen);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtBxDateispeicherort);
            this.Controls.Add(this.btnSucheDatei);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KarteikartenErstellen";
            this.Text = "KarteikartenErstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKarteikarteLoeschen;
        private System.Windows.Forms.Button btnNeueKarteikarte;
        private System.Windows.Forms.Button btnSucheDatei;
        private System.Windows.Forms.TextBox txtBxDateispeicherort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBxKarteikarten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxFach;
        private System.Windows.Forms.TextBox txtBxThema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnVerwerfen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxKarteikartentyp;
        private System.Windows.Forms.Panel tabControl1;
        //private System.Windows.Forms.TabPage tabPageAntwort;
        //private System.Windows.Forms.TabPage tabPageFrage;
    }
}