using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure you want to Exit?", "Conform", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook();
            ab.Show();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            label1.Text = signin.CurrentUser;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure you want to LogOut?", "Conform", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                signin sn = new signin();
                sn.Show();
                Visible = false;
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
