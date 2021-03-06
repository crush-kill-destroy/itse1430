﻿/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 02
 */

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        /// <summary> The starting form that connects everything. </summary>
        public MainForm()
        {
            InitializeComponent();

            _miExit.Click += OnExit;
            _miNewCharacter.Click += OnNewCharacter;
            _miAbout.Click += OnAbout;
            _miDelete.Click += OnDelete;
            _miEdit.Click += OnEdit;
        }

        private void OnEdit(object sender, EventArgs e)
        {
            if (_character == null)
                return;

            if (!String.IsNullOrEmpty(_character.Name))
            {
                var form = new FormCreateCharacter(_character);
                var result = form.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                var error = _character.Validate();

                if (!String.IsNullOrEmpty(error))
                {
                    Error(error, "Edit failed! Reverting changes."); 
                    return;
                }

                RefreshForm(_character);
                RefreshRoster();
            }
        }

        private void OnDelete(object sender, EventArgs e)
        {
            _character = null;
            _lbRoster.ResetText();
            _labBrains.Text = "";
            _labBrawn.Text = "";
            _labLuck.Text = "";
            _labSanity.Text = "";
            _labMoxie.Text = "";
            _richDescription.Text = "";
            _lbRoster.SelectedItem = "";
            _labRace.Text = "";
            _labProfession.Text = "";
            RefreshRoster();
        }

        public Character _character = new Character();

        private void OnNewCharacter(object sender, EventArgs e)
        {
            var form = new FormCreateCharacter();
            var result = form.ShowDialog(this);
            
            if (result == DialogResult.Cancel)
                return;

            _character = form.character;
            var error = _character.Validate();

            if (!String.IsNullOrEmpty(error))
            {
                Error(error, "Can't add character");
                return;
            }

            RefreshForm(_character);
            RefreshRoster();
        }

        private void Error(string error, string title)
        {
            MessageBox.Show(this, error, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RefreshForm(Character character)
        {
            _labBrains.Text = character.Brains.ToString();
            _labBrawn.Text = character.Brawn.ToString();
            _labMoxie.Text = character.Moxie.ToString();
            _labSanity.Text = character.Sanity.ToString();
            _labLuck.Text = character.Luck.ToString();
            _labRace.Text = character.Race;
            _labProfession.Text = character.Profession;
            _richDescription.Text = character.Description;
        }

        private void RefreshRoster()
        {
            var roster = new BindingList<Character> {_character};
            _lbRoster.DataSource = roster;
            _lbRoster.DisplayMember = "Name";
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void OnAbout(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog(this);
        }
        

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LLLL(object sender, EventArgs e)
        {

        }


        private void rtrtrtrt(object sender, EventArgs e)
        {

        }

        private void lsdklf_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
