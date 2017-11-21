using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnogrekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmogrencikayit = new ogrencikayit();
            frmogrencikayit.Show();
        }

        private void btncks2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnposta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form emailForm = new email();
            emailForm.Show();
        }

        private void btnogrlst_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmogrlistele = new ogrlistele();
            frmogrlistele.Show();
        }

        private void btndeneme_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmdenemebilgiler = new deneme();
            frmdenemebilgiler.Show();
        }

        private void btnkonu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmkonuilerleme =new konuilerleme();
            frmkonuilerleme.Show();
        }

        private void btnyedek_Click(object sender, EventArgs e)
        {

        }

        private void btndvmszlk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmdevamsizlik = new devamsizlik();
            frmdevamsizlik.Show();
        }
    }
}
