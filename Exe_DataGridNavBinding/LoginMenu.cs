using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe_DataGridNavBinding
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {


        }

        public void Login_Click(object sender, EventArgs e)
        {
            if(Usernamebox.Text=="Rafi" && Passwordbox.Text=="rapi123"  && checkBox1.Checked)
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        public void Passwordbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
