﻿using System;
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
        public MainForm()
        {
            InitializeComponent();

            _miExit.Click += OnExit;
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void menuStrip1_ItemClicked ( object sender, ToolStripItemClickedEventArgs e )
        {

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
    }
}