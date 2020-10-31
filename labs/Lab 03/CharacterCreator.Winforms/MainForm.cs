/*
 * ITSE 1430
 * Lab 03 - Character Creator
 * 
 * Sample implementation.
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm ()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnCharacterNew ( object sender, EventArgs e )
        {
            var form = new CharacterForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            //Add the character
            AddCharacter(form.SelectedCharacter);
        }

        private void AddCharacter ( Character character )
        {
            //TODO: Fix ErrorCheck call
            //TODO: ErrorCheck(character, "error", "Add Failed");
            _characters.Add(character);
            RefreshRoster();
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            if (MessageBox.Show(this, $"Are you sure you want to delete {character.Name}?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _character = null;
            RefreshRoster();
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            var form = new CharacterForm();
            form.SelectedCharacter = character;

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _character = form.SelectedCharacter;
            RefreshRoster();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm();
            form.ShowDialog(this);
        }        
        #endregion

        #region Private Members

        // Gets the selected character, if any
        private Character GetSelectedCharacter ()
        {
            return _character;
        }

        private void RefreshRoster()
        {
            _lstCharacters.DataSource = _characters.GetAll().ToArray();
        }

        private ICharacterRoster _characters = new CharacterRoster();
        private Character _character;
        #endregion

        private void _lstCharacters_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }
    }
}
