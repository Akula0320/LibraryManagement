namespace PROJECT
{
    partial class Dashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbord));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.issueBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.completeBookDetailsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.viewBookInfoToolStripMenuItem});
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(113, 54);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addBookToolStripMenuItem.Image")));
            this.addBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(218, 56);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // viewBookInfoToolStripMenuItem
            // 
            this.viewBookInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBookInfoToolStripMenuItem.Image")));
            this.viewBookInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewBookInfoToolStripMenuItem.Name = "viewBookInfoToolStripMenuItem";
            this.viewBookInfoToolStripMenuItem.Size = new System.Drawing.Size(218, 56);
            this.viewBookInfoToolStripMenuItem.Text = "View BookInfo";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.studentInfoToolStripMenuItem});
            this.studentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentToolStripMenuItem.Image")));
            this.studentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(124, 54);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStudentToolStripMenuItem.Image")));
            this.addStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(205, 56);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            // 
            // studentInfoToolStripMenuItem
            // 
            this.studentInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentInfoToolStripMenuItem.Image")));
            this.studentInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentInfoToolStripMenuItem.Name = "studentInfoToolStripMenuItem";
            this.studentInfoToolStripMenuItem.Size = new System.Drawing.Size(205, 56);
            this.studentInfoToolStripMenuItem.Text = "Student Info";
            // 
            // issueBooksToolStripMenuItem
            // 
            this.issueBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueBooksToolStripMenuItem.Image")));
            this.issueBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            this.issueBooksToolStripMenuItem.Size = new System.Drawing.Size(149, 54);
            this.issueBooksToolStripMenuItem.Text = "Issue Books";
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.returnBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnBooksToolStripMenuItem.Image")));
            this.returnBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(160, 54);
            this.returnBooksToolStripMenuItem.Text = "Return Books";
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            this.completeBookDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("completeBookDetailsToolStripMenuItem.Image")));
            this.completeBookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            this.completeBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(226, 54);
            this.completeBookDetailsToolStripMenuItem.Text = "Complete Book Details";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(97, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(64, 54);
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(175, 56);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1061, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "USER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}