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
    public partial class konuilerleme : Form
    {
        public konuilerleme()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ECQIM22\\SQLEXPRESS;Initial Catalog=ogrenciotomasyon;Integrated Security=True");

        DataTable tablo = new DataTable();
        DataSet ds = new DataSet();

        public void temizle()
        {
            txtknogrno.Text = "";
            txtknders.Text = "";
            txtknkn.Text = "";
            txtknsrsy.Text = "";
            
        }
        public void listele()
        {
            SqlCommand sorgu = new SqlCommand("select Konu.OgrNo, Ogrenciler.Ad, Ogrenciler.Soyad, Konu.Ders, Konu.IslenenKonu, Konu.CozulenSoru, Konu.IslenmeTarihi from Ogrenciler INNER JOIN Konu on Ogrenciler.OgrNo = Konu.OgrNo", baglan);
            SqlDataAdapter adap = new SqlDataAdapter(sorgu);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            tablo.Clear();
            SqlCommand sorgu = new SqlCommand(@"
select Konu.OgrNo,Ogrenciler.Ad,Ogrenciler.Soyad,Konu.Ders,Konu.IslenenKonu,Konu.CozulenSoru,Konu.IslenmeTarihi from Ogrenciler INNER JOIN Konu on Ogrenciler.OgrNo = Konu.OgrNo where  ad like '" + txtkonuara.Text + "%'", baglan);


            SqlDataAdapter adaptora = new SqlDataAdapter(sorgu);
            adaptora.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand sorgu = new SqlCommand(@"select Konu.OgrNo,Ogrenciler.Ad,Ogrenciler.Soyad,Konu.Ders,Konu.IslenenKonu,Konu.CozulenSoru,Konu.IslenmeTarihi from Ogrenciler INNER JOIN Konu on Ogrenciler.OgrNo = Konu.OgrNo where Ogrenciler.OgrNo='" + txtkonunara.Text + "'", baglan);
            SqlDataAdapter dr = new SqlDataAdapter(sorgu);
            DataSet ds = new DataSet();
            dr.Fill(ds, "bilgi");
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new Form2();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("insert into Konu(OgrNo,Ders,IslenenKonu,CozulenSoru) values ('" + txtknogrno.Text + "','" + txtknders.Text + "','" + txtknkn.Text + "','" + txtknsrsy.Text + "')", baglan);
                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt Eklendi");
                listele();
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
