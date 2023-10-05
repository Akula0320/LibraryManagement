using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class PasswordRest : Form
    {
        public PasswordRest()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtpassword.TextLength > 0 && txtCpassword.TextLength > 0 && txtCpassword.Text == txtpassword.Text && txtusername.TextLength>0)
            {
                string uname= txtusername.Text;
                string pass = txtpassword.Text;
                string cs = "Data Source=localhost\\sqlexpress;Initial Catalog=UserDetails;Integrated Security=True";
                SqlConnection conn = new SqlConnection(cs);
                string Query = "update Users set Password = '"+pass+ "' where Username = '"+uname+"'";
                SqlCommand cmd = new SqlCommand(Query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    MessageBox.Show("Successfull Updated Password!");
                    signin si = new signin();
                    si.Show();
                    Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
            else
            {
                MessageBox.Show("All Feilds are Manditory!");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtCpassword.Clear();
            txtusername.Clear();
            txtpassword.Clear();
        }
    }
}
