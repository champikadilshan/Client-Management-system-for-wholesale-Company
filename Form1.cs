using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab05_3i
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login l1 = new login();
            l1.ShowDialog();   
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            signup s1 = new signup();
            s1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            team t1 = new team();
            t1.ShowDialog();
        }
    }
}
