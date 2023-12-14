using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_test
{
    public partial class Form2 : Form
    {
        private string originvalue;
        public Form2()
        {
            InitializeComponent();
            originvalue = txtData.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtData.Text = originvalue;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtData.Text = "";
            txtData.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCp2_Click(object sender, EventArgs e)
        {
            string dataToCopy = rTB.Text;
            if (!string.IsNullOrEmpty(dataToCopy))
            {
                Clipboard.SetText(dataToCopy);

                MessageBox.Show("Copied to Clipboard!");
            }
            else
            {
                MessageBox.Show("Please enter data before copying.");
            }
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
