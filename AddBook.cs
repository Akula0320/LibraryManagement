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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        string cs = "Data Source=localhost\\sqlexpress;Initial Catalog=UserDetails;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBookId.Text != "" && txtBookName.Text != "" && txtAuthor.Text != "" && txtQuantity.Text != "")
            {
                string bookname = txtBookName.Text;
                string bookid = txtBookId.Text;
                string author = txtAuthor.Text;
                string quantity = txtQuantity.Text;
                string date_time = DateTime.Text;

                SqlConnection conn = new SqlConnection(cs);
                string Query = "insert into BookDetails values('" + bookid + "', '" + bookname + "', '" + author + "', '" + quantity + "', '" + date_time + "')";
                SqlCommand cmd = new SqlCommand(Query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    MessageBox.Show("Successfully Added!");
                    txtAuthor.Clear();
                    txtBookName.Clear();
                    txtBookId.Clear();
                    txtQuantity.Clear();
                    DateTime.ResetText();
                    rdr.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
                finally { conn.Close(); }   

            }
            else
            {
                MessageBox.Show("All Fields are Mandetory! ");
            }
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAuthor.Clear();
            txtBookName.Clear();
            txtBookId.Clear();
            txtQuantity.Clear();
            DateTime.ResetText();
        }
    }
}
