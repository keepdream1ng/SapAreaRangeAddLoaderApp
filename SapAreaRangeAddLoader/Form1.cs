﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SapApiHelperLibrary;
using SAP2000v1;

namespace SapAreaRangeAddLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SapConnector.ConnectToSap();
            Prefix_textBox.Text = "Live";
            AreaLoader.LoadManager.LoadTypeToCreate = eLoadPatternType.Live;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SapConnector.CloseConnectionToSap();
        }

        private void Prefix_textBox_TextChanged(object sender, EventArgs e)
        {
            AreaLoader.LoadPrefix = Prefix_textBox.Text;
        }

        private void CreateLoads_button_Click(object sender, EventArgs e)
        {
            AreaLoader.CreateLoadsAndCasesForSelectedAreas();
        }
    }
}
