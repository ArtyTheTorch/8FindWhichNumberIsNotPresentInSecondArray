using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8FindWhichNumberIsNotPresentInSecondArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string results;
            FindMissingNumber x = new FindMissingNumber(textBox1.Text,textBox2.Text);
            results = x.getResults();
            label2.Text = results;
        }
    }
}
