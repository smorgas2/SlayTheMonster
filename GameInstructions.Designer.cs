namespace SlayTheMonster
{
    partial class GameInstructions
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
            this.labelHelp = new System.Windows.Forms.Label();
            this.comboBoxHelp = new System.Windows.Forms.ComboBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHelp
            // 
            this.labelHelp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHelp.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.Location = new System.Drawing.Point(182, 9);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(632, 356);
            this.labelHelp.TabIndex = 0;
            this.labelHelp.Text = "label1";
            // 
            // comboBoxHelp
            // 
            this.comboBoxHelp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHelp.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHelp.FormattingEnabled = true;
            this.comboBoxHelp.Location = new System.Drawing.Point(12, 154);
            this.comboBoxHelp.Name = "comboBoxHelp";
            this.comboBoxHelp.Size = new System.Drawing.Size(164, 29);
            this.comboBoxHelp.TabIndex = 1;
            this.comboBoxHelp.SelectedIndexChanged += new System.EventHandler(this.comboBoxHelp_SelectedIndexChanged);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(22, 332);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(136, 32);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "OK";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(826, 376);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.comboBoxHelp);
            this.Controls.Add(this.labelHelp);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.ComboBox comboBoxHelp;
        private System.Windows.Forms.Button buttonHelp;
    }
}