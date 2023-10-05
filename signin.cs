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

   
    public partial class signin : Form
    {
        public static string CurrentUser = "";
        public signin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        
        //creating connection string 
        string cs = "Data Source=localhost\\sqlexpress;Initial Catalog=UserDetails;Integrated Security=True";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            if(txtUsername.TextLength>0 && txtPassword.TextLength>0)
            {
               username = txtUsername.Text;
                password = txtPassword.Text;
               // MessageBox.Show("Username: " +username+"  Password: "+ password);
                // Retriving data from DataBase
                txtUsername.Clear();
                txtPassword.Clear();

                // creating the sql connection object
                SqlConnection conn = new SqlConnection(cs);
                string Query = "select * from Users where Username = '"+username+"'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            if ((username == (string)rdr["Username"]) && (password == (string)rdr["Password"]))
                            {
                                MessageBox.Show("You are Successfully Signed in!");
                                Dashbord db = new Dashbord();
                                CurrentUser = username;
                                db.Show();
                                Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Password Or Username");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("User Not Existed!");
                    }
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }

            }
            else
            {
                MessageBox.Show("All fields are Mandedtory!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           signup su = new signup();
           su.Show();
           Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txtUsername.TextLength > 0)
            {
                CurrentUser = txtUsername.Text;
                ForgotPassword fp = new ForgotPassword();
                fp.Show();
                Visible = false;

            }
            else
            {
                MessageBox.Show("Please enter User name");
            }

        }

    }
}
