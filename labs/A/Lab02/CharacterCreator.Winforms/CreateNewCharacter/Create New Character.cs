/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 02
 */

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CharacterCreator
{
    /// <summary> The form that creates the character </summary>
    public partial class FormCreateCharacter : Form
    {
        public FormCreateCharacter()
        {
            InitializeComponent();
        }

        private Character _character = new Character();
        public Character character;

        /// <summary> This initializes the form with a character you've already created. </summary>
        /// <param name="editedCharacter"> The character you're editing. </param>
        public FormCreateCharacter (Character editedCharacter) : this()
        {
            _character = editedCharacter;
            _txtName.Text = _character.Name;
            _comboProfession.SelectedItem = _character.Profession;
            _comboRace.SelectedItem = _character.Race;
            _richDescription.Text = _character.Description;
            _txtBrains.Text = _character.Brains.ToString();
            _txtBrawn.Text = _character.Brawn.ToString();
            _txtLuck.Text = _character.Luck.ToString();
            _txtMoxie.Text = _character.Moxie.ToString();
            _txtSanity.Text = _character.Sanity.ToString();
            Text = "Edit Character";
        }

        private void _buttonCancel_Click(object sender, EventArgs e)
        {

        }

        /// <summary> UI validating name </summary>
        private void OnValidateName(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name is required!");
                e.Cancel = true;
            }

            else
            {
                _errors.SetError(control, "");
            }

            if (control.Text.Length > Character.MaxNameLength)
            {
                _errors.SetError(control, "Name is required!");
                e.Cancel = true;
            }

            else
            {
                _errors.SetError(control, "");
            }
        }

        private void OnValidatingDescription(object sender, CancelEventArgs e)
        {
            var control = sender as RichTextBox;

            if (control.Text.Length > Character.MaxDescriptionLength)
            {
                _errors.SetError(control, $"Description can't be more than {Character.MaxDescriptionLength}");
                e.Cancel = true;
            }

            else
                _errors.SetError(control, "");
        }

        /// <summary> UI validating the dropdowns. </summary>
        private void OnValidatingDropDown(object sender, CancelEventArgs e)
        {
            var control = sender as ComboBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name is required!");
                e.Cancel = true;
            }

            else
                _errors.SetError(control, "");
        }

        /// <summary> UI validating the stats </summary>
        private void OnValidatingStats(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            var success = Int32.TryParse(control.Text, out var stat);

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Stats cannot be empty!");
                e.Cancel = true;
            }

            else
                _errors.SetError(control, "");
            
            if (!success)
            {
                _errors.SetError(control, "Numbers only!");
                e.Cancel = true;
            }

            else
                _errors.SetError(control, "");

            if (stat < 1 || stat > 100)
            {
                _errors.SetError(control, "Between 1 and 100!");
                e.Cancel = true;
            }

            else
                _errors.SetError(control, "");
        }

        /// <summary> UI validating Brains </summary>
        private void OnValidatingBrains(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            var success = Int32.TryParse(control.Text, out var stat);

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Stats cannot be empty!");
                e.Cancel = true;
            }

            else
                _errors.SetError(control, "");

            if (!success)
            {
                _errors.SetError(control, "Numbers only!");
                e.Cancel = true;
            }

            else
                _errors.SetError(control, "");

            if (stat < -2000000 || stat > 100)
            {
                _errors.SetError(control, "Between -2,000,000 and 100!");
                e.Cancel = true;
            }

            else
                _errors.SetError(control, "");
        }
    }
}
