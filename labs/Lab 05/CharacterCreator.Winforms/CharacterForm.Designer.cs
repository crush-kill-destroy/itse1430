namespace CharacterCreator.Winforms
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._cbRace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._cbProfession = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            this._txtBrawn = new System.Windows.Forms.TextBox();
            this._txtBrains = new System.Windows.Forms.TextBox();
            this._txtLuck = new System.Windows.Forms.TextBox();
            this._txtSanity = new System.Windows.Forms.TextBox();
            this._txtMoxie = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(112, 29);
            this._txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(266, 26);
            this._txtName.TabIndex = 1;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // _cbRace
            // 
            this._cbRace.DisplayMember = "Name";
            this._cbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbRace.FormattingEnabled = true;
            this._cbRace.Location = new System.Drawing.Point(112, 77);
            this._cbRace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._cbRace.Name = "_cbRace";
            this._cbRace.Size = new System.Drawing.Size(180, 28);
            this._cbRace.TabIndex = 2;
            this._cbRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingDropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Profession";
            // 
            // _cbProfession
            // 
            this._cbProfession.DisplayMember = "Name";
            this._cbProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProfession.FormattingEnabled = true;
            this._cbProfession.Location = new System.Drawing.Point(112, 126);
            this._cbProfession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._cbProfession.Name = "_cbProfession";
            this._cbProfession.Size = new System.Drawing.Size(180, 28);
            this._cbProfession.TabIndex = 3;
            this._cbProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingDropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtMoxie);
            this.groupBox1.Controls.Add(this._txtSanity);
            this.groupBox1.Controls.Add(this._txtLuck);
            this.groupBox1.Controls.Add(this._txtBrains);
            this.groupBox1.Controls.Add(this._txtBrawn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(24, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(250, 252);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 195);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Charisma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Constitution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Agility";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Intelligence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Strength";
            // 
            // _txtBiography
            // 
            this._txtDescription.Location = new System.Drawing.Point(406, 60);
            this._txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtBiography";
            this._txtDescription.Size = new System.Drawing.Size(440, 382);
            this._txtDescription.TabIndex = 9;
            this._txtDescription.TextChanged += new System.EventHandler(this._txtBiography_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Biography";
            // 
            // _btnCancel
            // 
            this._btnCancel.CausesValidation = false;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(754, 478);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(112, 35);
            this._btnCancel.TabIndex = 11;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(633, 478);
            this._btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(112, 35);
            this._btnSave.TabIndex = 10;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _errors
            // 
            this._errors.ContainerControl = this;
            // 
            // _txtStrength
            // 
            this._txtBrawn.Location = new System.Drawing.Point(129, 32);
            this._txtBrawn.Name = "_txtStrength";
            this._txtBrawn.Size = new System.Drawing.Size(87, 26);
            this._txtBrawn.TabIndex = 4;
            this._txtBrawn.Text = "50";
            this._txtBrawn.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // _txtIntelligence
            // 
            this._txtBrains.Location = new System.Drawing.Point(129, 72);
            this._txtBrains.Name = "_txtIntelligence";
            this._txtBrains.Size = new System.Drawing.Size(87, 26);
            this._txtBrains.TabIndex = 5;
            this._txtBrains.Text = "50";
            this._txtBrains.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // _txtAgility
            // 
            this._txtLuck.Location = new System.Drawing.Point(129, 115);
            this._txtLuck.Name = "_txtAgility";
            this._txtLuck.Size = new System.Drawing.Size(87, 26);
            this._txtLuck.TabIndex = 6;
            this._txtLuck.Text = "50";
            this._txtLuck.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // _txtConstitution
            // 
            this._txtSanity.Location = new System.Drawing.Point(129, 155);
            this._txtSanity.Name = "_txtConstitution";
            this._txtSanity.Size = new System.Drawing.Size(87, 26);
            this._txtSanity.TabIndex = 7;
            this._txtSanity.Text = "50";
            this._txtSanity.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // _txtCharisma
            // 
            this._txtMoxie.Location = new System.Drawing.Point(127, 192);
            this._txtMoxie.Name = "_txtCharisma";
            this._txtMoxie.Size = new System.Drawing.Size(87, 26);
            this._txtMoxie.TabIndex = 8;
            this._txtMoxie.Text = "50";
            this._txtMoxie.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(885, 532);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._cbProfession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cbRace);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.ComboBox _cbRace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbProfession;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.ErrorProvider _errors;
        private System.Windows.Forms.TextBox _txtMoxie;
        private System.Windows.Forms.TextBox _txtSanity;
        private System.Windows.Forms.TextBox _txtLuck;
        private System.Windows.Forms.TextBox _txtBrains;
        private System.Windows.Forms.TextBox _txtBrawn;
    }
}