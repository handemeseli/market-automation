using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace market_takip
{
    public partial class Form5 : Form
    {
        public Form1 frm1;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            frm1.firmaComboEkle();
            frm1.kategoriComboEkle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frm1.urunKoduKontrol();
            if (frm1.durum == false)
            {
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
                {
                    frm1.bag.Open();
                    frm1.kmt.Connection = frm1.bag;
                    frm1.kmt.CommandText = "INSERT INTO urunbil(urunAdi,urunKodu,firmaAdi,alisFiyati,satisFiyati,kategori) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" +comboBox2.Text+ "') ";
                    //kayıt ekleme sorgu metni
                    frm1.kmt.ExecuteNonQuery();//sorguyu çalıştır                                                      
                    frm1.kmt.Dispose();//Komut kullanımını kapatıyoruz
                    frm1.bag.Close(); //veritabanımızı kapatıyoruz
                    frm1.urunListele();
                    MessageBox.Show("Kayıt işlemi tamamlandı ! ");
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                        if (this.Controls[i] is ComboBox) this.Controls[i].Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Ürün Adı - Ürün Kodu alanlarını boş bırakmayınız !!!");
                }
            }
            else MessageBox.Show("Girmiş olduğunuz Ürün Kodu mevcut !");
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm1.frm8.ShowDialog();//form8 i aç
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm1.frm9.ShowDialog();
        }
    }
}
