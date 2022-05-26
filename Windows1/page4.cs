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
    public partial class page4 : UserControl
    {
        public page4()
        {
            InitializeComponent();
        }

        private void registerLabelpage4_Click(object sender, EventArgs e)
        {
            

        }

        private void txtNamepage4_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtPasswordpage4_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtNamepage4_MouseLeave(object sender, EventArgs e)
        {
            if (txtNamepage4.Text == "")
            {
                txtNamepage4.Text = "Enter the name";
            }
        }

        private void txtPasswordpage4_MouseLeave(object sender, EventArgs e)
        {
            if (txtPasswordpage4.Text == "")
            {
                txtPasswordpage4.Text = "Enter the password";
            }
        }

        private void txtNamepage4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamepage4_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtNamepage4.Text == "Enter the name")
            {
                txtNamepage4.Text = "";
            }
        }

        private void txtPasswordpage4_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPasswordpage4.Text == "Enter the password")
            {
                txtPasswordpage4.Text = "";
            }
        }
    }
}
