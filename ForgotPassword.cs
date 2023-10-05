using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class ForgotPassword : Form
    {

        public ForgotPassword()
        {
            InitializeComponent();
        }
        string answer;
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAnswer.TextLength > 0 && txtAnswer.Text == answer)
            {
                PasswordRest pr = new PasswordRest(); 
                pr.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Please Enter Valid Details");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAnswer.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            //string Securityquestion;
            string uname = signin.CurrentUser;
            string cs = "Data Source=localhost\\sqlexpress;Initial Catalog=UserDetails;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            string Query = "select Securityquestion, Answer from SecurityTable where userName = '"+uname+"'";
            SqlCommand cmd = new SqlCommand(Query, conn);

            try
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read()) {
                        secQuestion.Text = (string)rdr["SecurityQuestion"];
                        answer = (string)rdr["Answer"];
                    }
                }
                else
                {
                    MessageBox.Show("No User Found!");
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
            finally { conn.Close(); }

        }
    }
}
