namespace WindowsFormsWWM
{
    partial class StartGUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSpielStart = new System.Windows.Forms.Button();
            this.buttonHighscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSpielStart
            // 
            this.buttonSpielStart.Location = new System.Drawing.Point(366, 377);
            this.buttonSpielStart.Name = "buttonSpielStart";
            this.buttonSpielStart.Size = new System.Drawing.Size(283, 51);
            this.buttonSpielStart.TabIndex = 0;
            this.buttonSpielStart.Text = "Spielen";
            this.buttonSpielStart.UseVisualStyleBackColor = true;
            // 
            // buttonHighscore
            // 
            this.buttonHighscore.Location = new System.Drawing.Point(366, 456);
            this.buttonHighscore.Name = "buttonHighscore";
            this.buttonHighscore.Size = new System.Drawing.Size(281, 57);
            this.buttonHighscore.TabIndex = 2;
            this.buttonHighscore.Text = "Highscore";
            this.buttonHighscore.UseVisualStyleBackColor = true;
            this.buttonHighscore.Click += new System.EventHandler(this.buttonHighscore_Click);
            // 
            // StartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(994, 591);
            this.Controls.Add(this.buttonHighscore);
            this.Controls.Add(this.buttonSpielStart);
            this.Name = "StartGUI";
            this.Text = "Who Wants To Be A Millionaire ?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSpielStart;
        private System.Windows.Forms.Button buttonHighscore;
    }
}

