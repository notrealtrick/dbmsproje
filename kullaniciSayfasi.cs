using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace dbmsproje
{
    public partial class kullaniciSayfasi : Form
    {

        string tcNo = "";
        string Parola = "";

        public kullaniciSayfasi(string tc, string parola)
        {
            InitializeComponent();
            tcNo = tc;
            Parola = parola;
        }

        Giris frm1 = new Giris();
        DateTime datee = DateTime.Now;
        int uye_Sayisi = 0;
        

        void uyeBilgileriniGoster()
        {

            Npgsql.NpgsqlConnection baglanti = new Npgsql.NpgsqlConnection("server=localhost; port=5432; Database=postres; user ID=postgres; password: admin ");
            Npgsql.NpgsqlDataAdapter da = new Npgsql.NpgsqlDataAdapter("select * from araclar", baglanti);
            DataSet ds1 = new DataSet();

            baglanti.Open();
            //baglanti.ConnectionString="insert into araclar (id"

            while (x.Read())
            {
                lblTC.Text = x["id"].ToString();
                lblAdSoyad.Text = x["Adı"].ToString() + " " + x["Soyadı"].ToString();
                lblCinsiyet.Text = x["Cinsiyeti"].ToString();
                lblTel.Text = x["Ceptel"].ToString();
            }
            frm1.uyelerBaglantisi.Close();
        } 
        void asd_Click(object sender, EventArgs e)
        {

        }

        private void randevuAra_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm1.uyelerBaglantisi.Close();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void altyazıyıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uyeBilgileriniGoster();
        }
        private void lblHastaneAdi_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeGuncelle guncelle = new uyeGuncelle(lblTC.Text, Parola);
            guncelle.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTel_Click(object sender, EventArgs e)
        {

        }

        private void lblCinsiyet_Click(object sender, EventArgs e)
        {

        }

        private void kullaniciSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTC_Click(object sender, EventArgs e)
        {

        }

        private void lblAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void labeldogum_Click(object sender, EventArgs e)
        {

        }
    }
}
