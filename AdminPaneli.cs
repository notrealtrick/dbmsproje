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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        Giris frm1 = new Giris();
        int uye_Sayisi = 0;
        //Npgsql.NpgsqlConnection baglanti = new Npgsql.NpgsqlConnection("server=localhost; port=5432; Database=postres; user ID=Postgres; password: admin ");


        private void AdminPaneli_Load(object sender, EventArgs e)
        {
          

        }

        private void AdminPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris frm1 = new Giris();
            frm1.Show();
            this.Hide();
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            DateTime dateSaat = DateTime.Now;
            lblSaat.Text = dateSaat.ToLongTimeString();
            lblTarih.Text = dateSaat.ToLongDateString();
        }

        void UyeleriGetir()
        {
            listView1.Items.Clear();
            int i = 0;
            
        }

        void UyeleriGetirpost()
        {
            Npgsql.NpgsqlConnection baglanti = new Npgsql.NpgsqlConnection("server=localhost; port=5432; Database=postres; user ID=postgres; password: admin ");
            Npgsql.NpgsqlDataAdapter da = new Npgsql.NpgsqlDataAdapter("select * from araclar", baglanti);
            DataSet ds1 = new DataSet();
            baglanti.Open();
            baglanti.ConnectionString = "SELECT * FROM admin.araclar";






        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            string id = "";
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                id = itm.SubItems[0].Text;
            }
            try
            {
                UyeleriGetir();
                uye_Sayisi = 0;
                uyeSayisiHesapla();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = "";
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                id = itm.SubItems[0].Text;
            }


            try
            {
                
            }
            catch (Exception hata)
            {
                if (hata.Message == "Input string was not in a correct format.")
                {

                }
                else
                {
                    MessageBox.Show(hata.Message);
                }

            }
        }
        void uyeSayisiHesapla()
        {
            try
            {
                Npgsql.NpgsqlConnection baglanti = new Npgsql.NpgsqlConnection("server=localhost; port=5432; Database=postres; user ID=postgres; password: admin ");
                Npgsql.NpgsqlDataAdapter da = new Npgsql.NpgsqlDataAdapter("select * from araclar", baglanti);
                DataSet ds1 = new DataSet();

                baglanti.Open();
                lblUyeSayisi.Text = "Sistemde " + uye_Sayisi + " Adet Üye Bulunmaktadır";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris frm1 = new Giris();
            frm1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUyeSayisi_Click(object sender, EventArgs e)
        {

        }

        private void lblSaat_Click(object sender, EventArgs e)
        {

        }

        private void lblTarih_Click(object sender, EventArgs e)
        {

        }
    }
}
