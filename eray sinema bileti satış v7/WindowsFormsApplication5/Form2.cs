using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                maskedTextBox2.PasswordChar = '\0';
            else
                maskedTextBox2.PasswordChar = '*';
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                button1.Enabled = true;
            else if (checkBox2.Checked == false)
                button1.Enabled = false;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
                button1.Enabled = false;
        }
    }
}
