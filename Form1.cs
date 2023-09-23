using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSangeeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {txtName.Text}");
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result=MessageBox.Show("Do you want to close?","Close Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
            if(result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel=true;
            }
        }
    }
}
