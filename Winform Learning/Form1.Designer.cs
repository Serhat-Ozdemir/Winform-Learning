
namespace Winform_Learning
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MailToSend = new System.Windows.Forms.TextBox();
            this.Content = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.SendMail = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.TextBox();
            this.SenderMail = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.SenderPassword = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(210, 218);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(61, 222);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "AGE";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(61, 134);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "TYPE";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(61, 177);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "KIND";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(61, 92);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "CAGE ID";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // MailToSend
            // 
            this.MailToSend.Location = new System.Drawing.Point(818, 92);
            this.MailToSend.Name = "MailToSend";
            this.MailToSend.Size = new System.Drawing.Size(162, 22);
            this.MailToSend.TabIndex = 11;
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(818, 177);
            this.Content.Multiline = true;
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(241, 150);
            this.Content.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(702, 92);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 15;
            this.textBox9.Text = "To";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(702, 134);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 16;
            this.textBox10.Text = "Subject";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SendMail
            // 
            this.SendMail.Location = new System.Drawing.Point(959, 383);
            this.SendMail.Name = "SendMail";
            this.SendMail.Size = new System.Drawing.Size(100, 23);
            this.SendMail.TabIndex = 17;
            this.SendMail.Text = "Send";
            this.SendMail.UseVisualStyleBackColor = true;
            this.SendMail.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(818, 134);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(162, 22);
            this.Subject.TabIndex = 18;
            // 
            // SenderMail
            // 
            this.SenderMail.Location = new System.Drawing.Point(818, 49);
            this.SenderMail.Name = "SenderMail";
            this.SenderMail.Size = new System.Drawing.Size(162, 22);
            this.SenderMail.TabIndex = 19;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1015, 49);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 20;
            this.textBox12.Text = "Password";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SenderPassword
            // 
            this.SenderPassword.Location = new System.Drawing.Point(1121, 49);
            this.SenderPassword.Name = "SenderPassword";
            this.SenderPassword.Size = new System.Drawing.Size(162, 22);
            this.SenderPassword.TabIndex = 21;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(702, 49);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 22;
            this.textBox14.Text = "From";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 645);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.SenderPassword);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.SenderMail);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.SendMail);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.MailToSend);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox MailToSend;
        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button SendMail;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.TextBox SenderMail;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox SenderPassword;
        private System.Windows.Forms.TextBox textBox14;
    }
}

