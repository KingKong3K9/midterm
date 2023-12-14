using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RoundCorners(panel1, 10);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            
            string dataToCopy = txtdata.Text;
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
        private void RoundCorners(Panel panel, int cornerRadius)
        {
            // Tạo đối tượng GraphicsPath để bo tròn góc
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius * 4, cornerRadius * 4, 180, 90);
            path.AddArc(panel.Width - (cornerRadius * 4), 0, cornerRadius * 4, cornerRadius * 4, 270, 90);
            path.AddArc(panel.Width - (cornerRadius * 4), panel.Height - (cornerRadius * 4), cornerRadius * 4, cornerRadius * 4, 0, 90);
            path.AddArc(0, panel.Height - (cornerRadius * 4), cornerRadius * 4, cornerRadius * 4, 90, 90);
            panel.Region = new Region(path);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
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
    }
}
