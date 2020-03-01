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
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frm1.tcKimlikKontrol();//form1 deki tcKimlikKontrol prosedürüne git ve çalıştır.
            if (frm1.durum == false) // eğer form1 deki durum değişkeni false ise
            {
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
                //eğer textbox1,textbox2,textbox3 boş değilse
                {
                    frm1.bag.Open();
                    frm1.kmt.Connection = frm1.bag;//form1deki kmt nin bağlantısı form1 deki bag dır.
                    frm1.kmt.CommandText = "INSERT INTO musteribil(musteriAdi,musteriSoyadi,tcKimlik,cepTel,evTel,adres) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
                    //kayıt ekleme sorgu metni
                    frm1.kmt.ExecuteNonQuery();//sorguyu çalıştır                                                      
                    frm1.kmt.Dispose();//Komut kullanımını kapatıyoruz
                    frm1.bag.Close(); //veritabanımızı kapatıyoruz
                    frm1.musteriListele();//form1 deki musteriListele prosedürüne git ve çalıştır.
                    MessageBox.Show("Kayıt işlemi tamamlandı ! ");
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (this.Controls[i] is TextBox) this.Controls[i].Text = "";// formdaki tüm textboxların içini boşalt.
                    }
                }
                else //değilse uyarı mesajı yaz
                { 
                    MessageBox.Show("Lütfen Ad-Soyad-Tckimlik alanlarını boş bırakmayınız !!!");
                }
            }
            else MessageBox.Show("Girmiş olduğunuz Tc Kimlik mevcut !");//değilse uyarı mesajı yaz
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();  //aktif formu kapat
        }
    }
}
