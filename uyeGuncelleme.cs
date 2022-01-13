﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbmsproje
{
    public partial class uyeGuncelle : Form
    {
        string kullid = "";
        string Parola = "";
        public uyeGuncelle()
        {
            InitializeComponent();
        }
        public uyeGuncelle(string id, string parola)
        {
            InitializeComponent();
            kullid = id;
            Parola = parola;
        }

        Giris frm1 = new Giris();


        private void uyeGuncelle_Load(object sender, EventArgs e)
        {

            texboxlarEnteraBasinca();
            try
            {
                Npgsql.NpgsqlConnection baglanti = new Npgsql.NpgsqlConnection("server=localhost; port=5432; Database=postres; user ID=postgres; password: admin ");
                Npgsql.NpgsqlDataAdapter da = new Npgsql.NpgsqlDataAdapter("select * from araclar", baglanti);
                DataSet ds1 = new DataSet();

                baglanti.Open();
                while (x.Read())
                {
                    txtAd.Text = x["Adı"].ToString();
                    txtSoyad.Text = x["Soyadı"].ToString();
                    maskedtxtDogumTarihi.Text = x["DogumTarihi"].ToString();
                    maskedtxtCepTel.Text = x["CepTel"].ToString();
                    txtEposta.Text = x["Eposta"].ToString();
                    txtEpostaTekrar.Text = txtEposta.Text;
                    txtParola.Text = "";
                    txtParolaTekrar.Text = "";
                    if (x["Cinsiyeti"].ToString() == "Bay")
                    {
                        radioButton1.Checked = true;
                    }
                    else if (x["Cinsiyeti"].ToString() == "Bayan")
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                    }
                }


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        bool hata_Varmi = false;
        bool eposta_Hatalimi = false;
        bool parola_Hatalimi = false;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (Control kontroller in this.Controls)
            {
                if (kontroller is MaskedTextBox || kontroller is TextBox)
                {
                    if (kontroller.Text.Trim() == "" || textBox1.Text.Length != 11 || maskedtxtDogumTarihi.Text.Length != 10 || maskedtxtCepTel.Text.Length != 14)
                    {
                        hata_Varmi = true;
                        break;
                    }
                    else
                        hata_Varmi = false;
                }
            }

            if (txtEposta.Text != txtEpostaTekrar.Text)
            {
                errorProviderEPOSTA.SetError(txtEposta, "E-posta Adresleri Eşleşmiyor");
                eposta_Hatalimi = true;
            }
            else
            {
                errorProviderEPOSTA.Dispose();
                eposta_Hatalimi = false;
            }

            if (txtEskiParola.Text == Parola)
            {

                if (txtParola.Text != txtParolaTekrar.Text)
                {
                    errorProviderPAROLA.SetError(txtParola, "Parolala Eşleşmiyor");
                    parola_Hatalimi = true;
                }
                else
                {
                    errorProviderPAROLA.Dispose();
                    parola_Hatalimi = false;
                }
            }
            else
            {
                parola_Hatalimi = true;
                MessageBox.Show("Parola Hatalı");
            }


            if (hata_Varmi || eposta_Hatalimi || parola_Hatalimi)
            {
                errorProvider1.SetError(btnKaydet, "Bilgileri Kontrol Edin");
            }

            if (hata_Varmi == false && eposta_Hatalimi == false && parola_Hatalimi == false)
            {
                foreach (Control kontroller in this.Controls)
                {
                    kontroller.Enabled = false;
                }

                errorProvider1.Dispose();
                uyeEkle();
            }
        }

        void texboxlarEnteraBasinca()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox || txt is MaskedTextBox || txt is RadioButton)
                {
                    txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
                }
                if (txt is TextBox || txt is MaskedTextBox)
                {
                    txt.Text = "";
                }
                if (txt is MaskedTextBox)
                {
                    txt.Text = "1";
                    txt.Text = "";
                }
            }
        }
        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        void uyeEkle()
        {

            string cinsiyet = "Seçilmedi";
            if (radioButton1.Checked == true)
                cinsiyet = "Bay";
            if (radioButton2.Checked == true)
                cinsiyet = "Bayan";


            try
            {
                KontrollerPasif();
                frm1.uyelerBaglantisi.Open();
                //veritabanı update

                MessageBox.Show("İşlem Başarılı");
                frm1.uyelerBaglantisi.Close();
                this.Close();

            }
            catch (Exception mse)
            {
                MessageBox.Show(mse.Message);
                frm1.uyelerBaglantisi.Close();
            }
        }
        void kontrolleriTemizleme()
        {
            foreach (Control kontrol in this.Controls)
            {
                if (kontrol is MaskedTextBox || kontrol is TextBox)
                {
                    kontrol.Text = null;
                }
                kontrol.Enabled = true;
            }
        }
        void KontrollerPasif()
        {
            foreach (Control asd in this.Controls)
            {
                asd.Enabled = false;
            }
        }
        void KontrollerEtkin()
        {
            foreach (Control asd in this.Controls)
            {
                asd.Enabled = true;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox)
                {
                    txt.Text = "";
                    maskedtxtCepTel.Text = "";
                    maskedtxtDogumTarihi.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedtxtCepTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}

