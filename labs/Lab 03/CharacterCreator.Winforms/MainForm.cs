/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 03
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnCharacterNew ( object sender, EventArgs e )
        {
            var form = new CharacterForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _character = form.SelectedCharacter;
            AddCharacter(form.SelectedCharacter);
        }

        private void AddCharacter ( Character character )
        {
            var newCharacter = _characters.Add(character);
            RefreshRoster();
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            if (MessageBox.Show(this, $"Are you sure you want to delete {character.Name}?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _characters.Delete(character.Id);

            RefreshRoster();
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            //TODO: Replacement error message
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            var form = new CharacterForm {
                SelectedCharacter = character
            };

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            form.SelectedCharacter.Id = character.Id;
            _characters.Update(character.Id, form.SelectedCharacter);

            RefreshRoster();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm();
            form.ShowDialog(this);
        }

        /// <summary>Gets the selected character, if any</summary>
        private Character GetSelectedCharacter ()
        {
            var character = _lstCharacters.SelectedItem as Character;

            return character == null ? null : _characters.Get(character.Id);
        }

        /// <summary>Refreshes the main menu.</summary>
        private void RefreshRoster()
        {
            _lstCharacters.DataSource = _characters.GetAll().ToArray();
        }

        private ICharacterRoster _characters = new Roster();
        private Character _character = new Character();

        private void _lstCharacters_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }
    }
}
