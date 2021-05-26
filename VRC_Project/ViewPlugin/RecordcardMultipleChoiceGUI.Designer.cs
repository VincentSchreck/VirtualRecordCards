namespace VRC.ViewPlugin
{
    partial class RecordcardMultipleChoiceGUI
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
            this.tabControlMC = new System.Windows.Forms.TabControl();
            this.tabPageFrage = new System.Windows.Forms.TabPage();
            this.txtBoxMCAntwortMoeglichkeit = new System.Windows.Forms.TextBox();
            this.btnAntwortLoeschen = new System.Windows.Forms.Button();
            this.btnAntwortHinzufuegen = new System.Windows.Forms.Button();
            this.txtBoxMCFrage = new System.Windows.Forms.TextBox();
            this.checkedListBoxMCFrage = new System.Windows.Forms.CheckedListBox();
            this.tabPageAntwort = new System.Windows.Forms.TabPage();
            this.txtBoxMCAntwort = new System.Windows.Forms.TextBox();
            this.tabControlMC.SuspendLayout();
            this.tabPageFrage.SuspendLayout();
            this.tabPageAntwort.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMC
            // 
            this.tabControlMC.Controls.Add(this.tabPageFrage);
            this.tabControlMC.Controls.Add(this.tabPageAntwort);
            this.tabControlMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMC.Location = new System.Drawing.Point(0, 0);
            this.tabControlMC.Name = "tabControlMC";
            this.tabControlMC.SelectedIndex = 0;
            this.tabControlMC.Size = new System.Drawing.Size(775, 280);
            this.tabControlMC.TabIndex = 0;
            // 
            // tabPageFrage
            // 
            this.tabPageFrage.Controls.Add(this.txtBoxMCAntwortMoeglichkeit);
            this.tabPageFrage.Controls.Add(this.btnAntwortLoeschen);
            this.tabPageFrage.Controls.Add(this.btnAntwortHinzufuegen);
            this.tabPageFrage.Controls.Add(this.txtBoxMCFrage);
            this.tabPageFrage.Controls.Add(this.checkedListBoxMCFrage);
            this.tabPageFrage.Location = new System.Drawing.Point(4, 22);
            this.tabPageFrage.Name = "tabPageFrage";
            this.tabPageFrage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFrage.Size = new System.Drawing.Size(767, 254);
            this.tabPageFrage.TabIndex = 0;
            this.tabPageFrage.Text = "Frage";
            this.tabPageFrage.UseVisualStyleBackColor = true;
            // 
            // txtBoxMCAntwortMoeglichkeit
            // 
            this.txtBoxMCAntwortMoeglichkeit.Location = new System.Drawing.Point(378, 189);
            this.txtBoxMCAntwortMoeglichkeit.Multiline = true;
            this.txtBoxMCAntwortMoeglichkeit.Name = "txtBoxMCAntwortMoeglichkeit";
            this.txtBoxMCAntwortMoeglichkeit.Size = new System.Drawing.Size(383, 59);
            this.txtBoxMCAntwortMoeglichkeit.TabIndex = 4;
            // 
            // btnAntwortLoeschen
            // 
            this.btnAntwortLoeschen.Location = new System.Drawing.Point(3, 225);
            this.btnAntwortLoeschen.Name = "btnAntwortLoeschen";
            this.btnAntwortLoeschen.Size = new System.Drawing.Size(366, 23);
            this.btnAntwortLoeschen.TabIndex = 3;
            this.btnAntwortLoeschen.Text = "Antwortmöglichkeit löschen";
            this.btnAntwortLoeschen.UseVisualStyleBackColor = true;
            this.btnAntwortLoeschen.Click += new System.EventHandler(this.btnAntwortLoeschen_Click);
            // 
            // btnAntwortHinzufuegen
            // 
            this.btnAntwortHinzufuegen.Location = new System.Drawing.Point(3, 189);
            this.btnAntwortHinzufuegen.Name = "btnAntwortHinzufuegen";
            this.btnAntwortHinzufuegen.Size = new System.Drawing.Size(366, 23);
            this.btnAntwortHinzufuegen.TabIndex = 2;
            this.btnAntwortHinzufuegen.Text = "Antwortmöglichkeit hinzufügen";
            this.btnAntwortHinzufuegen.UseVisualStyleBackColor = true;
            this.btnAntwortHinzufuegen.Click += new System.EventHandler(this.btnAntwortHinzufuegen_Click);
            // 
            // txtBoxMCFrage
            // 
            this.txtBoxMCFrage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxMCFrage.Location = new System.Drawing.Point(3, 3);
            this.txtBoxMCFrage.Multiline = true;
            this.txtBoxMCFrage.Name = "txtBoxMCFrage";
            this.txtBoxMCFrage.Size = new System.Drawing.Size(761, 65);
            this.txtBoxMCFrage.TabIndex = 1;
            // 
            // checkedListBoxMCFrage
            // 
            this.checkedListBoxMCFrage.FormattingEnabled = true;
            this.checkedListBoxMCFrage.Location = new System.Drawing.Point(3, 74);
            this.checkedListBoxMCFrage.Name = "checkedListBoxMCFrage";
            this.checkedListBoxMCFrage.Size = new System.Drawing.Size(761, 109);
            this.checkedListBoxMCFrage.TabIndex = 0;
            // 
            // tabPageAntwort
            // 
            this.tabPageAntwort.Controls.Add(this.txtBoxMCAntwort);
            this.tabPageAntwort.Location = new System.Drawing.Point(4, 22);
            this.tabPageAntwort.Name = "tabPageAntwort";
            this.tabPageAntwort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAntwort.Size = new System.Drawing.Size(767, 254);
            this.tabPageAntwort.TabIndex = 1;
            this.tabPageAntwort.Text = "Antwort";
            this.tabPageAntwort.UseVisualStyleBackColor = true;
            // 
            // txtBoxMCAntwort
            // 
            this.txtBoxMCAntwort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxMCAntwort.Location = new System.Drawing.Point(3, 3);
            this.txtBoxMCAntwort.Multiline = true;
            this.txtBoxMCAntwort.Name = "txtBoxMCAntwort";
            this.txtBoxMCAntwort.Size = new System.Drawing.Size(761, 248);
            this.txtBoxMCAntwort.TabIndex = 0;
            // 
            // RecordcardMultipleChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMC);
            this.Name = "RecordcardMultipleChoice";
            this.Size = new System.Drawing.Size(775, 280);
            this.tabControlMC.ResumeLayout(false);
            this.tabPageFrage.ResumeLayout(false);
            this.tabPageFrage.PerformLayout();
            this.tabPageAntwort.ResumeLayout(false);
            this.tabPageAntwort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMC;
        private System.Windows.Forms.TabPage tabPageFrage;
        private System.Windows.Forms.TextBox txtBoxMCFrage;
        private System.Windows.Forms.CheckedListBox checkedListBoxMCFrage;
        private System.Windows.Forms.TabPage tabPageAntwort;
        private System.Windows.Forms.TextBox txtBoxMCAntwort;
        private System.Windows.Forms.Button btnAntwortLoeschen;
        private System.Windows.Forms.Button btnAntwortHinzufuegen;
        private System.Windows.Forms.TextBox txtBoxMCAntwortMoeglichkeit;
    }
}
