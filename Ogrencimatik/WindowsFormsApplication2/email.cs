using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class email : Form
    {
        public email()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ECQIM22\\SQLEXPRESS;Initial Catalog=ogrenciotomasyon;Integrated Security=True");

        public void temizle()
        {
            txtmailad.Text = "";
            txtmailemail.Text = "";
            txtmailkonu.Text = "";
            rtxtmailmsj.Text = "";
        }
        private void email_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {

                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                MailMessage mail = new MailMessage();
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential("/*MAIL ADRES*/", "/*MAIL SIFRE*/");
                
                mail.From = new MailAddress("/*MAIL ADRES*/", "/*MAIL BASLIK*/");

                mail.To.Add(txtmailemail.Text.ToString());

                mail.Subject = txtmailkonu.Text.ToString();
                mail.IsBodyHtml = true;
                mail.Body = rtxtmailmsj.Text.ToString();

                sc.Send(mail);

                MessageBox.Show("Kayıt Eklendi");
                temizle();
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex);
            }

         
        }
    }
}
