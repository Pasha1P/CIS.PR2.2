using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/pasha_p2");
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
