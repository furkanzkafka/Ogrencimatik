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
    public partial class ogrlistele : Form
    {
        public ogrlistele()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ECQIM22\\SQLEXPRESS;Initial Catalog=ogrenciotomasyon;Integrated Security=True");

        DataTable tablo = new DataTable();


        public void listele()
        {
            SqlCommand sorgu = new SqlCommand("select * From Ogrenciler", baglan);
            SqlDataAdapter adap = new SqlDataAdapter(sorgu);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ogrlsls_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand sorgu = new SqlCommand("select * from Ogrenciler", baglan);
                SqlDataAdapter dr = new SqlDataAdapter(sorgu);
                DataSet ds = new DataSet();
                dr.Fill(ds, "bilgi");
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();

            }


            catch (Exception hata)
            {

                MessageBox.Show("hata olştu " + hata);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmogrencikayit = new ogrencikayit();
            frmogrencikayit.Show();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp = MessageBox.Show("Kaydı silmek istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cvp == DialogResult.Yes)
            {

                baglan.Open();
                SqlCommand sorgu = new SqlCommand("delete from Ogrenciler where ogrNo='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglan);

                 //SqlCommand sorgu = new SqlCommand("delete from Ogrenciler where ogrNo='" + txtogrNosil.Text + "'", baglan);
              //  txtoglssil.Text = "";

                sorgu.ExecuteNonQuery(); // sql kaydı silmek için
                baglan.Close();
                MessageBox.Show("Kayıt Silindi");
                listele();

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new Form2();
            frm2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand sorgus = new SqlCommand("select * from Ogrenciler", baglan);
                SqlDataAdapter dr = new SqlDataAdapter(sorgus);
                DataSet ds = new DataSet();
                dr.Fill(ds, "bilgi");
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();

            }


            catch (Exception hata)
            {

                MessageBox.Show("hata olştu " + hata);
            }
               tablo.Clear();
                    SqlCommand sorgu = new SqlCommand("select * from Ogrenciler where ad like '" + txtogrlsara.Text + "%'", baglan);
                    SqlDataAdapter adaptora = new SqlDataAdapter(sorgu);
                    adaptora.Fill(tablo);
                    dataGridView1.DataSource = tablo;
           
        }

        private void txtogrlsnara_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
           
            tablo.Clear();
            SqlCommand listele = new SqlCommand("select * from Ogrenciler where ogrNo='" + txtogrlsnara.Text + "'", baglan);
            SqlDataAdapter adaptor = new SqlDataAdapter(listele);
            adaptor.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ogrlistele_Load(object sender, EventArgs e)
        {

        }
    }
}
