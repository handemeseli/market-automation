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
    public partial class Form10 : Form
    {
        public Form1 frm1;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frm1.tcKimlikKasiyerKontrol();
            if (frm1.durum == false)
            {
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
                //eğer textbox1,textbox2,textbox3 boş değilse
                {
                    frm1.bag.Open();//form1deki bag isimli bağlantıyı aç
                    frm1.kmt.Connection = frm1.bag;//form1deki kmt nin bağlantısı form1 deki bag dır.
                    frm1.kmt.CommandText = "INSERT INTO kasiyerbil(ad,soyad,tcKimlik,cepTel,evTel,adres,maas,kasaNo,gorevBaslangici,gorevBitimi) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + dateTimePicker1.Text + "','" +dateTimePicker2.Text+ "') ";
                    //kayıt ekleme sorgusu
                    frm1.kmt.ExecuteNonQuery();//sorguyu çalıştır                                                      
                    frm1.kmt.Dispose();//Komut kullanımını kapatıyoruz
                    frm1.bag.Close(); //veritabanımızı kapatıyoruz
                    frm1.kasiyerListele();
                    MessageBox.Show("Kayıt işlemi tamamlandı ! ");
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (this.Controls[i] is TextBox) this.Controls[i].Text = "";// formdaki tüm textboxların içini boşalt.
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Ad-Soyad-Tckimlik alanlarını boş bırakmayınız !!!");
                }
            }
            else MessageBox.Show("Girmiş olduğunuz Tc Kimlik mevcut !");
        }
    }
}
