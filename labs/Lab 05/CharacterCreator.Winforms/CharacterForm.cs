/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 03
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CharacterCreator.Professions;

namespace CharacterCreator.Winforms
{
    /// <summary>Provides a UI for creating a character.</summary>
    public partial class CharacterForm : Form
    {
        public CharacterForm ()
        {
            InitializeComponent();
        }

        /// <summary>Gets or sets the selected character.</summary>
        public Character SelectedCharacter { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            LoadUI();
        }

        private void OnSave ( object sender, EventArgs e )
        {
            var character = SaveCharacter();

            var validator = new ObjectValidator();
            var validationResults = validator.TryValidateFullObject(character);

            if (validationResults.Count() > 0)
            {
                var errors = validator.GetValidationResults(validationResults);
                MessageBox.Show(this, errors, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            SelectedCharacter = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void LoadUI ()
        {
            LoadProfessions();
            LoadRaces();

            if (SelectedCharacter != null)
            {
                Text = "Edit Character";
                LoadCharacter(SelectedCharacter);
            };
        }

        private void LoadProfessions ()
        {
            _cbProfession.DataSource = StandardProfessions.Professions;
            _cbProfession.SelectedIndex = -1;
        }

        private void LoadRaces ()
        {
            _cbRace.DataSource = StandardRaces.Races;
            _cbRace.SelectedIndex = -1;
        }

        private void LoadCharacter ( Character character )
        {
            _txtName.Text = character.Name;
            SelectProfession(character.Job);
            SelectRace(character.Race);
            _txtBiography.Text = character.Description;
            _txtIntelligence.Text = character.Brains.ToString();
            _txtStrength.Text = character.Brawn.ToString();
            _txtAgility.Text = character.Luck.ToString();
            _txtCharisma.Text = character.Moxie.ToString();
            _txtConstitution.Text = character.Sanity.ToString();
        }

        private Character SaveCharacter ( )
        {
            var tempStrength = _txtStrength.Text;
            var tempIntelligence = _txtIntelligence.Text;
            var tempAgility = _txtAgility.Text;
            var tempConstitution = _txtConstitution.Text;
            var tempCharisma = _txtCharisma.Text;

            Int32.TryParse(tempStrength, out var intStrength);
            Int32.TryParse(tempIntelligence, out var intIntelligence);
            Int32.TryParse(tempAgility, out var intAgility);
            Int32.TryParse(tempConstitution, out var intConstitution);
            Int32.TryParse(tempCharisma, out var intCharisma);

            var character = new Character {
                Name = _txtName.Text,
                Job = _cbProfession.SelectedItem as Profession,
                Race = _cbRace.SelectedItem as Race,
                Description = _txtBiography.Text,
                Brawn = intStrength,
                Brains = intIntelligence,
                Luck = intAgility,
                Sanity = intConstitution,
                Moxie = intCharisma
            };

            return character;
        }

        private void SelectProfession ( Profession desiredItem )
        {
            foreach (var item in _cbProfession.Items)
            {
                if ((item as Profession).Name == desiredItem.Name)
                {
                    _cbProfession.SelectedItem = item;
                    return;
                };
            };
        }

        private void SelectRace ( Race desiredItem )
        {
            foreach (var item in _cbRace.Items)
            {
                if ((item as Race).Name == desiredItem.Name)
                {
                    _cbRace.SelectedItem = item;
                    return;
                };
            };
        }

        private void OnValidateName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            
            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name is required!");
                e.Cancel = true;
            } else
                _errors.SetError(control, "");
        }

        /// <summary> UI checking you selected something from the drop-downs. </summary>
        private void OnValidatingDropDown ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "You need to pick something!");
                e.Cancel = true;
            }
            
            else
                _errors.SetError(control, "");
        }

        /// <summary> UI validating the stats </summary>
        private void OnValidatingStats ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Stats cannot be empty!");
                e.Cancel = true;
            } else
                _errors.SetError(control, "");

            var success = Int32.TryParse(control.Text, out var stat);

            if (!success)
            {
                _errors.SetError(control, "Numbers only!");
                e.Cancel = true;
            } else
                _errors.SetError(control, "");

            if (stat < 1 || stat > 100)
            {
                _errors.SetError(control, "Between 1 and 100!");
                e.Cancel = true;
            } else
                _errors.SetError(control, "");
        }

        private void _txtBiography_TextChanged ( object sender, EventArgs e )
        {

        }
    }
}
