
namespace VRC.Klassen
{
    partial class RecordcardTextGUI
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
            this.txtBoxTextAntwort = new System.Windows.Forms.TextBox();
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
            this.tabPageAntwort.Controls.Add(this.txtBoxTextAntwort);
            this.tabPageAntwort.Location = new System.Drawing.Point(4, 22);
            this.tabPageAntwort.Name = "tabPageAntwort";
            this.tabPageAntwort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAntwort.Size = new System.Drawing.Size(767, 254);
            this.tabPageAntwort.TabIndex = 1;
            this.tabPageAntwort.Text = "Antwort";
            this.tabPageAntwort.UseVisualStyleBackColor = true;
            // 
            // txtBoxTextAntwort
            // 
            this.txtBoxTextAntwort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxTextAntwort.Location = new System.Drawing.Point(3, 3);
            this.txtBoxTextAntwort.Multiline = true;
            this.txtBoxTextAntwort.Name = "txtBoxTextAntwort";
            this.txtBoxTextAntwort.Size = new System.Drawing.Size(761, 248);
            this.txtBoxTextAntwort.TabIndex = 0;
            // 
            // RecordcardText
            // 
            this.Controls.Add(this.tabControl1);
            this.Name = "RecordcardText";
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
        private System.Windows.Forms.TextBox txtBoxTextFrage;
        private System.Windows.Forms.TabPage tabPageAntwort;
        private System.Windows.Forms.TextBox txtBoxTextAntwort;
    }
}
