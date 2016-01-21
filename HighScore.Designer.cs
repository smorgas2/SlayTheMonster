namespace SlayTheMonster
{
    partial class HighScore
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
            this.labelHighScoreMax = new System.Windows.Forms.Label();
            this.textBoxHighScore = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelYourScore = new System.Windows.Forms.Label();
            this.labelYourScoreNr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHighScoreMax
            // 
            this.labelHighScoreMax.AutoSize = true;
            this.labelHighScoreMax.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScoreMax.Location = new System.Drawing.Point(50, 34);
            this.labelHighScoreMax.Name = "labelHighScoreMax";
            this.labelHighScoreMax.Size = new System.Drawing.Size(377, 24);
            this.labelHighScoreMax.TabIndex = 0;
            this.labelHighScoreMax.Text = "Enter your name (max 8 characters)";
            this.labelHighScoreMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHighScore
            // 
            this.textBoxHighScore.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHighScore.Location = new System.Drawing.Point(75, 103);
            this.textBoxHighScore.Name = "textBoxHighScore";
            this.textBoxHighScore.Size = new System.Drawing.Size(325, 32);
            this.textBoxHighScore.TabIndex = 1;
            this.textBoxHighScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(168, 141);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(140, 39);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelYourScore
            // 
            this.labelYourScore.AutoSize = true;
            this.labelYourScore.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourScore.Location = new System.Drawing.Point(111, 70);
            this.labelYourScore.Name = "labelYourScore";
            this.labelYourScore.Size = new System.Drawing.Size(130, 24);
            this.labelYourScore.TabIndex = 3;
            this.labelYourScore.Text = "Your score: ";
            // 
            // labelYourScoreNr
            // 
            this.labelYourScoreNr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelYourScoreNr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourScoreNr.Location = new System.Drawing.Point(240, 71);
            this.labelYourScoreNr.Name = "labelYourScoreNr";
            this.labelYourScoreNr.Size = new System.Drawing.Size(80, 23);
            this.labelYourScoreNr.TabIndex = 4;
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(479, 192);
            this.Controls.Add(this.labelYourScoreNr);
            this.Controls.Add(this.labelYourScore);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxHighScore);
            this.Controls.Add(this.labelHighScoreMax);
            this.Name = "HighScore";
            this.Text = "HighScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHighScoreMax;
        private System.Windows.Forms.TextBox textBoxHighScore;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelYourScore;
        private System.Windows.Forms.Label labelYourScoreNr;
    }
}