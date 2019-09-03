using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            webBrowser1.GoHome();
        }

        private void homeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            webBrowser1.GoHome();
        }


        private void goButton_Click(object sender, System.EventArgs e)
        {
            
        }

        private void goForwardToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void goBackToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void goButton_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri(comboBox1.SelectedItem.ToString()));
        }
         private void navigateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

    }
}
