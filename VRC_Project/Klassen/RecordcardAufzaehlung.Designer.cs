
namespace VRC.Klassen
{
    partial class RecordcardAufzaehlung
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
            this.txtBoxTextFrage = new System.Windows.Forms.TextBox();
            this.tabPageAntwort = new System.Windows.Forms.TabPage();
            this.txtBoxAufzaehlungsitem = new System.Windows.Forms.TextBox();
            this.btnAufzaehlungLoeschen = new System.Windows.Forms.Button();
            this.btnAufzaehlungAntwortHinzu = new System.Windows.Forms.Button();
            this.listBoxAntwort = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPageFrage.SuspendLayout();
            this.tabPageAntwort.SuspendLayout();
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
            this.tabPageFrage.Controls.Add(this.txtBoxTextFrage);
            this.tabPageFrage.Location = new System.Drawing.Point(4, 22);
            this.tabPageFrage.Name = "tabPageFrage";
            this.tabPageFrage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFrage.Size = new System.Drawing.Size(767, 254);
            this.tabPageFrage.TabIndex = 0;
            this.tabPageFrage.Text = "Frage";
            this.tabPageFrage.UseVisualStyleBackColor = true;
            // 
            // txtBoxTextFrage
            // 
            this.txtBoxTextFrage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxTextFrage.Location = new System.Drawing.Point(3, 3);
            this.txtBoxTextFrage.Multiline = true;
            this.txtBoxTextFrage.Name = "txtBoxTextFrage";
            this.txtBoxTextFrage.Size = new System.Drawing.Size(761, 248);
            this.txtBoxTextFrage.TabIndex = 0;
            // 
            // tabPageAntwort
            // 
            this.tabPageAntwort.Controls.Add(this.txtBoxAufzaehlungsitem);
            this.tabPageAntwort.Controls.Add(this.btnAufzaehlungLoeschen);
            this.tabPageAntwort.Controls.Add(this.btnAufzaehlungAntwortHinzu);
            this.tabPageAntwort.Controls.Add(this.listBoxAntwort);
            this.tabPageAntwort.Location = new System.Drawing.Point(4, 22);
            this.tabPageAntwort.Name = "tabPageAntwort";
            this.tabPageAntwort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAntwort.Size = new System.Drawing.Size(767, 254);
            this.tabPageAntwort.TabIndex = 1;
            this.tabPageAntwort.Text = "Antwort";
            this.tabPageAntwort.UseVisualStyleBackColor = true;
            // 
            // txtBoxAufzaehlungsitem
            // 
            this.txtBoxAufzaehlungsitem.Location = new System.Drawing.Point(7, 157);
            this.txtBoxAufzaehlungsitem.Multiline = true;
            this.txtBoxAufzaehlungsitem.Name = "txtBoxAufzaehlungsitem";
            this.txtBoxAufzaehlungsitem.Size = new System.Drawing.Size(754, 62);
            this.txtBoxAufzaehlungsitem.TabIndex = 2;
            // 
            // btnAufzaehlungLoeschen
            // 
            this.btnAufzaehlungLoeschen.Location = new System.Drawing.Point(383, 225);
            this.btnAufzaehlungLoeschen.Name = "btnAufzaehlungLoeschen";
            this.btnAufzaehlungLoeschen.Size = new System.Drawing.Size(378, 23);
            this.btnAufzaehlungLoeschen.TabIndex = 1;
            this.btnAufzaehlungLoeschen.Text = "Aufzählungsitem löschen";
            this.btnAufzaehlungLoeschen.UseVisualStyleBackColor = true;
            this.btnAufzaehlungLoeschen.Click += new System.EventHandler(this.btnAufzaehlungLoeschen_Click);
            // 
            // btnAufzaehlungAntwortHinzu
            // 
            this.btnAufzaehlungAntwortHinzu.Location = new System.Drawing.Point(6, 225);
            this.btnAufzaehlungAntwortHinzu.Name = "btnAufzaehlungAntwortHinzu";
            this.btnAufzaehlungAntwortHinzu.Size = new System.Drawing.Size(371, 23);
            this.btnAufzaehlungAntwortHinzu.TabIndex = 1;
            this.btnAufzaehlungAntwortHinzu.Text = "Aufzählungsitem hinzufügen";
            this.btnAufzaehlungAntwortHinzu.UseVisualStyleBackColor = true;
            this.btnAufzaehlungAntwortHinzu.Click += new System.EventHandler(this.btnAufzaehlungAntwortHinzu_Click);
            // 
            // listBoxAntwort
            // 
            this.listBoxAntwort.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxAntwort.FormattingEnabled = true;
            this.listBoxAntwort.Location = new System.Drawing.Point(3, 3);
            this.listBoxAntwort.Name = "listBoxAntwort";
            this.listBoxAntwort.Size = new System.Drawing.Size(761, 147);
            this.listBoxAntwort.TabIndex = 0;
            // 
            // RecordcardAufzaehlung
            // 
            this.Controls.Add(this.tabControl1);
            this.Name = "RecordcardAufzaehlung";
            this.Size = new System.Drawing.Size(775, 280);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFrage.ResumeLayout(false);
            this.tabPageFrage.PerformLayout();
            this.tabPageAntwort.ResumeLayout(false);
            this.tabPageAntwort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFrage;
        private System.Windows.Forms.TabPage tabPageAntwort;
        private System.Windows.Forms.TextBox txtBoxTextFrage;
        private System.Windows.Forms.ListBox listBoxAntwort;
        private System.Windows.Forms.Button btnAufzaehlungLoeschen;
        private System.Windows.Forms.Button btnAufzaehlungAntwortHinzu;
        private System.Windows.Forms.TextBox txtBoxAufzaehlungsitem;
    }
}
