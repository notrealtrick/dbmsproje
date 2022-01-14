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
    public partial class Giris : Form
    {

        public Giris()
        {
            InitializeComponent();
        }
        //Npgsql.NpgsqlConnection baglanti = new Npgsql.NpgsqlConnection("server=localhost; port=5432; Database=postres; user ID=postgres; password: admin ");

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        bool giris_Yapildimi = false;
        bool banlanmismi = false;
        bool Admin_Girdimi = false;
        bool Doktor_Girdimi = false;
        void Admin_Girisi()
        {
            if (maskedid.Text == "00000000000" && txtSifre.Text == "0")
            {
                AdminPaneli AmdPanel = new AdminPaneli();
                AmdPanel.Show();
                this.Hide();
                Admin_Girdimi = true;
                giris_Yapildimi = true;
            }
        }

        void Uye_Girisi()
        {
            try
            {

                while (true)
                {
                    if (banlanmismi == false)
                    {
                        kullaniciSayfasi rara = new kullaniciSayfasi(maskedid.Text, txtSifre.Text);
                        rara.Show();
                        this.Hide();
                        giris_Yapildimi = true;
                    }
                }

                if (giris_Yapildimi == false)
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı/Parola");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Sağlanamadı");
            }
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Admin_Girisi();

            if (Admin_Girdimi == false && Doktor_Girdimi == false)
            {
                Uye_Girisi();
            }
        }

        private void btnYeniUye_Click(object sender, EventArgs e)
        {
            yeniUye yeniuye = new yeniUye();
            yeniuye.ShowDialog();
        }

        private void maskedtxtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtParola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnGiris_Click(sender, e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void maskedtxtTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
