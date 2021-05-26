namespace VRC.ViewPlugin
{
    partial class HauptMenu
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
            this.btnKarteikarteErstellen = new System.Windows.Forms.Button();
            this.btnKarteikarteBearbeiten = new System.Windows.Forms.Button();
            this.btnPruefmodus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKarteikarteErstellen
            // 
            this.btnKarteikarteErstellen.Location = new System.Drawing.Point(75, 151);
            this.btnKarteikarteErstellen.Name = "btnKarteikarteErstellen";
            this.btnKarteikarteErstellen.Size = new System.Drawing.Size(660, 72);
            this.btnKarteikarteErstellen.TabIndex = 0;
            this.btnKarteikarteErstellen.Text = "Neue Karteikarten erstellen";
            this.btnKarteikarteErstellen.UseVisualStyleBackColor = true;
            this.btnKarteikarteErstellen.Click += new System.EventHandler(this.btnKarteikarteErstellen_Click);
            // 
            // btnKarteikarteBearbeiten
            // 
            this.btnKarteikarteBearbeiten.Location = new System.Drawing.Point(76, 271);
            this.btnKarteikarteBearbeiten.Name = "btnKarteikarteBearbeiten";
            this.btnKarteikarteBearbeiten.Size = new System.Drawing.Size(663, 72);
            this.btnKarteikarteBearbeiten.TabIndex = 1;
            this.btnKarteikarteBearbeiten.Text = "Karteikarten bearbeiten";
            this.btnKarteikarteBearbeiten.UseVisualStyleBackColor = true;
            this.btnKarteikarteBearbeiten.Click += new System.EventHandler(this.btnKarteikarteBearbeiten_Click);
            // 
            // btnPruefmodus
            // 
            this.btnPruefmodus.Location = new System.Drawing.Point(76, 41);
            this.btnPruefmodus.Name = "btnPruefmodus";
            this.btnPruefmodus.Size = new System.Drawing.Size(660, 78);
            this.btnPruefmodus.TabIndex = 2;
            this.btnPruefmodus.Text = "Prüfmodus";
            this.btnPruefmodus.UseVisualStyleBackColor = true;
            this.btnPruefmodus.Click += new System.EventHandler(this.btnPruefmodus_Click);
            // 
            // HauptMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPruefmodus);
            this.Controls.Add(this.btnKarteikarteBearbeiten);
            this.Controls.Add(this.btnKarteikarteErstellen);
            this.Name = "HauptMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKarteikarteErstellen;
        private System.Windows.Forms.Button btnKarteikarteBearbeiten;
        private System.Windows.Forms.Button btnPruefmodus;
    }
}

