using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class signup : Form
    {
        public static string CurrentUser = "";
        public signup()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;
            
        }
        // database connection String
        string cs = "Data Source=localhost\\sqlexpress;Initial Catalog=UserDetails;Integrated Security=True";


        private void SignUp_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            string reusername;
            if (txtUsername.TextLength > 0 && txtPassword.TextLength > 0 && txtRepassword.TextLength > 0)
            {
                if (txtPassword.Text == txtRepassword.Text)
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;
                   
                   // MessageBox.Show("Username : " + username + " Password: " + password);

                    // entring the data into data base
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtRepassword.Clear();
                    // creating the data base connection object
                    SqlConnection conn = new SqlConnection(cs);
                    string Query = "insert into Users (Username, Password) values('"+username+"','"+password+"')";
                    string Query1 = "select Username from Users where Username = '"+username+"'";

                    SqlCommand cmd = new SqlCommand(Query1, conn);
                    try
                    {
                        conn.Open();
                        SqlDataReader rdr1 = cmd.ExecuteReader();
                        if (rdr1.HasRows)
                        {
                            MessageBox.Show("User Already Existed!");
                            rdr1.Close();
                        }
                        else
                        {
                            rdr1.Close();
                            cmd = new SqlCommand(Query, conn);
                            try
                            { 
                                rdr1 = cmd.ExecuteReader();
                                CurrentUser = username;
                                Security sec = new Security();
                                sec.Show();
                                Visible = false;
                                MessageBox.Show("Sign Up Successful");

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Inner: "+ex.Message);
                            }
                           finally { rdr1.Close(); }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Outer : "+ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
                if (txtPassword.Text != txtRepassword.Text)
                {
                    MessageBox.Show("Password didnt match!");
                }
            }
            else
            {
                MessageBox.Show("Error ! While signing Up");
            }


        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtRepassword.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signin si = new signin();
            si.Show();
            Visible = false;
        }

      
    }
}
