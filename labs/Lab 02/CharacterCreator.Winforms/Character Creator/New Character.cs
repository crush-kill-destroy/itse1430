using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Creator.Winforms
{
    public partial class CharacterCreator : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox _txtBrawn;
        private TextBox _txtBrains;
        private TextBox _txtSanity;
        private TextBox _txtLuck;
        private TextBox _txtMoxie;
        private ComboBox _comboRace;
        private ComboBox comboBox2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox _txtName;
        private RichTextBox _richDescriptionInput;

        public CharacterCreator ()
        {
            InitializeComponent();
        }

        private void Form1_Load ( object sender, EventArgs e )
        {

        }

        private void textBox17_TextChanged ( object sender, EventArgs e )
        {

        }

        private void comboBox6_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void comboBox5_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void InitializeComponent ()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._txtBrawn = new System.Windows.Forms.TextBox();
            this._txtBrains = new System.Windows.Forms.TextBox();
            this._txtSanity = new System.Windows.Forms.TextBox();
            this._txtLuck = new System.Windows.Forms.TextBox();
            this._txtMoxie = new System.Windows.Forms.TextBox();
            this._richDescriptionInput = new System.Windows.Forms.RichTextBox();
            this._comboRace = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brawn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(110, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Moxie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(176, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Luck";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Brains";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(246, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sanity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(43, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Except brains, which is between -2,000,000 and 100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(43, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Stats are between 1 and 100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(43, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(375, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "There are limits to genius, but stupidity is bottomless.";
            // 
            // _txtBrawn
            // 
            this._txtBrawn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtBrawn.Location = new System.Drawing.Point(44, 379);
            this._txtBrawn.Name = "_txtBrawn";
            this._txtBrawn.Size = new System.Drawing.Size(61, 26);
            this._txtBrawn.TabIndex = 6;
            this._txtBrawn.Text = "50";
            // 
            // _txtBrains
            // 
            this._txtBrains.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtBrains.Location = new System.Drawing.Point(108, 416);
            this._txtBrains.Name = "_txtBrains";
            this._txtBrains.Size = new System.Drawing.Size(198, 26);
            this._txtBrains.TabIndex = 6;
            this._txtBrains.Text = "50";
            // 
            // _txtSanity
            // 
            this._txtSanity.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtSanity.Location = new System.Drawing.Point(246, 379);
            this._txtSanity.Name = "_txtSanity";
            this._txtSanity.Size = new System.Drawing.Size(61, 26);
            this._txtSanity.TabIndex = 6;
            this._txtSanity.Text = "50";
            // 
            // _txtLuck
            // 
            this._txtLuck.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtLuck.Location = new System.Drawing.Point(178, 379);
            this._txtLuck.Name = "_txtLuck";
            this._txtLuck.Size = new System.Drawing.Size(61, 26);
            this._txtLuck.TabIndex = 6;
            this._txtLuck.Text = "50";
            // 
            // _txtMoxie
            // 
            this._txtMoxie.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtMoxie.Location = new System.Drawing.Point(111, 379);
            this._txtMoxie.Name = "_txtMoxie";
            this._txtMoxie.Size = new System.Drawing.Size(61, 26);
            this._txtMoxie.TabIndex = 6;
            this._txtMoxie.Text = "50";
            // 
            // _richDescriptionInput
            // 
            this._richDescriptionInput.Location = new System.Drawing.Point(53, 171);
            this._richDescriptionInput.Name = "_richDescriptionInput";
            this._richDescriptionInput.Size = new System.Drawing.Size(311, 96);
            this._richDescriptionInput.TabIndex = 7;
            this._richDescriptionInput.Text = "";
            // 
            // _comboRace
            // 
            this._comboRace.FormattingEnabled = true;
            this._comboRace.Items.AddRange(new object[] {
            "A Stick With An Angry Face Scribbled On It",
            "A Compiler Error",
            "Anthropomorphic Washing Machine",
            "Killer Clown",
            "Sentient Lollipop",
            "Floating Orb Of Eyes",
            "Mass Hallucination",
            "A Wasp Made Of Bees"});
            this._comboRace.Location = new System.Drawing.Point(166, 96);
            this._comboRace.Name = "_comboRace";
            this._comboRace.Size = new System.Drawing.Size(182, 33);
            this._comboRace.TabIndex = 8;
            this._comboRace.Text = "race";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Chainsaw Paladin",
            "Mime",
            "Philosophy Major",
            "Boy Band Backup Dancer",
            "Necromancerphiliac",
            "Merry Prankster",
            "Catholic Priest",
            "Murder Hobo",
            "Weaboo",
            "Rent Boy"});
            this.comboBox2.Location = new System.Drawing.Point(166, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 33);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "profession";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 25);
            this.label10.TabIndex = 9;
            this.label10.Tag = "";
            this.label10.Text = "Race";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Profession";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Description";
            // 
            // _txtName
            // 
            this._txtName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtName.Location = new System.Drawing.Point(166, 28);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(198, 26);
            this._txtName.TabIndex = 6;
            // 
            // Character_Creator
            // 
            this.ClientSize = new System.Drawing.Size(473, 466);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this._comboRace);
            this.Controls.Add(this._richDescriptionInput);
            this.Controls.Add(this._txtMoxie);
            this.Controls.Add(this._txtLuck);
            this.Controls.Add(this._txtSanity);
            this.Controls.Add(this._txtBrains);
            this.Controls.Add(this._txtBrawn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Character_Creator";
            this.ShowIcon = false;
            this.Text = "Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
