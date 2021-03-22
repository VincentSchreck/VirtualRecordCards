
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNachLinks = new System.Windows.Forms.Button();
            this.btnNachRechts = new System.Windows.Forms.Button();
            this.btnSucheDatei = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 286);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNachLinks
            // 
            this.btnNachLinks.Location = new System.Drawing.Point(46, 399);
            this.btnNachLinks.Name = "btnNachLinks";
            this.btnNachLinks.Size = new System.Drawing.Size(75, 23);
            this.btnNachLinks.TabIndex = 4;
            this.btnNachLinks.Text = "L";
            this.btnNachLinks.UseVisualStyleBackColor = true;
            this.btnNachLinks.Click += new System.EventHandler(this.btnNachLinks_Click);
            // 
            // btnNachRechts
            // 
            this.btnNachRechts.Location = new System.Drawing.Point(678, 398);
            this.btnNachRechts.Name = "btnNachRechts";
            this.btnNachRechts.Size = new System.Drawing.Size(75, 23);
            this.btnNachRechts.TabIndex = 5;
            this.btnNachRechts.Text = "R";
            this.btnNachRechts.UseVisualStyleBackColor = true;
            this.btnNachRechts.Click += new System.EventHandler(this.btnNachRechts_Click);
            // 
            // btnSucheDatei
            // 
            this.btnSucheDatei.Location = new System.Drawing.Point(678, 25);
            this.btnSucheDatei.Name = "btnSucheDatei";
            this.btnSucheDatei.Size = new System.Drawing.Size(75, 23);
            this.btnSucheDatei.TabIndex = 1;
            this.btnSucheDatei.Text = "Suche";
            this.btnSucheDatei.UseVisualStyleBackColor = true;
            this.btnSucheDatei.Click += new System.EventHandler(this.btnSucheDatei_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dateispeicherort auswählen";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(182, 382);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(444, 56);
            this.listBox1.TabIndex = 6;
            // 
            // KarteikartenErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnNachRechts);
            this.Controls.Add(this.btnNachLinks);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSucheDatei);
            this.Controls.Add(this.label1);
            this.Name = "KarteikartenErstellen";
            this.Text = "KarteikartenErstellen";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNachLinks;
        private System.Windows.Forms.Button btnNachRechts;
        private System.Windows.Forms.Button btnSucheDatei;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}