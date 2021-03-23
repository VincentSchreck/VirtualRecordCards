
namespace VRC.Klassen
{
    partial class RecordcardAbbildung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFrage = new System.Windows.Forms.TabPage();
            this.textBoxTextFrage = new System.Windows.Forms.TextBox();
            this.tabPageAntwort = new System.Windows.Forms.TabPage();
            this.btnAbbildungSuchen = new System.Windows.Forms.Button();
            this.txtBoxGrafikSuchen = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBoxAntwort = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageFrage.SuspendLayout();
            this.tabPageAntwort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAntwort)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFrage);
            this.tabControl1.Controls.Add(this.tabPageAntwort);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(775, 280);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFrage
            // 
            this.tabPageFrage.Controls.Add(this.textBoxTextFrage);
            this.tabPageFrage.Location = new System.Drawing.Point(4, 22);
            this.tabPageFrage.Name = "tabPageFrage";
            this.tabPageFrage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFrage.Size = new System.Drawing.Size(767, 254);
            this.tabPageFrage.TabIndex = 0;
            this.tabPageFrage.Text = "Frage";
            this.tabPageFrage.UseVisualStyleBackColor = true;
            // 
            // textBoxTextFrage
            // 
            this.textBoxTextFrage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTextFrage.Location = new System.Drawing.Point(3, 3);
            this.textBoxTextFrage.Multiline = true;
            this.textBoxTextFrage.Name = "textBoxTextFrage";
            this.textBoxTextFrage.Size = new System.Drawing.Size(761, 248);
            this.textBoxTextFrage.TabIndex = 0;
            // 
            // tabPageAntwort
            // 
            this.tabPageAntwort.Controls.Add(this.btnAbbildungSuchen);
            this.tabPageAntwort.Controls.Add(this.txtBoxGrafikSuchen);
            this.tabPageAntwort.Controls.Add(this.Label1);
            this.tabPageAntwort.Controls.Add(this.pictureBoxAntwort);
            this.tabPageAntwort.Location = new System.Drawing.Point(4, 22);
            this.tabPageAntwort.Name = "tabPageAntwort";
            this.tabPageAntwort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAntwort.Size = new System.Drawing.Size(767, 254);
            this.tabPageAntwort.TabIndex = 1;
            this.tabPageAntwort.Text = "Antwort";
            this.tabPageAntwort.UseVisualStyleBackColor = true;
            // 
            // btnAbbildungSuchen
            // 
            this.btnAbbildungSuchen.Location = new System.Drawing.Point(672, 225);
            this.btnAbbildungSuchen.Name = "btnAbbildungSuchen";
            this.btnAbbildungSuchen.Size = new System.Drawing.Size(89, 23);
            this.btnAbbildungSuchen.TabIndex = 3;
            this.btnAbbildungSuchen.Text = "Durchsuchen";
            this.btnAbbildungSuchen.UseVisualStyleBackColor = true;
            this.btnAbbildungSuchen.Click += new System.EventHandler(this.btnAbbildungSuchen_Click);
            // 
            // txtBoxGrafikSuchen
            // 
            this.txtBoxGrafikSuchen.Location = new System.Drawing.Point(88, 227);
            this.txtBoxGrafikSuchen.Name = "txtBoxGrafikSuchen";
            this.txtBoxGrafikSuchen.Size = new System.Drawing.Size(578, 20);
            this.txtBoxGrafikSuchen.TabIndex = 2;
            this.txtBoxGrafikSuchen.Enter += new System.EventHandler(this.txtBoxGrafikSuchen_Leave);
            this.txtBoxGrafikSuchen.Leave += new System.EventHandler(this.txtBoxGrafikSuchen_Leave);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 230);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Grafik suchen:";
            // 
            // pictureBoxAntwort
            // 
            this.pictureBoxAntwort.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxAntwort.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxAntwort.Name = "pictureBoxAntwort";
            this.pictureBoxAntwort.Size = new System.Drawing.Size(761, 216);
            this.pictureBoxAntwort.TabIndex = 0;
            this.pictureBoxAntwort.TabStop = false;
            // 
            // RecordcardAbbildung
            // 
            this.Controls.Add(this.tabControl1);
            this.Name = "RecordcardAbbildung";
            this.Size = new System.Drawing.Size(775, 280);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFrage.ResumeLayout(false);
            this.tabPageFrage.PerformLayout();
            this.tabPageAntwort.ResumeLayout(false);
            this.tabPageAntwort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAntwort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFrage;
        private System.Windows.Forms.TextBox textBoxTextFrage;
        private System.Windows.Forms.TabPage tabPageAntwort;
        private System.Windows.Forms.Button btnAbbildungSuchen;
        private System.Windows.Forms.TextBox txtBoxGrafikSuchen;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBoxAntwort;
    }
}
