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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void DataGrid_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginMenu().Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void DataGridbutton_Click(object sender, EventArgs e)
        {
            new DataGridMenu().Show();
            this.Hide();
        }

        private void NavBindingbutton_Click(object sender, EventArgs e)
        {
            new NavBind().Show();
            this.Hide();
        }
    }
}
