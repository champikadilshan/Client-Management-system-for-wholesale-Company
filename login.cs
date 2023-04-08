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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-F064026F;Initial Catalog=wiky;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup s1 = new signup();
            s1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                String querry = "SELECT TOP (1000) [email]\r\n      ,[fname]\r\n      ,[lname]\r\n      ,[password]\r\n  FROM [wiky].[dbo].[user]\r\n  WHERE [email] = '" + txt_username.Text + "' AND [password] = '" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;

                 
                    team t1 = new team();
                    t1.ShowDialog();
           
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error");
                    txt_username.Clear();
                    txt_password.Clear();

                    // to focus username
                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                conn.Close();
            }
        } 


    }
}
