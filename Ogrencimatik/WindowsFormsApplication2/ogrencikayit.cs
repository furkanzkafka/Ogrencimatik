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
    public partial class ogrencikayit : Form
    {
        public ogrencikayit()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ECQIM22\\SQLEXPRESS;Initial Catalog=ogrenciotomasyon;Integrated Security=True");

        SqlDataAdapter adaptor = new SqlDataAdapter();
        DataSet ds = new DataSet();


        public void temizle()
        {
            txtogrkytad.Text = "";
            txtogrkytsoyad.Text = "";
            txtogrkytilce.Text = "";
            mtxtogrkyttel.Text = "";
            txtogrkytegtm.Text = "";
            rtxtogrkytadrs.Text = "";
            txtogrkytokl.Text = "";
            txtogrkytdonem.Text = "";
            txtogrkytvad.Text = "";
            txtogrkytvsyd.Text = "";
            txtogrkytvtel.Text = "";
            txtogrkytvmail.Text = "";
            rbtnogrkyterk.Checked = false;
            rbtnogrkytkdn.Checked = false;

        }

        private void ogrencikayit_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnogrkytiptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("işleminiz iptal edildi");
            temizle();
        }

        private void btnogrkytekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("insert into Ogrenciler(Ad,Soyad,Adres,Tel,EgitimDurumu,Ilce,Cinsiyet,Okul,Donem,VeliAd,VeliSoyad,VeliTel,VeliMail) values ('" + txtogrkytad.Text + "','" + txtogrkytsoyad.Text + "','" + rtxtogrkytadrs.Text + "','" + mtxtogrkyttel.Text + "','" + txtogrkytegtm.Text + "','" + txtogrkytilce.Text + "','" + rbtnogrkytkdn.Checked + "','" +txtogrkytokl.Text + "','" + txtogrkytdonem.Text + "','" + txtogrkytvad.Text + "','" + txtogrkytvsyd.Text + "','" + txtogrkytvtel.Text + "','" + txtogrkytvmail.Text + "')", baglan);
                komut.ExecuteNonQuery();

               

                MessageBox.Show("Kayıt Eklendi");
                temizle();
                baglan.Close();

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex);
            }

        }

        private void rbtnogrkyterk_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new Form2();
            frm2.Show();
        }
    }
}

