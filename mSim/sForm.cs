﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mSim
{
    public partial class sForm : Form
    {
        public sForm()
        {
            InitializeComponent();
        }

        private void sForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            throw new NotImplementedException();
        }
    }
}
