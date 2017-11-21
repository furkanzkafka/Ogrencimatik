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
    public partial class devamsizlik : Form
    {
        public devamsizlik()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ECQIM22\\SQLEXPRESS;Initial Catalog=ogrenciotomasyon;Integrated Security=True");

        DataTable tablo = new DataTable();
        DataSet ds = new DataSet();

        public void temizle()
        {
            txtdnmogrno.Text = "";
            txtdvmara.Text = "";
            txtdvmnara.Text = "";
    
        }
        public void listele()
        {
            SqlCommand sorgu = new SqlCommand("select Ogrenciler.Ad,Ogrenciler.Soyad,Devamsizlik.DevamsizlikTarihi from Ogrenciler INNER JOIN Devamsizlik on Ogrenciler.OgrNo = Devamsizlik.OgrNo", baglan);
            SqlDataAdapter adap = new SqlDataAdapter(sorgu);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxdevamsizlik_CheckedChanged(object sender, EventArgs e)
        {
             
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void devamsizlik_Load(object sender, EventArgs e)
        {

        }

        private void btndvmekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("insert into Devamsizlik(OgrNo) values ('" + txtdnmogrno.Text + "')", baglan);
                komut.ExecuteNonQuery();

                MessageBox.Show("Devamsizlik Bilgisi Eklendi");
                listele();
                temizle();
                baglan.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new Form2();
            frm2.Show();
        }

        private void txtdvmnara_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            tablo.Clear();
            SqlCommand listele = new SqlCommand(@"
select Ogrenciler.Ad,Ogrenciler.Soyad,Devamsizlik.DevamsizlikTarihi from Ogrenciler INNER JOIN Devamsizlik on Ogrenciler.OgrNo = Devamsizlik.OgrNo where Ogrenciler.OgrNo = '" + txtdvmnara.Text + "'", baglan);
            SqlDataAdapter adaptor = new SqlDataAdapter(listele);
            adaptor.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void txtdnmara_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            tablo.Clear();
            SqlCommand sorgu = new SqlCommand(@"
select Ogrenciler.Ad,Ogrenciler.Soyad,Devamsizlik.DevamsizlikTarihi from Ogrenciler INNER JOIN Devamsizlik on Ogrenciler.OgrNo = Devamsizlik.OgrNo where  ad like '" + txtdvmara.Text + "%'", baglan);


            SqlDataAdapter adaptora = new SqlDataAdapter(sorgu);
            adaptora.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
