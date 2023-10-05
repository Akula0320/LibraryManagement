namespace PROJECT
{
    partial class ForgotPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.secQuestion = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security Question";
            // 
            // secQuestion
            // 
            this.secQuestion.AutoSize = true;
            this.secQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secQuestion.Location = new System.Drawing.Point(239, 111);
            this.secQuestion.Name = "secQuestion";
            this.secQuestion.Size = new System.Drawing.Size(92, 32);
            this.secQuestion.TabIndex = 1;
            this.secQuestion.Text = "label2";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(233, 185);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(378, 22);
            this.txtAnswer.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(188, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Conform";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(445, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Answer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.secQuestion);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label secQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}