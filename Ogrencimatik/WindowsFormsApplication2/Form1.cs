using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ECQIM22\\SQLEXPRESS;Initial Catalog=ogrenciotomasyon;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Islem Iptal Edildi...");
            txtAd.Text = "";
            txtSifre.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlParameter kad = new SqlParameter("@kadi", txtAd.Text);
                SqlParameter sifre = new SqlParameter("@sifre", txtSifre.Text);

                string sorgu = "select * from uye where KullaniciAd=@kadi and Sifre=@sifre";
                SqlCommand komut = new SqlCommand(sorgu, baglan);

                //SqlCommand sorgu = new SqlCommand("select * from Kullanici where KullaniciAdi=@kadi and Sifre=@sifre", baglan);
                komut.Parameters.Add(kad);
                komut.Parameters.Add(sifre);

                SqlDataAdapter adap = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                adap.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Hoşgeldiniz " + txtAd.Text);
                    txtAd.Text = "";
                    txtSifre.Text = "";

                    this.Hide();
                    Form frm2 = new Form2();
                    frm2.Show();

                }

                else
                {
                    MessageBox.Show("Kullanıcı adını veya şifreyi yanlış girdiniz");
                    txtAd.Text = "";
                    txtSifre.Text = "";
                }
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex);
            }

        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
           
                txtSifre.PasswordChar = '\0';
         

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


