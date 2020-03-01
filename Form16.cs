using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace market_takip
{
    public partial class Form16 : Form
    {
        public Form1 frm1;
        public Form16()
        {
            InitializeComponent();
        }
        bool durum = false;
      void stokUrunAdetKontrol()
        {
            
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "Select adet from stokbil Where urunAdi='" + comboBox2.Text + "'";
            SqlDataReader oku;
            oku = frm1.kmt.ExecuteReader();
            while (oku.Read())
            {
                if (int.Parse(textBox7.Text) <= int.Parse(oku[0].ToString())) durum = true;
            }
            frm1.kmt.Dispose();//Komut kullanımını kapatıyoruz
            frm1.bag.Close(); //veritabanımızı kapatıyoruz  
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            frm1.musteriListele();
            frm1.urunSatisComboEkle();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "Müşteri Adı";
                dataGridView1.Columns[1].HeaderText = "Müşteri Soyadı";
                dataGridView1.Columns[2].HeaderText = "Tc Kimlik";
                dataGridView1.Columns[3].HeaderText = "Cep Tel";
                dataGridView1.Columns[4].HeaderText = "Ev Tel";
                dataGridView1.Columns[5].HeaderText = "Adres";
            }
            catch
            {
                ;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select musteriAdi,musteriSoyadi,tcKimlik,cepTel,evTel,adres From musteribil", frm1.bag);
            string alan = "";
            if (comboBox1.Text == "Müşteri Adı") alan = "musteriAdi";
            else if (comboBox1.Text == "Müşteri Soyadı") alan = "musteriSoyadi";
            else if (comboBox1.Text == "Tc Kimlik") alan = "tcKimlik";
            else if (comboBox1.Text == "Cep Tel") alan = "cepTel";
            else if (comboBox1.Text == "Ev Tel") alan = "evTel";
            else if (comboBox1.Text == "Adres") alan = "adres";

            if (comboBox1.Text == "Tümü")//eğer texbox boş ise
            {
                frm1.bag.Open();
                frm1.tabloMusteri.Clear();
                frm1.kmt.Connection = frm1.bag;
                frm1.kmt.CommandText = "Select musteriAdi,musteriSoyadi,tcKimlik,cepTel,evTel,adres from musteribil";//tüm kayıtları seç
                adtr.SelectCommand = frm1.kmt;
                adtr.Fill(frm1.tabloMusteri);
                frm1.bag.Close();
            }
            if (alan != "")
            {
                frm1.bag.Open();
                adtr.SelectCommand.CommandText = " Select musteriAdi,musteriSoyadi,tcKimlik,cepTel,evTel,adres From musteribil" + " where(" + alan + " like '%" + textBox1.Text + "%' )";
                frm1.tabloMusteri.Clear();
                adtr.Fill(frm1.tabloMusteri);
                frm1.bag.Close();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
          
            if (textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox7.Text.Trim() != "" && textBox6.Text.Trim() != "")
            {
                stokUrunAdetKontrol();
                if (durum == true)
                {
                    int adet;
                    adet = int.Parse(textBox7.Text);
                    frm1.bag.Open();
                    frm1.kmt.Connection = frm1.bag;
                    frm1.kmt.CommandText = "INSERT INTO satisbil(faturaNo,musteriAdi,musteriSoyadi,tcKimlik,urunAdi,satisFiyat,adet,toplamTutar,kasaNo,tarih) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + dateTimePicker1.Text + "') ";
                    //kayıt ekleme sordu metni
                    frm1.kmt.ExecuteNonQuery();//sorguyu çalıştır                    
                    frm1.kmt.CommandText = "UPDATE stokbil SET adet=adet-'" + adet + "' WHERE urunAdi='" + comboBox2.Text + "' ";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.Dispose();//Komut kullanımını kapatıyoruz
                    frm1.bag.Close(); //veritabanımızı kapatıyoruz  
                    frm1.gununSatisListele();
                    frm1.urunSatisComboEkle();
                    MessageBox.Show("Kayıt işlemi tamamlandı ! ");
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                    }
                    comboBox2.Text = "";
                }
                else MessageBox.Show("Stokta yeterli sayıda ürün yok !!!");
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz !!!");
            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            frm1.urunSatisFiyatTextEkle();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox8.Text = (int.Parse(textBox6.Text) * int.Parse(textBox7.Text)).ToString();
            }
            catch
            {
                ;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
