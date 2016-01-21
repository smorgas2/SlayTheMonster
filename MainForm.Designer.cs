namespace SlayTheMonster
{
    partial class MainForm
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
            this.groupBoxHealRun = new System.Windows.Forms.GroupBox();
            this.buttonRunAway = new System.Windows.Forms.Button();
            this.buttonHeal = new System.Windows.Forms.Button();
            this.groupBoxAttack = new System.Windows.Forms.GroupBox();
            this.buttonLegs = new System.Windows.Forms.Button();
            this.buttonLeftArm = new System.Windows.Forms.Button();
            this.buttonRightArm = new System.Windows.Forms.Button();
            this.buttonBody = new System.Windows.Forms.Button();
            this.labelBodyText = new System.Windows.Forms.Label();
            this.labelLeftArmText = new System.Windows.Forms.Label();
            this.labelRightArmText = new System.Windows.Forms.Label();
            this.labelLegsText = new System.Windows.Forms.Label();
            this.labelHeroHealthNumber = new System.Windows.Forms.Label();
            this.listBoxHighScore = new System.Windows.Forms.ListBox();
            this.labelCurrentScoreText = new System.Windows.Forms.Label();
            this.labelCrurrentScoreNumber = new System.Windows.Forms.Label();
            this.labelHeroHealthText = new System.Windows.Forms.Label();
            this.groupBoxMonster = new System.Windows.Forms.GroupBox();
            this.pictureBoxMonster = new System.Windows.Forms.PictureBox();
            this.labelLegsNumber = new System.Windows.Forms.Label();
            this.labelRightArmNumber = new System.Windows.Forms.Label();
            this.labelLeftArmNumber = new System.Windows.Forms.Label();
            this.labelBodyNumber = new System.Windows.Forms.Label();
            this.groupBoxHeroStats = new System.Windows.Forms.GroupBox();
            this.labelHealsLeftNumber = new System.Windows.Forms.Label();
            this.labelHealsLeftText = new System.Windows.Forms.Label();
            this.groupBoxHighScore = new System.Windows.Forms.GroupBox();
            this.labelHighScoreList = new System.Windows.Forms.Label();
            this.menuStripGame = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxHealRun.SuspendLayout();
            this.groupBoxAttack.SuspendLayout();
            this.groupBoxMonster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).BeginInit();
            this.groupBoxHeroStats.SuspendLayout();
            this.groupBoxHighScore.SuspendLayout();
            this.menuStripGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHealRun
            // 
            this.groupBoxHealRun.Controls.Add(this.buttonRunAway);
            this.groupBoxHealRun.Controls.Add(this.buttonHeal);
            this.groupBoxHealRun.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHealRun.Location = new System.Drawing.Point(278, 412);
            this.groupBoxHealRun.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxHealRun.Name = "groupBoxHealRun";
            this.groupBoxHealRun.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxHealRun.Size = new System.Drawing.Size(117, 155);
            this.groupBoxHealRun.TabIndex = 1;
            this.groupBoxHealRun.TabStop = false;
            this.groupBoxHealRun.Text = "Heal / Run Away";
            // 
            // buttonRunAway
            // 
            this.buttonRunAway.BackColor = System.Drawing.Color.Plum;
            this.buttonRunAway.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunAway.Location = new System.Drawing.Point(14, 95);
            this.buttonRunAway.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRunAway.Name = "buttonRunAway";
            this.buttonRunAway.Size = new System.Drawing.Size(90, 33);
            this.buttonRunAway.TabIndex = 10;
            this.buttonRunAway.Text = "Run Away";
            this.buttonRunAway.UseVisualStyleBackColor = false;
            this.buttonRunAway.Click += new System.EventHandler(this.buttonRunAway_Click);
            // 
            // buttonHeal
            // 
            this.buttonHeal.BackColor = System.Drawing.Color.LightBlue;
            this.buttonHeal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHeal.Location = new System.Drawing.Point(14, 38);
            this.buttonHeal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHeal.Name = "buttonHeal";
            this.buttonHeal.Size = new System.Drawing.Size(90, 33);
            this.buttonHeal.TabIndex = 9;
            this.buttonHeal.Text = "Heal";
            this.buttonHeal.UseVisualStyleBackColor = false;
            this.buttonHeal.Click += new System.EventHandler(this.buttonHeal_Click);
            // 
            // groupBoxAttack
            // 
            this.groupBoxAttack.Controls.Add(this.buttonLegs);
            this.groupBoxAttack.Controls.Add(this.buttonLeftArm);
            this.groupBoxAttack.Controls.Add(this.buttonRightArm);
            this.groupBoxAttack.Controls.Add(this.buttonBody);
            this.groupBoxAttack.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAttack.Location = new System.Drawing.Point(9, 412);
            this.groupBoxAttack.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAttack.Name = "groupBoxAttack";
            this.groupBoxAttack.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAttack.Size = new System.Drawing.Size(252, 155);
            this.groupBoxAttack.TabIndex = 2;
            this.groupBoxAttack.TabStop = false;
            this.groupBoxAttack.Text = "Attack";
            // 
            // buttonLegs
            // 
            this.buttonLegs.BackColor = System.Drawing.Color.Crimson;
            this.buttonLegs.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLegs.Location = new System.Drawing.Point(81, 114);
            this.buttonLegs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLegs.Name = "buttonLegs";
            this.buttonLegs.Size = new System.Drawing.Size(90, 33);
            this.buttonLegs.TabIndex = 3;
            this.buttonLegs.Text = "Legs";
            this.buttonLegs.UseVisualStyleBackColor = false;
            this.buttonLegs.Click += new System.EventHandler(this.buttonLegs_Click);
            // 
            // buttonLeftArm
            // 
            this.buttonLeftArm.BackColor = System.Drawing.Color.Crimson;
            this.buttonLeftArm.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeftArm.Location = new System.Drawing.Point(23, 67);
            this.buttonLeftArm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLeftArm.Name = "buttonLeftArm";
            this.buttonLeftArm.Size = new System.Drawing.Size(90, 33);
            this.buttonLeftArm.TabIndex = 2;
            this.buttonLeftArm.Text = "Left Arm";
            this.buttonLeftArm.UseVisualStyleBackColor = false;
            this.buttonLeftArm.Click += new System.EventHandler(this.buttonRightArm_Click);
            // 
            // buttonRightArm
            // 
            this.buttonRightArm.BackColor = System.Drawing.Color.Crimson;
            this.buttonRightArm.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRightArm.Location = new System.Drawing.Point(140, 67);
            this.buttonRightArm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRightArm.Name = "buttonRightArm";
            this.buttonRightArm.Size = new System.Drawing.Size(90, 33);
            this.buttonRightArm.TabIndex = 1;
            this.buttonRightArm.Text = "Right Arm";
            this.buttonRightArm.UseVisualStyleBackColor = false;
            this.buttonRightArm.Click += new System.EventHandler(this.buttonLeftArm_Click);
            // 
            // buttonBody
            // 
            this.buttonBody.BackColor = System.Drawing.Color.Crimson;
            this.buttonBody.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBody.Location = new System.Drawing.Point(81, 21);
            this.buttonBody.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBody.Name = "buttonBody";
            this.buttonBody.Size = new System.Drawing.Size(90, 33);
            this.buttonBody.TabIndex = 0;
            this.buttonBody.Text = "Body";
            this.buttonBody.UseVisualStyleBackColor = false;
            this.buttonBody.Click += new System.EventHandler(this.buttonBody_Click);
            // 
            // labelBodyText
            // 
            this.labelBodyText.AutoSize = true;
            this.labelBodyText.Location = new System.Drawing.Point(184, 20);
            this.labelBodyText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBodyText.Name = "labelBodyText";
            this.labelBodyText.Size = new System.Drawing.Size(35, 13);
            this.labelBodyText.TabIndex = 4;
            this.labelBodyText.Text = "Body";
            // 
            // labelLeftArmText
            // 
            this.labelLeftArmText.AutoSize = true;
            this.labelLeftArmText.Location = new System.Drawing.Point(12, 167);
            this.labelLeftArmText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLeftArmText.Name = "labelLeftArmText";
            this.labelLeftArmText.Size = new System.Drawing.Size(56, 13);
            this.labelLeftArmText.TabIndex = 5;
            this.labelLeftArmText.Text = "Left Arm";
            // 
            // labelRightArmText
            // 
            this.labelRightArmText.AutoSize = true;
            this.labelRightArmText.Location = new System.Drawing.Point(320, 167);
            this.labelRightArmText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRightArmText.Name = "labelRightArmText";
            this.labelRightArmText.Size = new System.Drawing.Size(64, 13);
            this.labelRightArmText.TabIndex = 6;
            this.labelRightArmText.Text = "Right Arm";
            // 
            // labelLegsText
            // 
            this.labelLegsText.AutoSize = true;
            this.labelLegsText.Location = new System.Drawing.Point(182, 306);
            this.labelLegsText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLegsText.Name = "labelLegsText";
            this.labelLegsText.Size = new System.Drawing.Size(33, 13);
            this.labelLegsText.TabIndex = 7;
            this.labelLegsText.Text = "Legs";
            // 
            // labelHeroHealthNumber
            // 
            this.labelHeroHealthNumber.BackColor = System.Drawing.Color.Silver;
            this.labelHeroHealthNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHeroHealthNumber.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeroHealthNumber.Location = new System.Drawing.Point(56, 44);
            this.labelHeroHealthNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeroHealthNumber.Name = "labelHeroHealthNumber";
            this.labelHeroHealthNumber.Size = new System.Drawing.Size(52, 28);
            this.labelHeroHealthNumber.TabIndex = 8;
            this.labelHeroHealthNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxHighScore
            // 
            this.listBoxHighScore.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHighScore.FormattingEnabled = true;
            this.listBoxHighScore.ItemHeight = 12;
            this.listBoxHighScore.Location = new System.Drawing.Point(26, 18);
            this.listBoxHighScore.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxHighScore.Name = "listBoxHighScore";
            this.listBoxHighScore.Size = new System.Drawing.Size(134, 244);
            this.listBoxHighScore.TabIndex = 12;
            // 
            // labelCurrentScoreText
            // 
            this.labelCurrentScoreText.AutoSize = true;
            this.labelCurrentScoreText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentScoreText.Location = new System.Drawing.Point(34, 292);
            this.labelCurrentScoreText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentScoreText.Name = "labelCurrentScoreText";
            this.labelCurrentScoreText.Size = new System.Drawing.Size(105, 17);
            this.labelCurrentScoreText.TabIndex = 13;
            this.labelCurrentScoreText.Text = "Current Score";
            // 
            // labelCrurrentScoreNumber
            // 
            this.labelCrurrentScoreNumber.BackColor = System.Drawing.Color.Silver;
            this.labelCrurrentScoreNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCrurrentScoreNumber.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrurrentScoreNumber.Location = new System.Drawing.Point(26, 313);
            this.labelCrurrentScoreNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCrurrentScoreNumber.Name = "labelCrurrentScoreNumber";
            this.labelCrurrentScoreNumber.Size = new System.Drawing.Size(112, 28);
            this.labelCrurrentScoreNumber.TabIndex = 14;
            this.labelCrurrentScoreNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeroHealthText
            // 
            this.labelHeroHealthText.AutoSize = true;
            this.labelHeroHealthText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeroHealthText.Location = new System.Drawing.Point(40, 22);
            this.labelHeroHealthText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeroHealthText.Name = "labelHeroHealthText";
            this.labelHeroHealthText.Size = new System.Drawing.Size(91, 17);
            this.labelHeroHealthText.TabIndex = 15;
            this.labelHeroHealthText.Text = "Hero Health";
            // 
            // groupBoxMonster
            // 
            this.groupBoxMonster.Controls.Add(this.pictureBoxMonster);
            this.groupBoxMonster.Controls.Add(this.labelLegsNumber);
            this.groupBoxMonster.Controls.Add(this.labelRightArmNumber);
            this.groupBoxMonster.Controls.Add(this.labelLeftArmNumber);
            this.groupBoxMonster.Controls.Add(this.labelBodyNumber);
            this.groupBoxMonster.Controls.Add(this.labelLeftArmText);
            this.groupBoxMonster.Controls.Add(this.labelBodyText);
            this.groupBoxMonster.Controls.Add(this.labelRightArmText);
            this.groupBoxMonster.Controls.Add(this.labelLegsText);
            this.groupBoxMonster.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMonster.Location = new System.Drawing.Point(9, 32);
            this.groupBoxMonster.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMonster.Name = "groupBoxMonster";
            this.groupBoxMonster.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMonster.Size = new System.Drawing.Size(386, 366);
            this.groupBoxMonster.TabIndex = 16;
            this.groupBoxMonster.TabStop = false;
            this.groupBoxMonster.Text = "The Monster";
            // 
            // pictureBoxMonster
            // 
            this.pictureBoxMonster.Image = global::SlayTheMonster.Properties.Resources.MonsterNormal;
            this.pictureBoxMonster.Location = new System.Drawing.Point(98, 85);
            this.pictureBoxMonster.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMonster.Name = "pictureBoxMonster";
            this.pictureBoxMonster.Size = new System.Drawing.Size(218, 218);
            this.pictureBoxMonster.TabIndex = 12;
            this.pictureBoxMonster.TabStop = false;
            // 
            // labelLegsNumber
            // 
            this.labelLegsNumber.BackColor = System.Drawing.Color.Silver;
            this.labelLegsNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLegsNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegsNumber.Location = new System.Drawing.Point(180, 332);
            this.labelLegsNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLegsNumber.Name = "labelLegsNumber";
            this.labelLegsNumber.Size = new System.Drawing.Size(38, 20);
            this.labelLegsNumber.TabIndex = 11;
            this.labelLegsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRightArmNumber
            // 
            this.labelRightArmNumber.BackColor = System.Drawing.Color.Silver;
            this.labelRightArmNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRightArmNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRightArmNumber.Location = new System.Drawing.Point(331, 189);
            this.labelRightArmNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRightArmNumber.Name = "labelRightArmNumber";
            this.labelRightArmNumber.Size = new System.Drawing.Size(38, 20);
            this.labelRightArmNumber.TabIndex = 10;
            this.labelRightArmNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLeftArmNumber
            // 
            this.labelLeftArmNumber.BackColor = System.Drawing.Color.Silver;
            this.labelLeftArmNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLeftArmNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeftArmNumber.Location = new System.Drawing.Point(19, 189);
            this.labelLeftArmNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLeftArmNumber.Name = "labelLeftArmNumber";
            this.labelLeftArmNumber.Size = new System.Drawing.Size(38, 20);
            this.labelLeftArmNumber.TabIndex = 9;
            this.labelLeftArmNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBodyNumber
            // 
            this.labelBodyNumber.BackColor = System.Drawing.Color.Silver;
            this.labelBodyNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBodyNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBodyNumber.Location = new System.Drawing.Point(182, 41);
            this.labelBodyNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBodyNumber.Name = "labelBodyNumber";
            this.labelBodyNumber.Size = new System.Drawing.Size(38, 20);
            this.labelBodyNumber.TabIndex = 8;
            this.labelBodyNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxHeroStats
            // 
            this.groupBoxHeroStats.Controls.Add(this.labelHealsLeftNumber);
            this.groupBoxHeroStats.Controls.Add(this.labelHealsLeftText);
            this.groupBoxHeroStats.Controls.Add(this.labelHeroHealthText);
            this.groupBoxHeroStats.Controls.Add(this.labelHeroHealthNumber);
            this.groupBoxHeroStats.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHeroStats.Location = new System.Drawing.Point(412, 412);
            this.groupBoxHeroStats.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxHeroStats.Name = "groupBoxHeroStats";
            this.groupBoxHeroStats.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxHeroStats.Size = new System.Drawing.Size(164, 155);
            this.groupBoxHeroStats.TabIndex = 17;
            this.groupBoxHeroStats.TabStop = false;
            this.groupBoxHeroStats.Text = "Hero Stats";
            // 
            // labelHealsLeftNumber
            // 
            this.labelHealsLeftNumber.BackColor = System.Drawing.Color.Silver;
            this.labelHealsLeftNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHealsLeftNumber.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealsLeftNumber.Location = new System.Drawing.Point(56, 115);
            this.labelHealsLeftNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHealsLeftNumber.Name = "labelHealsLeftNumber";
            this.labelHealsLeftNumber.Size = new System.Drawing.Size(52, 28);
            this.labelHealsLeftNumber.TabIndex = 17;
            this.labelHealsLeftNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHealsLeftText
            // 
            this.labelHealsLeftText.AutoSize = true;
            this.labelHealsLeftText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealsLeftText.Location = new System.Drawing.Point(12, 93);
            this.labelHealsLeftText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHealsLeftText.Name = "labelHealsLeftText";
            this.labelHealsLeftText.Size = new System.Drawing.Size(149, 17);
            this.labelHealsLeftText.TabIndex = 16;
            this.labelHealsLeftText.Text = "Number of Heals left";
            // 
            // groupBoxHighScore
            // 
            this.groupBoxHighScore.Controls.Add(this.labelHighScoreList);
            this.groupBoxHighScore.Controls.Add(this.listBoxHighScore);
            this.groupBoxHighScore.Controls.Add(this.labelCrurrentScoreNumber);
            this.groupBoxHighScore.Controls.Add(this.labelCurrentScoreText);
            this.groupBoxHighScore.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHighScore.Location = new System.Drawing.Point(412, 32);
            this.groupBoxHighScore.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxHighScore.Name = "groupBoxHighScore";
            this.groupBoxHighScore.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxHighScore.Size = new System.Drawing.Size(164, 366);
            this.groupBoxHighScore.TabIndex = 18;
            this.groupBoxHighScore.TabStop = false;
            this.groupBoxHighScore.Text = "Highscore";
            // 
            // labelHighScoreList
            // 
            this.labelHighScoreList.AutoSize = true;
            this.labelHighScoreList.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScoreList.Location = new System.Drawing.Point(4, 18);
            this.labelHighScoreList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHighScoreList.Name = "labelHighScoreList";
            this.labelHighScoreList.Size = new System.Drawing.Size(19, 240);
            this.labelHighScoreList.TabIndex = 15;
            this.labelHighScoreList.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n11\r\n12\r\n13\r\n14\r\n15\r\n16\r\n17\r\n18\r\n19\r\n20";
            this.labelHighScoreList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStripGame
            // 
            this.menuStripGame.BackColor = System.Drawing.Color.White;
            this.menuStripGame.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripGame.Location = new System.Drawing.Point(0, 0);
            this.menuStripGame.Name = "menuStripGame";
            this.menuStripGame.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripGame.Size = new System.Drawing.Size(586, 24);
            this.menuStripGame.TabIndex = 19;
            this.menuStripGame.Text = "menuStripGame";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameInstructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gameInstructionsToolStripMenuItem
            // 
            this.gameInstructionsToolStripMenuItem.Name = "gameInstructionsToolStripMenuItem";
            this.gameInstructionsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gameInstructionsToolStripMenuItem.Text = "Game instructions";
            this.gameInstructionsToolStripMenuItem.Click += new System.EventHandler(this.gameInstructionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(586, 577);
            this.Controls.Add(this.groupBoxHighScore);
            this.Controls.Add(this.groupBoxHeroStats);
            this.Controls.Add(this.groupBoxMonster);
            this.Controls.Add(this.groupBoxAttack);
            this.Controls.Add(this.groupBoxHealRun);
            this.Controls.Add(this.menuStripGame);
            this.MainMenuStrip = this.menuStripGame;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Slay The Monster";
            this.groupBoxHealRun.ResumeLayout(false);
            this.groupBoxAttack.ResumeLayout(false);
            this.groupBoxMonster.ResumeLayout(false);
            this.groupBoxMonster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).EndInit();
            this.groupBoxHeroStats.ResumeLayout(false);
            this.groupBoxHeroStats.PerformLayout();
            this.groupBoxHighScore.ResumeLayout(false);
            this.groupBoxHighScore.PerformLayout();
            this.menuStripGame.ResumeLayout(false);
            this.menuStripGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHealRun;
        private System.Windows.Forms.Button buttonRunAway;
        private System.Windows.Forms.Button buttonHeal;
        private System.Windows.Forms.GroupBox groupBoxAttack;
        private System.Windows.Forms.Button buttonLegs;
        private System.Windows.Forms.Button buttonLeftArm;
        private System.Windows.Forms.Button buttonRightArm;
        private System.Windows.Forms.Button buttonBody;
        private System.Windows.Forms.Label labelBodyText;
        private System.Windows.Forms.Label labelLeftArmText;
        private System.Windows.Forms.Label labelRightArmText;
        private System.Windows.Forms.Label labelLegsText;
        private System.Windows.Forms.Label labelHeroHealthNumber;
        private System.Windows.Forms.ListBox listBoxHighScore;
        private System.Windows.Forms.Label labelCurrentScoreText;
        private System.Windows.Forms.Label labelCrurrentScoreNumber;
        private System.Windows.Forms.Label labelHeroHealthText;
        private System.Windows.Forms.GroupBox groupBoxMonster;
        private System.Windows.Forms.GroupBox groupBoxHeroStats;
        private System.Windows.Forms.Label labelHealsLeftNumber;
        private System.Windows.Forms.Label labelHealsLeftText;
        private System.Windows.Forms.Label labelLegsNumber;
        private System.Windows.Forms.Label labelRightArmNumber;
        private System.Windows.Forms.Label labelLeftArmNumber;
        private System.Windows.Forms.Label labelBodyNumber;
        private System.Windows.Forms.GroupBox groupBoxHighScore;
        private System.Windows.Forms.MenuStrip menuStripGame;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameInstructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelHighScoreList;
        private System.Windows.Forms.PictureBox pictureBoxMonster;
    }
}

