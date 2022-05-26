using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            page11.Show();
            page11.BringToFront();
            page21.Hide();
            page31.Hide();
            page41.Hide();
            page51.Hide();

        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            page11.Show();
            page11.BringToFront();
            page21.Hide();
            page31.Hide();
            page41.Hide();
            page51.Hide();
            
        }

        private void afButton_Click(object sender, EventArgs e)
        {
            page11.Hide();
            page21.BringToFront();
            page21.Show();
            page31.Hide();
            page41.Hide();
            page51.Hide();
        }

        private void ofButton_Click(object sender, EventArgs e)
        {
            page11.Hide();
            page31.BringToFront();
            page21.Hide();
            page31.Show();
            page41.Hide();
            page51.Hide();
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            page11.Hide();
            page41.BringToFront();
            page21.Hide();
            page31.Hide();
            page41.Show();
            page51.Hide();
        }
    }
}
