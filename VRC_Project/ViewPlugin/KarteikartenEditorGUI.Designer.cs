namespace VRC.ViewPlugin
{
    partial class KarteikartenEditorGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAnzVonKarten = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKarteikarteLoeschen
            // 
            this.btnKarteikarteLoeschen.Location = new System.Drawing.Point(405, 137);
            this.btnKarteikarteLoeschen.Name = "btnKarteikarteLoeschen";
            this.btnKarteikarteLoeschen.Size = new System.Drawing.Size(343, 23);
            this.btnKarteikarteLoeschen.TabIndex = 4;
            this.btnKarteikarteLoeschen.Text = "Karteikarte löschen";
            this.btnKarteikarteLoeschen.UseVisualStyleBackColor = true;
            this.btnKarteikarteLoeschen.Click += new System.EventHandler(this.btnKarteikarteLoeschen_Click);
            // 
            // btnNeueKarteikarte
            // 
            this.btnNeueKarteikarte.Location = new System.Drawing.Point(9, 137);
            this.btnNeueKarteikarte.Name = "btnNeueKarteikarte";
            this.btnNeueKarteikarte.Size = new System.Drawing.Size(340, 23);
            this.btnNeueKarteikarte.TabIndex = 5;
            this.btnNeueKarteikarte.Text = "Neue Karteikarte kreieren";
            this.btnNeueKarteikarte.UseVisualStyleBackColor = true;
            this.btnNeueKarteikarte.Click += new System.EventHandler(this.btnNeueKarteikarte_Click);
            // 
            // listBxKarteikarten
            // 
            this.listBxKarteikarten.FormattingEnabled = true;
            this.listBxKarteikarten.Location = new System.Drawing.Point(9, 64);
            this.listBxKarteikarten.Name = "listBxKarteikarten";
            this.listBxKarteikarten.Size = new System.Drawing.Size(739, 56);
            this.listBxKarteikarten.TabIndex = 6;
            this.listBxKarteikarten.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fach:";
            // 
            // txtBxFach
            // 
            this.txtBxFach.Location = new System.Drawing.Point(49, 12);
            this.txtBxFach.Name = "txtBxFach";
            this.txtBxFach.Size = new System.Drawing.Size(175, 20);
            this.txtBxFach.TabIndex = 8;
            // 
            // txtBxThema
            // 
            this.txtBxThema.Location = new System.Drawing.Point(55, 23);
            this.txtBxThema.Name = "txtBxThema";
            this.txtBxThema.Size = new System.Drawing.Size(294, 20);
            this.txtBxThema.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thema:";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(408, 8);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(185, 26);
            this.btnSpeichern.TabIndex = 11;
            this.btnSpeichern.Text = "Sammlung speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnVerwerfen
            // 
            this.btnVerwerfen.Location = new System.Drawing.Point(599, 8);
            this.btnVerwerfen.Name = "btnVerwerfen";
            this.btnVerwerfen.Size = new System.Drawing.Size(185, 26);
            this.btnVerwerfen.TabIndex = 11;
            this.btnVerwerfen.Text = "Sammlung verwerfen";
            this.btnVerwerfen.UseVisualStyleBackColor = true;
            this.btnVerwerfen.Click += new System.EventHandler(this.btnVerwerfen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 26);
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
            "Abbildung",
            "Aufzaehlung",
            "Multiple-Choice"});
            this.comBoxKarteikartentyp.Location = new System.Drawing.Point(515, 23);
            this.comBoxKarteikartentyp.Name = "comBoxKarteikartentyp";
            this.comBoxKarteikartentyp.Size = new System.Drawing.Size(233, 21);
            this.comBoxKarteikartentyp.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(772, 274);
            this.tabControl1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comBoxKarteikartentyp);
            this.groupBox1.Controls.Add(this.txtBxThema);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnNeueKarteikarte);
            this.groupBox1.Controls.Add(this.listBxKarteikarten);
            this.groupBox1.Controls.Add(this.btnKarteikarteLoeschen);
            this.groupBox1.Location = new System.Drawing.Point(20, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 166);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Karteikarten verwalten";
            // 
            // lblAnzVonKarten
            // 
            this.lblAnzVonKarten.AutoSize = true;
            this.lblAnzVonKarten.Location = new System.Drawing.Point(247, 15);
            this.lblAnzVonKarten.Name = "lblAnzVonKarten";
            this.lblAnzVonKarten.Size = new System.Drawing.Size(24, 13);
            this.lblAnzVonKarten.TabIndex = 15;
            this.lblAnzVonKarten.Text = "0/0";
            // 
            // KarteikartenEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.lblAnzVonKarten);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerwerfen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.txtBxFach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KarteikartenEditor";
            this.Text = "Karteikarten-Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKarteikarteLoeschen;
        private System.Windows.Forms.Button btnNeueKarteikarte;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAnzVonKarten;
        //private System.Windows.Forms.TabPage tabPageAntwort;
        //private System.Windows.Forms.TabPage tabPageFrage;
    }
}