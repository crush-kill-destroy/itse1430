namespace CharacterCreator.Winforms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._msMenu = new System.Windows.Forms.MenuStrip();
            this._miFile = new System.Windows.Forms.ToolStripMenuItem();
            this._miExit = new System.Windows.Forms.ToolStripMenuItem();
            this._comboRace = new System.Windows.Forms.ComboBox();
            this._comboProf = new System.Windows.Forms.ComboBox();
            this._labBrawn = new System.Windows.Forms.Label();
            this._labLuck = new System.Windows.Forms.Label();
            this._labMoxie = new System.Windows.Forms.Label();
            this._labWealth = new System.Windows.Forms.Label();
            this._labJnsq = new System.Windows.Forms.Label();
            this._labEgo = new System.Windows.Forms.Label();
            this._labStandStat1 = new System.Windows.Forms.Label();
            this._labBrainsStat = new System.Windows.Forms.Label();
            this._txtBrawn = new System.Windows.Forms.TextBox();
            this._labIntel = new System.Windows.Forms.Label();
            this._txtWealth = new System.Windows.Forms.TextBox();
            this._txtBrains = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this._labProf = new System.Windows.Forms.Label();
            this._labRace = new System.Windows.Forms.Label();
            this._msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _msMenu
            // 
            this._msMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFile});
            this._msMenu.Location = new System.Drawing.Point(0, 0);
            this._msMenu.Name = "_msMenu";
            this._msMenu.Size = new System.Drawing.Size(482, 33);
            this._msMenu.TabIndex = 0;
            this._msMenu.Text = "Menu";
            this._msMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // _miFile
            // 
            this._miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miExit});
            this._miFile.Name = "_miFile";
            this._miFile.Size = new System.Drawing.Size(54, 29);
            this._miFile.Text = "&File";
            // 
            // _miExit
            // 
            this._miExit.Name = "_miExit";
            this._miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this._miExit.Size = new System.Drawing.Size(206, 34);
            this._miExit.Text = "Exit";
            // 
            // _comboRace
            // 
            this._comboRace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._comboRace.FormattingEnabled = true;
            this._comboRace.Items.AddRange(new object[] {
            "Compiler Error",
            "Anthropomorphic Washing MachineHAHAHAMADEYOUSCROLL",
            "Floating Orb Of Eyes",
            "Mass Hallucination",
            "Killer Klown",
            "Cotton Candy Creature",
            "Sentient Lollipop"});
            this._comboRace.Location = new System.Drawing.Point(108, 319);
            this._comboRace.Name = "_comboRace";
            this._comboRace.Size = new System.Drawing.Size(177, 33);
            this._comboRace.TabIndex = 1;
            this._comboRace.Text = "race";
            // 
            // _comboProf
            // 
            this._comboProf.FormattingEnabled = true;
            this._comboProf.Items.AddRange(new object[] {
            "Chainsaw Paladin",
            "90\'S Boy Band Dream Boat",
            "Necromancerphiliac",
            "Mime",
            "Philosophy Major",
            "Murder Hobo",
            "Catholic Priest",
            "Merry Prankster",
            "Weaboo",
            "Rent Boy"});
            this._comboProf.Location = new System.Drawing.Point(108, 280);
            this._comboProf.Name = "_comboProf";
            this._comboProf.Size = new System.Drawing.Size(177, 33);
            this._comboProf.TabIndex = 2;
            this._comboProf.Text = "profession";
            // 
            // _labBrawn
            // 
            this._labBrawn.AutoSize = true;
            this._labBrawn.Location = new System.Drawing.Point(10, 57);
            this._labBrawn.Name = "_labBrawn";
            this._labBrawn.Size = new System.Drawing.Size(60, 25);
            this._labBrawn.TabIndex = 3;
            this._labBrawn.Text = "Brawn";
            this._labBrawn.Click += new System.EventHandler(this.label1_Click);
            // 
            // _labLuck
            // 
            this._labLuck.AutoSize = true;
            this._labLuck.Location = new System.Drawing.Point(225, 57);
            this._labLuck.Name = "_labLuck";
            this._labLuck.Size = new System.Drawing.Size(47, 25);
            this._labLuck.TabIndex = 3;
            this._labLuck.Text = "Luck";
            // 
            // _labMoxie
            // 
            this._labMoxie.AutoSize = true;
            this._labMoxie.Location = new System.Drawing.Point(165, 57);
            this._labMoxie.Name = "_labMoxie";
            this._labMoxie.Size = new System.Drawing.Size(60, 25);
            this._labMoxie.TabIndex = 3;
            this._labMoxie.Text = "Moxie";
            // 
            // _labWealth
            // 
            this._labWealth.AutoSize = true;
            this._labWealth.Location = new System.Drawing.Point(88, 57);
            this._labWealth.Name = "_labWealth";
            this._labWealth.Size = new System.Drawing.Size(66, 25);
            this._labWealth.TabIndex = 3;
            this._labWealth.Text = "Wealth";
            // 
            // _labJnsq
            // 
            this._labJnsq.AutoSize = true;
            this._labJnsq.Location = new System.Drawing.Point(138, 138);
            this._labJnsq.Name = "_labJnsq";
            this._labJnsq.Size = new System.Drawing.Size(134, 25);
            this._labJnsq.TabIndex = 3;
            this._labJnsq.Text = "Je Ne Sais Quoi";
            this._labJnsq.Click += new System.EventHandler(this._labJnsq_Click);
            // 
            // _labEgo
            // 
            this._labEgo.AutoSize = true;
            this._labEgo.Location = new System.Drawing.Point(14, 138);
            this._labEgo.Name = "_labEgo";
            this._labEgo.Size = new System.Drawing.Size(43, 25);
            this._labEgo.TabIndex = 3;
            this._labEgo.Text = "Ego";
            // 
            // _labStandStat1
            // 
            this._labStandStat1.AutoSize = true;
            this._labStandStat1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labStandStat1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._labStandStat1.Location = new System.Drawing.Point(120, 119);
            this._labStandStat1.Name = "_labStandStat1";
            this._labStandStat1.Size = new System.Drawing.Size(63, 19);
            this._labStandStat1.TabIndex = 4;
            this._labStandStat1.Text = "(1-1000)";
            this._labStandStat1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // _labBrainsStat
            // 
            this._labBrainsStat.AutoSize = true;
            this._labBrainsStat.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labBrainsStat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._labBrainsStat.Location = new System.Drawing.Point(66, 236);
            this._labBrainsStat.Name = "_labBrainsStat";
            this._labBrainsStat.Size = new System.Drawing.Size(165, 19);
            this._labBrainsStat.TabIndex = 4;
            this._labBrainsStat.Text = "(-2,000,000,000 to 1000)";
            this._labBrainsStat.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // _txtBrawn
            // 
            this._txtBrawn.Location = new System.Drawing.Point(14, 85);
            this._txtBrawn.Name = "_txtBrawn";
            this._txtBrawn.Size = new System.Drawing.Size(60, 31);
            this._txtBrawn.TabIndex = 5;
            // 
            // _labIntel
            // 
            this._labIntel.AutoSize = true;
            this._labIntel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labIntel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._labIntel.Location = new System.Drawing.Point(14, 258);
            this._labIntel.Name = "_labIntel";
            this._labIntel.Size = new System.Drawing.Size(260, 19);
            this._labIntel.TabIndex = 4;
            this._labIntel.Text = "Intelligence goes far. Stupidity is limitless.";
            this._labIntel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // _txtWealth
            // 
            this._txtWealth.Location = new System.Drawing.Point(92, 85);
            this._txtWealth.Name = "_txtWealth";
            this._txtWealth.Size = new System.Drawing.Size(60, 31);
            this._txtWealth.TabIndex = 5;
            // 
            // _txtBrains
            // 
            this._txtBrains.AutoSize = true;
            this._txtBrains.Location = new System.Drawing.Point(14, 204);
            this._txtBrains.Name = "_txtBrains";
            this._txtBrains.Size = new System.Drawing.Size(59, 25);
            this._txtBrains.TabIndex = 3;
            this._txtBrains.Text = "Brains";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 31);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 31);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 31);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(14, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 31);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(82, 201);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 31);
            this.textBox5.TabIndex = 5;
            // 
            // _labProf
            // 
            this._labProf.AutoSize = true;
            this._labProf.Location = new System.Drawing.Point(10, 288);
            this._labProf.Name = "_labProf";
            this._labProf.Size = new System.Drawing.Size(95, 25);
            this._labProf.TabIndex = 3;
            this._labProf.Text = "Profession";
            // 
            // _labRace
            // 
            this._labRace.AutoSize = true;
            this._labRace.Location = new System.Drawing.Point(14, 319);
            this._labRace.Name = "_labRace";
            this._labRace.Size = new System.Drawing.Size(49, 25);
            this._labRace.TabIndex = 3;
            this._labRace.Text = "Race";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 394);
            this.Controls.Add(this._labRace);
            this.Controls.Add(this._labProf);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._txtBrains);
            this.Controls.Add(this._txtWealth);
            this.Controls.Add(this._labIntel);
            this.Controls.Add(this._txtBrawn);
            this.Controls.Add(this._labBrainsStat);
            this.Controls.Add(this._labStandStat1);
            this.Controls.Add(this._labEgo);
            this.Controls.Add(this._labJnsq);
            this.Controls.Add(this._labWealth);
            this.Controls.Add(this._labMoxie);
            this.Controls.Add(this._labLuck);
            this.Controls.Add(this._labBrawn);
            this.Controls.Add(this._comboProf);
            this.Controls.Add(this._comboRace);
            this.Controls.Add(this._msMenu);
            this.MainMenuStrip = this._msMenu;
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creator";
            this._msMenu.ResumeLayout(false);
            this._msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _msMenu;
        private System.Windows.Forms.ToolStripMenuItem _miFile;
        private System.Windows.Forms.ToolStripMenuItem _miExit;
        private System.Windows.Forms.ComboBox _comboRace;
        private System.Windows.Forms.ComboBox _comboProf;
        private System.Windows.Forms.Label _labBrawn;
        private System.Windows.Forms.Label _labLuck;
        private System.Windows.Forms.Label _labMoxie;
        private System.Windows.Forms.Label _labWealth;
        private System.Windows.Forms.Label _labJnsq;
        private System.Windows.Forms.Label _labEgo;
        private System.Windows.Forms.Label _labStandStat1;
        private System.Windows.Forms.Label _labBrainsStat;
        private System.Windows.Forms.TextBox _txtBrawn;
        private System.Windows.Forms.Label _labIntel;
        private System.Windows.Forms.TextBox _txtWealth;
        private System.Windows.Forms.Label _txtBrains;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label _labProf;
        private System.Windows.Forms.Label _labRace;
    }
}

