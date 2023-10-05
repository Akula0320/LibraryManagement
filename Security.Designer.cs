namespace PROJECT
{
    partial class Security
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Conform = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Security Question";
            // 
            // txtSQuestion
            // 
            this.txtSQuestion.Location = new System.Drawing.Point(266, 170);
            this.txtSQuestion.Name = "txtSQuestion";
            this.txtSQuestion.Size = new System.Drawing.Size(468, 22);
            this.txtSQuestion.TabIndex = 2;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(266, 228);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(468, 22);
            this.txtAnswer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(102, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Answer";
            // 
            // Conform
            // 
            this.Conform.BackColor = System.Drawing.Color.Lime;
            this.Conform.Location = new System.Drawing.Point(204, 381);
            this.Conform.Name = "Conform";
            this.Conform.Size = new System.Drawing.Size(188, 37);
            this.Conform.TabIndex = 5;
            this.Conform.Text = "Conform";
            this.Conform.UseVisualStyleBackColor = false;
            this.Conform.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Red;
            this.Reset.Location = new System.Drawing.Point(537, 381);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(188, 37);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(28, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confrim Answer";
            // 
            // txtCAnswer
            // 
            this.txtCAnswer.Location = new System.Drawing.Point(266, 289);
            this.txtCAnswer.Name = "txtCAnswer";
            this.txtCAnswer.Size = new System.Drawing.Size(468, 22);
            this.txtCAnswer.TabIndex = 8;
            // 
            // Security
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Conform);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtSQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Security";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security";
            this.Load += new System.EventHandler(this.Security_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Conform;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCAnswer;
    }
}