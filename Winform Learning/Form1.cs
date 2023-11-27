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
using System.Net;
using System.Net.Mail;

namespace Winform_Learning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9IR0561\SQLEXPRESS;Initial Catalog=Zoo;Integrated Security=True");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("exec insrt_anml " + Convert.ToInt32(textBox1.Text) + ", '" + textBox2.Text + "', '" + textBox3.Text +
                "'," + Convert.ToInt32(textBox4.Text), con);
            cmd.ExecuteNonQuery();
            con.Close();
            showTable();
        }

        private void showTable()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("exec slct_anml", con);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adptr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void SendMail_Click(object sender, EventArgs e)
        {
            MailMessage mm = new MailMessage(SenderMail.Text, MailToSend.Text);
            mm.Subject = Subject.Text;
            mm.Body = Content.Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new NetworkCredential(SenderMail.Text, "abll wwyg dypk lhvb");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(mm);
        }


    }
}
