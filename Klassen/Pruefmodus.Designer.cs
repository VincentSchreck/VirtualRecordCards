
namespace VRC.Klassen
{
    partial class Pruefmodus
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
            this.btnRichtig = new System.Windows.Forms.Button();
            this.btnFalsch = new System.Windows.Forms.Button();
            this.lblFrage = new System.Windows.Forms.Label();
            this.lblAntwort = new System.Windows.Forms.Label();
            this.textBoxFrage = new System.Windows.Forms.TextBox();
            this.btnAnwortAnzeigen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelaReif = new System.Windows.Forms.Panel();
            this.panelaAnswerson = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnRichtig
            // 
            this.btnRichtig.Enabled = false;
            this.btnRichtig.Location = new System.Drawing.Point(423, 415);
            this.btnRichtig.Name = "btnRichtig";
            this.btnRichtig.Size = new System.Drawing.Size(171, 23);
            this.btnRichtig.TabIndex = 0;
            this.btnRichtig.Text = "Richtig";
            this.btnRichtig.UseVisualStyleBackColor = true;
            this.btnRichtig.Click += new System.EventHandler(this.btnRichtig_Click);
            // 
            // btnFalsch
            // 
            this.btnFalsch.Enabled = false;
            this.btnFalsch.Location = new System.Drawing.Point(617, 415);
            this.btnFalsch.Name = "btnFalsch";
            this.btnFalsch.Size = new System.Drawing.Size(171, 23);
            this.btnFalsch.TabIndex = 0;
            this.btnFalsch.Text = "Falsch";
            this.btnFalsch.UseVisualStyleBackColor = true;
            this.btnFalsch.Click += new System.EventHandler(this.btnFalsch_Click);
            // 
            // lblFrage
            // 
            this.lblFrage.AutoSize = true;
            this.lblFrage.Location = new System.Drawing.Point(9, 9);
            this.lblFrage.Name = "lblFrage";
            this.lblFrage.Size = new System.Drawing.Size(37, 13);
            this.lblFrage.TabIndex = 2;
            this.lblFrage.Text = "Frage:";
            // 
            // lblAntwort
            // 
            this.lblAntwort.AutoSize = true;
            this.lblAntwort.Location = new System.Drawing.Point(9, 206);
            this.lblAntwort.Name = "lblAntwort";
            this.lblAntwort.Size = new System.Drawing.Size(46, 13);
            this.lblAntwort.TabIndex = 2;
            this.lblAntwort.Text = "Antwort:";
            // 
            // textBoxFrage
            // 
            this.textBoxFrage.Location = new System.Drawing.Point(12, 25);
            this.textBoxFrage.Multiline = true;
            this.textBoxFrage.Name = "textBoxFrage";
            this.textBoxFrage.Size = new System.Drawing.Size(390, 169);
            this.textBoxFrage.TabIndex = 1;
            // 
            // btnAnwortAnzeigen
            // 
            this.btnAnwortAnzeigen.Location = new System.Drawing.Point(423, 25);
            this.btnAnwortAnzeigen.Name = "btnAnwortAnzeigen";
            this.btnAnwortAnzeigen.Size = new System.Drawing.Size(365, 23);
            this.btnAnwortAnzeigen.TabIndex = 0;
            this.btnAnwortAnzeigen.Text = "Musterlösung anzeigen";
            this.btnAnwortAnzeigen.UseVisualStyleBackColor = true;
            this.btnAnwortAnzeigen.Click += new System.EventHandler(this.btnAnwortAnzeigen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Musterlösung:";
            // 
            // panelaReif
            // 
            this.panelaReif.Location = new System.Drawing.Point(12, 223);
            this.panelaReif.Name = "panelaReif";
            this.panelaReif.Size = new System.Drawing.Size(390, 215);
            this.panelaReif.TabIndex = 3;
            // 
            // panelaAnswerson
            // 
            this.panelaAnswerson.BackColor = System.Drawing.Color.White;
            this.panelaAnswerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelaAnswerson.Location = new System.Drawing.Point(423, 68);
            this.panelaAnswerson.Name = "panelaAnswerson";
            this.panelaAnswerson.Size = new System.Drawing.Size(365, 341);
            this.panelaAnswerson.TabIndex = 4;
            // 
            // Pruefmodus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelaAnswerson);
            this.Controls.Add(this.panelaReif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAntwort);
            this.Controls.Add(this.lblFrage);
            this.Controls.Add(this.textBoxFrage);
            this.Controls.Add(this.btnFalsch);
            this.Controls.Add(this.btnAnwortAnzeigen);
            this.Controls.Add(this.btnRichtig);
            this.Name = "Pruefmodus";
            this.Text = "Pruefmodus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRichtig;
        private System.Windows.Forms.Button btnFalsch;
        private System.Windows.Forms.Label lblFrage;
        private System.Windows.Forms.Label lblAntwort;
        private System.Windows.Forms.TextBox textBoxFrage;
        private System.Windows.Forms.Button btnAnwortAnzeigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelaReif;
        private System.Windows.Forms.Panel panelaAnswerson;
    }
}