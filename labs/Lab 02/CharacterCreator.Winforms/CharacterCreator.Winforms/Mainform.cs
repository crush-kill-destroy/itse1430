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


namespace Character_Creator.Winforms
{
    public partial class MainForm : Form
    {
        private Character _character;

        public MainForm ()
        {
            InitializeComponent();

            _miExit.Click += OnExit;
            _miCharacter.Click +=OnNew;
        }

        private void OnNew ( object sender, EventArgs e)
        {

            _character = new Character();
            _character.ShowDialog(this);
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
            character.Name = _labName.Text;
            character.Description = _richDescription.Text;
            character.Brawn = character.ConvertStat(_labBrawn.Text);
            character.Brains = character.ConvertStat(_labBrains.Text);
            character.Moxie = character.ConvertStat(_labMoxie.Text);
            character.Luck = character.ConvertStat(_labLuck.Text);
            character.Sanity = character.ConvertStat(_labSanity.Text);
            character.Profession = _labProfession.Text;
            character.Race = _labRace.Text;

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

        private void _txtDesc_Click ( object sender, EventArgs e )
        {

        }

        private void lsdklf_Click ( object sender, EventArgs e )
        {

        }
    }
}
