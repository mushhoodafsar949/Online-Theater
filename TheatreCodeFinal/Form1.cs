using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheatreCodeFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome To Online Theater", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
        private void Continue_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Validating(object sender, CancelEventArgs e)
        {
            Application.ExitThread();
            // Application.Exit();
        }
    }
}
