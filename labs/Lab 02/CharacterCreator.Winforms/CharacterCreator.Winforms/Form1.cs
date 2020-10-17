/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 02
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();

            _miExit.Click += OnExit;
            _miCharacter.Click +=OnNew;
        }

        
        private void OnNew(object sender, EventArgs e)
        {
            var result = Character_Creator.ShowDialog(this);
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void menuStrip1_ItemClicked ( object sender, ToolStripItemClickedEventArgs e )
        {

        }

        private void OnSave(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            var character = new Character();
            character.Name = _txtName.Text;
            character.Description = _richDescription.Text;
            character.Brawn = character.ConvertStat(_txtBrawn.Text);
            character.Brains = character.ConvertStat(_txtBrains.Text);
            character.Moxie = character.ConvertStat(_txtMoxie.Text);
            character.Luck = character.ConvertStat(_txtLuck.Text);
            character.Wealth = character.ConvertStat(_txtWealth.Text);
            character.Profession = _comboProf.Text;
            character.Race = _comboRace.Text;

            var valid = character.Validate();
            if (valid != null)
                Error(valid);
        }

        private void Error ( string error )
        {
            MessageBox.Show(this, error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click ( object sender, EventArgs e )
        {

        }

        private void label1_Click_1 ( object sender, EventArgs e )
        {

        }

        private void _labJnsq_Click ( object sender, EventArgs e )
        {

        }

        private void _txtBrains_TextChanged ( object sender, EventArgs e )
        {

        }
    }
}
