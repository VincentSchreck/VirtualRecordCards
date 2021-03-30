
namespace VRC.Klassen
{
    partial class PruefEinstellungenGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblWieOft = new System.Windows.Forms.Label();
            this.txtBxPfadLadeKarteikartenset = new System.Windows.Forms.TextBox();
            this.btnKarteikartensetSuchen = new System.Windows.Forms.Button();
            this.checkBoxWiederholungenZulassen = new System.Windows.Forms.CheckBox();
            this.numericUpDownAnzWiederholungen = new System.Windows.Forms.NumericUpDown();
            this.checkBoxNurFalschBeantwortete = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxZufallsreihenfolge = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.numericUpDownGenerelleAnzahl = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnzWiederholungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerelleAnzahl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karteikartenset:";
            // 
            // lblWieOft
            // 
            this.lblWieOft.AutoSize = true;
            this.lblWieOft.Enabled = false;
            this.lblWieOft.Location = new System.Drawing.Point(129, 111);
            this.lblWieOft.Name = "lblWieOft";
            this.lblWieOft.Size = new System.Drawing.Size(44, 13);
            this.lblWieOft.TabIndex = 0;
            this.lblWieOft.Text = "Wie oft:";
            // 
            // txtBxPfadLadeKarteikartenset
            // 
            this.txtBxPfadLadeKarteikartenset.Location = new System.Drawing.Point(99, 31);
            this.txtBxPfadLadeKarteikartenset.Name = "txtBxPfadLadeKarteikartenset";
            this.txtBxPfadLadeKarteikartenset.Size = new System.Drawing.Size(502, 20);
            this.txtBxPfadLadeKarteikartenset.TabIndex = 1;
            // 
            // btnKarteikartensetSuchen
            // 
            this.btnKarteikartensetSuchen.Location = new System.Drawing.Point(607, 29);
            this.btnKarteikartensetSuchen.Name = "btnKarteikartensetSuchen";
            this.btnKarteikartensetSuchen.Size = new System.Drawing.Size(81, 23);
            this.btnKarteikartensetSuchen.TabIndex = 2;
            this.btnKarteikartensetSuchen.Text = "Durchsuchen";
            this.btnKarteikartensetSuchen.UseVisualStyleBackColor = true;
            this.btnKarteikartensetSuchen.Click += new System.EventHandler(this.btnKarteikartensetSuchen_Click);
            // 
            // checkBoxWiederholungenZulassen
            // 
            this.checkBoxWiederholungenZulassen.AutoSize = true;
            this.checkBoxWiederholungenZulassen.Location = new System.Drawing.Point(12, 79);
            this.checkBoxWiederholungenZulassen.Name = "checkBoxWiederholungenZulassen";
            this.checkBoxWiederholungenZulassen.Size = new System.Drawing.Size(157, 17);
            this.checkBoxWiederholungenZulassen.TabIndex = 3;
            this.checkBoxWiederholungenZulassen.Text = "Karteikartenset wiederholen";
            this.checkBoxWiederholungenZulassen.UseVisualStyleBackColor = true;
            this.checkBoxWiederholungenZulassen.CheckedChanged += new System.EventHandler(this.checkBoxWiederholungenZulassen_CheckedChanged);
            // 
            // numericUpDownAnzWiederholungen
            // 
            this.numericUpDownAnzWiederholungen.Enabled = false;
            this.numericUpDownAnzWiederholungen.Location = new System.Drawing.Point(179, 109);
            this.numericUpDownAnzWiederholungen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAnzWiederholungen.Name = "numericUpDownAnzWiederholungen";
            this.numericUpDownAnzWiederholungen.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAnzWiederholungen.TabIndex = 4;
            this.numericUpDownAnzWiederholungen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxNurFalschBeantwortete
            // 
            this.checkBoxNurFalschBeantwortete.AutoSize = true;
            this.checkBoxNurFalschBeantwortete.Enabled = false;
            this.checkBoxNurFalschBeantwortete.Location = new System.Drawing.Point(132, 135);
            this.checkBoxNurFalschBeantwortete.Name = "checkBoxNurFalschBeantwortete";
            this.checkBoxNurFalschBeantwortete.Size = new System.Drawing.Size(139, 17);
            this.checkBoxNurFalschBeantwortete.TabIndex = 5;
            this.checkBoxNurFalschBeantwortete.Text = "Nur falsch beantwortete";
            this.checkBoxNurFalschBeantwortete.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Anzahl:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Zufallsreihenfolge:";
            // 
            // checkBoxZufallsreihenfolge
            // 
            this.checkBoxZufallsreihenfolge.AutoSize = true;
            this.checkBoxZufallsreihenfolge.Location = new System.Drawing.Point(125, 215);
            this.checkBoxZufallsreihenfolge.Name = "checkBoxZufallsreihenfolge";
            this.checkBoxZufallsreihenfolge.Size = new System.Drawing.Size(15, 14);
            this.checkBoxZufallsreihenfolge.TabIndex = 5;
            this.checkBoxZufallsreihenfolge.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(607, 243);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // numericUpDownGenerelleAnzahl
            // 
            this.numericUpDownGenerelleAnzahl.Location = new System.Drawing.Point(125, 171);
            this.numericUpDownGenerelleAnzahl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGenerelleAnzahl.Name = "numericUpDownGenerelleAnzahl";
            this.numericUpDownGenerelleAnzahl.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGenerelleAnzahl.TabIndex = 4;
            this.numericUpDownGenerelleAnzahl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PruefEinstellungenGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 278);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.checkBoxZufallsreihenfolge);
            this.Controls.Add(this.checkBoxNurFalschBeantwortete);
            this.Controls.Add(this.numericUpDownGenerelleAnzahl);
            this.Controls.Add(this.numericUpDownAnzWiederholungen);
            this.Controls.Add(this.checkBoxWiederholungenZulassen);
            this.Controls.Add(this.btnKarteikartensetSuchen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxPfadLadeKarteikartenset);
            this.Controls.Add(this.lblWieOft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "PruefEinstellungenGUI";
            this.Text = "PruefEinstellungen";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnzWiederholungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerelleAnzahl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWieOft;
        private System.Windows.Forms.TextBox txtBxPfadLadeKarteikartenset;
        private System.Windows.Forms.Button btnKarteikartensetSuchen;
        private System.Windows.Forms.CheckBox checkBoxWiederholungenZulassen;
        private System.Windows.Forms.NumericUpDown numericUpDownAnzWiederholungen;
        private System.Windows.Forms.CheckBox checkBoxNurFalschBeantwortete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxZufallsreihenfolge;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown numericUpDownGenerelleAnzahl;
    }
}