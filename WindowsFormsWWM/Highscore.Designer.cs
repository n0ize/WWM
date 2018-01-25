namespace WindowsFormsWWM
{
    partial class Highscore
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
            this.labelHighscore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxHighscore = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelHighscore
            // 
            this.labelHighscore.AutoSize = true;
            this.labelHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighscore.Location = new System.Drawing.Point(90, 19);
            this.labelHighscore.Name = "labelHighscore";
            this.labelHighscore.Size = new System.Drawing.Size(171, 39);
            this.labelHighscore.TabIndex = 0;
            this.labelHighscore.Text = "Highscore";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Die Highscore Liste aller Teilnehmer";
            // 
            // listBoxHighscore
            // 
            this.listBoxHighscore.BackColor = System.Drawing.Color.RoyalBlue;
            this.listBoxHighscore.FormattingEnabled = true;
            this.listBoxHighscore.Location = new System.Drawing.Point(92, 91);
            this.listBoxHighscore.Name = "listBoxHighscore";
            this.listBoxHighscore.Size = new System.Drawing.Size(639, 368);
            this.listBoxHighscore.TabIndex = 2;
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(797, 519);
            this.Controls.Add(this.listBoxHighscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHighscore);
            this.Name = "Highscore";
            this.Text = "Highscore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHighscore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxHighscore;
    }
}