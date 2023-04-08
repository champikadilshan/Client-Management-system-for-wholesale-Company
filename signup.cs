using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab05_3i
{
    public partial class signup : Form

    {
        

        public signup()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=LAPTOP-F064026F;Initial Catalog=wiky;Integrated Security=True";
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into [wiky].[dbo].[user] (email,fname,lname,password) values ('" + textBox3.Text + "','"+textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "')";
                SqlCommand cmd = new SqlCommand(q,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Account Created Succesfully ! ");
            }
        }

        

    }
}
