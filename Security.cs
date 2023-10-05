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
    public partial class Security : Form
    {
        string uname;
        public Security()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSQuestion.TextLength > 0 && txtAnswer.TextLength > 0  && txtAnswer.Text == txtCAnswer.Text)
            {
                
                string cs = "Data Source=localhost\\sqlexpress;Initial Catalog=UserDetails;Integrated Security=True";
                SqlConnection conn = new SqlConnection(cs);
                string Query = "insert into SecurityTable values('"+uname+"', '"+txtSQuestion.Text+"', '"+txtAnswer.Text+"')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    signup su = new signup();
                    su.Show();
                    Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message);
                }
                finally { conn.Close(); }
            }
            else
            {
                MessageBox.Show("Please check the Security error");
            }
        }

        private void Security_Load(object sender, EventArgs e)
        {
            uname = signup.CurrentUser;
        }
    }
}
