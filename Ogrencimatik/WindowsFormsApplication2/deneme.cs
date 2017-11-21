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
    public partial class deneme : Form
    {
        public deneme()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ECQIM22\\SQLEXPRESS;Initial Catalog=ogrenciotomasyon;Integrated Security=True");

        DataTable tablo = new DataTable();
        DataSet ds = new DataSet();

        public void temizle()
        {
            txtdnmogrno.Text = "";
            txtdnmicrk.Text = "";
            txtdnmsrsys.Text = "";
            txtdnmdgr.Text = "";
            txtdnmynls.Text = "";
            txtdnmsrsys.Text = "";
            txtdnmbs.Text = "";
         
        }
        public void listele()
        {
            SqlCommand sorgu = new SqlCommand("select Deneme.DenemeNo, Ogrenciler.Ad,Ogrenciler.Soyad,DenemeIcerik, DenemeSoruSayisi, DogruSayisi, YanlisSayisi, BosSayisi from Ogrenciler INNER JOIN Deneme on Ogrenciler.OgrNo = Deneme.OgrNo", baglan);
            SqlDataAdapter adap = new SqlDataAdapter(sorgu);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void deneme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand sorgu = new SqlCommand(@"
select Deneme.DenemeNo,Ogrenciler.Ad,Ogrenciler.Soyad,DenemeIcerik, DenemeSoruSayisi, DogruSayisi, YanlisSayisi, BosSayisi from Ogrenciler INNER JOIN Deneme on Ogrenciler.OgrNo = Deneme.OgrNo where Ogrenciler.OgrNo='" + txtdnmnara.Text + "'"

, baglan);
            SqlDataAdapter dr = new SqlDataAdapter(sorgu);
            DataSet ds = new DataSet();
            dr.Fill(ds, "bilgi");
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();

        }

        private void txdnmara_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            tablo.Clear();
            SqlCommand sorgu = new SqlCommand(@"
select Deneme.DenemeNo,Ogrenciler.Ad,Ogrenciler.Soyad,DenemeIcerik, DenemeSoruSayisi, DogruSayisi, YanlisSayisi, BosSayisi from Ogrenciler INNER JOIN Deneme on Ogrenciler.OgrNo = Deneme.OgrNo where  ad like '" + txtdnmara.Text + "%'", baglan);


            SqlDataAdapter adaptora = new SqlDataAdapter(sorgu);
            adaptora.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new Form2();
            frm2.Show();
        }

        private void btndnmekle_Click(object sender, EventArgs e)
        {
       
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("insert into Deneme(OgrNo,DenemeIcerik,DenemeSoruSayisi,DogruSayisi,YanlisSayisi,BosSayisi) values ('" + txtdnmogrno.Text + "','" + txtdnmicrk.Text + "','" + txtdnmsrsys.Text + "','" + txtdnmdgr.Text + "','" + txtdnmynls.Text + "','" + txtdnmsrsys.Text +  "')", baglan);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btndnmiptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Islem Iptal Edildi...");
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp = MessageBox.Show("Kaydı silmek istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (cvp == DialogResult.Yes)
            {

                baglan.Open();
                SqlCommand sorgu =
                    new SqlCommand(
                        "delete from Deneme where DenemeNo='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'",
                        baglan);

                //SqlCommand sorgu = new SqlCommand("delete from Ogrenciler where ogrNo='" + txtogrNosil.Text + "'", baglan);
                //  txtoglssil.Text = "";

                sorgu.ExecuteNonQuery(); // sql kaydı silmek için
                baglan.Close();
                MessageBox.Show("Kayıt Silindi");
                listele();

            }

        }
    }
}
