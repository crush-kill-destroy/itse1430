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
            this._labBrainsStat = new System.Windows.Forms.Label();
            this._txtBrawn = new System.Windows.Forms.TextBox();
            this._labIntel = new System.Windows.Forms.Label();
            this._txtWealth = new System.Windows.Forms.TextBox();
            this._labBrains = new System.Windows.Forms.Label();
            this._txtLuck = new System.Windows.Forms.TextBox();
            this._txtMoxie = new System.Windows.Forms.TextBox();
            this._txtBrains = new System.Windows.Forms.TextBox();
            this._labProf = new System.Windows.Forms.Label();
            this._labRace = new System.Windows.Forms.Label();
            this._labName = new System.Windows.Forms.Label();
            this._txtDesc = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._richDescription = new System.Windows.Forms.RichTextBox();
            this._miCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.NewCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this._msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _msMenu
            // 
            this._msMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFile,
            this._miCharacter});
            this._msMenu.Location = new System.Drawing.Point(0, 0);
            this._msMenu.Name = "_msMenu";
            this._msMenu.Size = new System.Drawing.Size(278, 33);
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
            this._comboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboRace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._comboRace.FormattingEnabled = true;
            this._comboRace.Items.AddRange(new object[] {
            "Compiler Error",
            "Washing Machine",
            "Floating Orb Of Eyes",
            "Mass Hallucination",
            "Killer Clown",
            "Sentient Lollipop",
            "Anthropomorphic Cat"});
            this._comboRace.Location = new System.Drawing.Point(59, 353);
            this._comboRace.Name = "_comboRace";
            this._comboRace.Size = new System.Drawing.Size(212, 33);
            this._comboRace.TabIndex = 1;
            // 
            // _comboProf
            // 
            this._comboProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboProf.FormattingEnabled = true;
            this._comboProf.Items.AddRange(new object[] {
            "Chainsaw Paladin",
            "90\'S Boy Band",
            "Necromancerphiliac",
            "Mime",
            "Philosophy Major",
            "Murder Hobo",
            "Catholic Priest",
            "Merry Prankster",
            "Weaboo",
            "Rent Boy"});
            this._comboProf.Location = new System.Drawing.Point(59, 314);
            this._comboProf.Name = "_comboProf";
            this._comboProf.Size = new System.Drawing.Size(212, 33);
            this._comboProf.TabIndex = 2;
            // 
            // _labBrawn
            // 
            this._labBrawn.AutoSize = true;
            this._labBrawn.Location = new System.Drawing.Point(139, 36);
            this._labBrawn.Name = "_labBrawn";
            this._labBrawn.Size = new System.Drawing.Size(60, 25);
            this._labBrawn.TabIndex = 3;
            this._labBrawn.Text = "Brawn";
            this._labBrawn.Click += new System.EventHandler(this.label1_Click);
            // 
            // _labLuck
            // 
            this._labLuck.AutoSize = true;
            this._labLuck.Location = new System.Drawing.Point(207, 159);
            this._labLuck.Name = "_labLuck";
            this._labLuck.Size = new System.Drawing.Size(47, 25);
            this._labLuck.TabIndex = 3;
            this._labLuck.Text = "Luck";
            // 
            // _labMoxie
            // 
            this._labMoxie.AutoSize = true;
            this._labMoxie.Location = new System.Drawing.Point(209, 36);
            this._labMoxie.Name = "_labMoxie";
            this._labMoxie.Size = new System.Drawing.Size(60, 25);
            this._labMoxie.TabIndex = 3;
            this._labMoxie.Text = "Moxie";
            // 
            // _labWealth
            // 
            this._labWealth.AutoSize = true;
            this._labWealth.Location = new System.Drawing.Point(206, 95);
            this._labWealth.Name = "_labWealth";
            this._labWealth.Size = new System.Drawing.Size(66, 25);
            this._labWealth.TabIndex = 3;
            this._labWealth.Text = "Wealth";
            // 
            // _labBrainsStat
            // 
            this._labBrainsStat.AutoSize = true;
            this._labBrainsStat.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labBrainsStat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._labBrainsStat.Location = new System.Drawing.Point(53, 266);
            this._labBrainsStat.Name = "_labBrainsStat";
            this._labBrainsStat.Size = new System.Drawing.Size(157, 19);
            this._labBrainsStat.TabIndex = 4;
            this._labBrainsStat.Text = "(-2,000,000,000 to 100)";
            this._labBrainsStat.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // _txtBrawn
            // 
            this._txtBrawn.Location = new System.Drawing.Point(144, 64);
            this._txtBrawn.Name = "_txtBrawn";
            this._txtBrawn.Size = new System.Drawing.Size(60, 31);
            this._txtBrawn.TabIndex = 5;
            this._txtBrawn.Text = "1";
            // 
            // _labIntel
            // 
            this._labIntel.AutoSize = true;
            this._labIntel.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labIntel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._labIntel.Location = new System.Drawing.Point(14, 288);
            this._labIntel.Name = "_labIntel";
            this._labIntel.Size = new System.Drawing.Size(250, 15);
            this._labIntel.TabIndex = 4;
            this._labIntel.Text = "Intelligence can go far. Stupidity has no limits.";
            this._labIntel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // _txtWealth
            // 
            this._txtWealth.Location = new System.Drawing.Point(210, 123);
            this._txtWealth.Name = "_txtWealth";
            this._txtWealth.Size = new System.Drawing.Size(60, 31);
            this._txtWealth.TabIndex = 5;
            this._txtWealth.Text = "1";
            // 
            // _labBrains
            // 
            this._labBrains.AutoSize = true;
            this._labBrains.Location = new System.Drawing.Point(14, 234);
            this._labBrains.Name = "_labBrains";
            this._labBrains.Size = new System.Drawing.Size(59, 25);
            this._labBrains.TabIndex = 3;
            this._labBrains.Text = "Brains";
            // 
            // _txtLuck
            // 
            this._txtLuck.Location = new System.Drawing.Point(209, 187);
            this._txtLuck.Name = "_txtLuck";
            this._txtLuck.Size = new System.Drawing.Size(60, 31);
            this._txtLuck.TabIndex = 5;
            this._txtLuck.Text = "1";
            // 
            // _txtMoxie
            // 
            this._txtMoxie.Location = new System.Drawing.Point(210, 64);
            this._txtMoxie.Name = "_txtMoxie";
            this._txtMoxie.Size = new System.Drawing.Size(60, 31);
            this._txtMoxie.TabIndex = 5;
            this._txtMoxie.Text = "1";
            // 
            // _txtBrains
            // 
            this._txtBrains.Location = new System.Drawing.Point(82, 231);
            this._txtBrains.Name = "_txtBrains";
            this._txtBrains.Size = new System.Drawing.Size(180, 31);
            this._txtBrains.TabIndex = 5;
            this._txtBrains.Text = "1";
            this._txtBrains.TextChanged += new System.EventHandler(this._txtBrains_TextChanged);
            // 
            // _labProf
            // 
            this._labProf.AutoSize = true;
            this._labProf.Location = new System.Drawing.Point(4, 322);
            this._labProf.Name = "_labProf";
            this._labProf.Size = new System.Drawing.Size(49, 25);
            this._labProf.TabIndex = 3;
            this._labProf.Text = "Prof.";
            // 
            // _labRace
            // 
            this._labRace.AutoSize = true;
            this._labRace.Location = new System.Drawing.Point(4, 353);
            this._labRace.Name = "_labRace";
            this._labRace.Size = new System.Drawing.Size(49, 25);
            this._labRace.TabIndex = 3;
            this._labRace.Text = "Race";
            // 
            // _labName
            // 
            this._labName.AutoSize = true;
            this._labName.Location = new System.Drawing.Point(12, 36);
            this._labName.Name = "_labName";
            this._labName.Size = new System.Drawing.Size(59, 25);
            this._labName.TabIndex = 6;
            this._labName.Text = "Name";
            // 
            // _txtDesc
            // 
            this._txtDesc.AutoSize = true;
            this._txtDesc.Location = new System.Drawing.Point(12, 95);
            this._txtDesc.Name = "_txtDesc";
            this._txtDesc.Size = new System.Drawing.Size(186, 25);
            this._txtDesc.TabIndex = 6;
            this._txtDesc.Text = "Description (Optional)";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(12, 64);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(126, 31);
            this._txtName.TabIndex = 5;
            // 
            // _richDescription
            // 
            this._richDescription.Location = new System.Drawing.Point(17, 121);
            this._richDescription.Name = "_richDescription";
            this._richDescription.Size = new System.Drawing.Size(181, 97);
            this._richDescription.TabIndex = 8;
            this._richDescription.Text = "";
            // 
            // _miCharacter
            // 
            this._miCharacter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCharacter});
            this._miCharacter.Name = "_miCharacter";
            this._miCharacter.Size = new System.Drawing.Size(110, 29);
            this._miCharacter.Text = "&Charcacter";
            // 
            // NewCharacter
            // 
            this.NewCharacter.Name = "NewCharacter";
            this.NewCharacter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewCharacter.Size = new System.Drawing.Size(213, 34);
            this.NewCharacter.Text = "New";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 394);
            this.Controls.Add(this._richDescription);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._txtDesc);
            this.Controls.Add(this._labName);
            this.Controls.Add(this._labRace);
            this.Controls.Add(this._labProf);
            this.Controls.Add(this._txtBrains);
            this.Controls.Add(this._txtMoxie);
            this.Controls.Add(this._txtLuck);
            this.Controls.Add(this._labBrains);
            this.Controls.Add(this._txtWealth);
            this.Controls.Add(this._labIntel);
            this.Controls.Add(this._txtBrawn);
            this.Controls.Add(this._labBrainsStat);
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
        private System.Windows.Forms.Label _labBrainsStat;
        private System.Windows.Forms.TextBox _txtBrawn;
        private System.Windows.Forms.Label _labIntel;
        private System.Windows.Forms.TextBox _txtWealth;
        private System.Windows.Forms.Label _labBrains;
        private System.Windows.Forms.TextBox _txtLuck;
        private System.Windows.Forms.TextBox _txtMoxie;
        private System.Windows.Forms.TextBox _txtBrains;
        private System.Windows.Forms.Label _labProf;
        private System.Windows.Forms.Label _labRace;
        private System.Windows.Forms.Label _labName;
        private System.Windows.Forms.Label _txtDesc;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.RichTextBox _richDescription;
        private System.Windows.Forms.ToolStripMenuItem _miCharacter;
        private System.Windows.Forms.ToolStripMenuItem NewCharacter;
    }
}

