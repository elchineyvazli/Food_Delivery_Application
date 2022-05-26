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
    public partial class page5 : UserControl
    {
        public page5()
        {
            InitializeComponent();
        }

        private void txtNamepage5_MouseEnter(object sender, EventArgs e)
        {
            if(txtNamepage5.Text == "Enter the name")
            {
                txtNamepage5.Text = "";
            }
            if (txtNamepage5.Text == "")
            {
                txtNamepage5.Text = "Enter the name";
            }
        }

        private void txtEmailpage5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmailpage5_MouseEnter(object sender, EventArgs e)
        {
            if (txtEmailpage5.Text == "Enter the email")
            {
                txtEmailpage5.Text = "";
            }
            if (txtEmailpage5.Text == "")
            {
                txtEmailpage5.Text = "Enter the email";
            }
        }

        private void txtPasswordpage5_MouseEnter(object sender, EventArgs e)
        {
            if (txtPasswordpage5.Text == "Enter the password")
            {
                txtPasswordpage5.Text = "";
            }
            if (txtPasswordpage5.Text == "")
            {
                txtPasswordpage5.Text = "Enter the password";
            }
        }

        private void txtConPasswordpage5_MouseEnter(object sender, EventArgs e)
        {
            if (txtConPasswordpage5.Text == "Confirm the password")
            {
                txtConPasswordpage5.Text = "";
            }
            if (txtConPasswordpage5.Text == "")
            {
                txtConPasswordpage5.Text = "Confirm the password";
            }
        }

        private void loginLabelpage5_Click(object sender, EventArgs e)
        {
            page4 p4 = new page4();
            p4.Show();
        }
    }
}
