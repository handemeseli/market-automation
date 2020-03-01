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
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
        public Form6 frm6;
        public Form7 frm7;
        public Form8 frm8;
        public Form9 frm9;
        public Form10 frm10;
        public Form11 frm11;
        public Form12 frm12;
        public Form13 frm13;
        public Form14 frm14;
        public Form15 frm15;
        public Form16 frm16;
       
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm4 = new Form4();
            frm5 = new Form5();
            frm6 = new Form6();
            frm7 = new Form7();
            frm8 = new Form8();
            frm9 = new Form9();
            frm10 = new Form10();
            frm11 = new Form11();
            frm12 = new Form12();
            frm13 = new Form13();
            frm14 = new Form14();
            frm15 = new Form15();
            frm16 = new Form16();
           
            frm2.frm1 = this;
            frm3.frm1 = this;
            frm4.frm1 = this;
            frm5.frm1 = this;
            frm6.frm1 = this;
            frm7.frm1 = this;
            frm8.frm1 = this;
            frm9.frm1 = this;
            frm10.frm1 = this;
            frm11.frm1 = this;
            frm12.frm1 = this;
            frm13.frm1 = this;
            frm14.frm1 = this;
            frm15.frm1 = this;
            frm16.frm1 = this;
           
        }

        public SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\data.mdf;Integrated Security=True;User Instance=True");
        //bağlantı değişkeni tanımlanıyor//
        public DataTable tabloMusteri = new DataTable();//sanal tablo değişkeni tanımlanıyor       
        public DataTable tabloUrun = new DataTable();//sanal tablo değişkeni tanımlanıyor       
        public DataTable tabloKategori= new DataTable();//sanal tablo değişkeni tanımlanıyor  
        public DataTable tabloFirma = new DataTable();//sanal tablo değişkeni tanımlanıyor  
        public DataTable tabloKasiyer = new DataTable();//sanal tablo değişkeni tanımlanıyor
        public DataTable tabloStok = new DataTable();//sanal tablo değişkeni tanımlanıyor
        public DataTable tabloSatis = new DataTable();//sanal tablo değişkeni tanımlanıyor
        public SqlCommand kmt = new SqlCommand();//sql komut kullanımı değişkeni tanımlanıyor.

        public bool durum;
        public void gununSatisListele()
        {
            tabloSatis.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select faturaNo,musteriAdi,musteriSoyadi,tcKimlik,urunAdi,satisFiyat,adet,toplamTutar,kasaNo,tarih from satisbil Where tarih = '" + dateTimePicker1.Text + "'", bag);
            //tarih alanı dateTimePicker1 seçili tarih olan kayıtları seç
            adtr.Fill(tabloSatis);// tabloSatis sanal tablosunu adaptördeki veri ile doldur.
            dataGridView1.DataSource = tabloSatis;//dataGridView1'in veri kaynağı tabloSatis
            bag.Close();
        }
        public void tcKimlikKasiyerKontrol()
        {
            durum = false;
            byte sayTcKimilk;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select Count (tcKimlik) from kasiyerbil Where tcKimlik='" + frm10.textBox3.Text + "'";
            //kimlik alanı form10 daki textbox3'ın textine eşit olan kayıtları say
            sayTcKimilk = byte.Parse(kmt.ExecuteScalar().ToString());
            //sorguyu sayılarla ifade ederek yürüt ve sayıya çevir.
            if (sayTcKimilk > 0) durum = true;//eğer sayTcKimlik büyük 0 ise yani böyle bir kayıt varsa
            bag.Close();
        }
        public void tcKimlikKontrol()
        {
            durum = false;
            byte sayTcKimilk;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select Count (tcKimlik) from musteribil Where tcKimlik='" + frm2.textBox3.Text + "'";
            sayTcKimilk = byte.Parse(kmt.ExecuteScalar().ToString());
            if (sayTcKimilk > 0) durum = true;
            bag.Close();
        }

        public void urunKontrol()
        {
            durum = false;
            byte sayUrun;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select Count (urunAdi) from stokbil Where urunAdi='" + frm13.comboBox1.Text + "'";
            sayUrun = byte.Parse(kmt.ExecuteScalar().ToString());
            if (sayUrun > 0) durum = true;
            bag.Close();
        }
        public void urunKoduKontrol()
        {
            durum = false;
            byte sayUrunKodu;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select Count (urunKodu) from urunbil Where urunKodu='" + frm5.textBox2.Text + "'";
            sayUrunKodu = byte.Parse(kmt.ExecuteScalar().ToString());
            if (sayUrunKodu> 0) durum = true;
            bag.Close();
        }
        public void musteriListele()
        {
            tabloMusteri.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select musteriAdi,musteriSoyadi,tcKimlik,cepTel,evTel,adres from musteribil", bag);
            adtr.Fill(tabloMusteri);
            frm3.dataGridView1.DataSource = tabloMusteri;
            frm16.dataGridView1.DataSource = tabloMusteri;
            bag.Close();
        }
        public void urunListele()
        {
            tabloUrun.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select urunAdi,urunKodu,firmaAdi,alisFiyati,satisFiyati,kategori from urunbil", bag);
            //urunbil tablosudaki belirtilen alanları seç
            adtr.Fill(tabloUrun);
            frm6.dataGridView1.DataSource = tabloUrun;
            bag.Close();
        }
        public void kategoriListele()
        {
            tabloKategori.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select kategoriAdi from kategoribil", bag);
            adtr.Fill(tabloKategori);
            frm8.dataGridView1.DataSource = tabloKategori;
            bag.Close();
        }
        public void firmaListele()
        {
            tabloFirma.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select firmaAdi,firmaAdresi from firmabil", bag);
            adtr.Fill(tabloFirma);
            frm9.dataGridView1.DataSource = tabloFirma;
            bag.Close();
        }
        public void kasiyerListele()
        {
            tabloKasiyer.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select ad,soyad,tcKimlik,cepTel,evTel,adres,maas,kasaNo,gorevBaslangici,gorevBitimi from kasiyerbil", bag);
            adtr.Fill(tabloKasiyer);
            frm11.dataGridView1.DataSource = tabloKasiyer;
            bag.Close();
        }
        public void stokListele()
        {
            tabloStok.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select urunAdi,adet,birimFiyat,kdv,satisFiyat from stokbil", bag);
            adtr.Fill(tabloStok);
            frm14.dataGridView1.DataSource =tabloStok;
            bag.Close();
        }
        public void urunComboEkle()//girilen kayıtların otomatik olarak combolarda gözükmesini sağlıyor.
        {
            frm13.comboBox1.Items.Clear(); frm15.comboBox1.Items.Clear();
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select urunAdi from urunbil";
            //urunbil tablosundaki urunAdi alanınındaki kayıtları seç
            SqlDataReader oku;
            oku = kmt.ExecuteReader();//soruyu yürüt ve oku .
            while (oku.Read())//okunacak kayıt var olduğu sürece
            {
                if (frm13.comboBox1.Items.IndexOf(oku[0].ToString()) == -1 && oku[0].ToString().Trim() != "") frm13.comboBox1.Items.Add(oku[0].ToString());
                //eğer oku[0] içindeki değer fprm13 deki combo1 de yok ise ve ku[0] içindeki değer boş değilse form13 deki comboya oku[0] değerini aktar.
                if (frm15.comboBox1.Items.IndexOf(oku[0].ToString()) == -1 && oku[0].ToString().Trim() != "") frm15.comboBox1.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
        }

        public void urunSatisComboEkle()//girilen kayıtların otomatik olarak combolarda gözükmesini sağlıyor.
        {
            frm16.comboBox2.Items.Clear();
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select urunAdi from stokbil Where adet>0";
            //urunbil tablosundaki adet değeri sıfırdan büyük olan urunAdi alanınındaki kayıtları seç
            SqlDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                if (frm16.comboBox2.Items.IndexOf(oku[0].ToString()) == -1 && oku[0].ToString().Trim() != "") frm16.comboBox2.Items.Add(oku[0].ToString());

            }
            bag.Close();
            oku.Dispose();
        }
        public void urunSatisFiyatTextEkle()//girilen kayıtların otomatik olarak combolarda gözükmesini sağlıyor.
        {
         
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select urunAdi,satisFiyat from stokbil";
            SqlDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                if (frm16.comboBox2.Text==oku[0].ToString()) frm16.textBox6.Text=oku[1].ToString();
                
            }
            bag.Close();
            oku.Dispose();
        }
        public void firmaComboEkle()//girilen kayıtların otomatik olarak combolarda gözükmesini sağlıyor.
        {
            frm5.comboBox1.Items.Clear();
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select firmaAdi from firmabil";
            SqlDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                if (frm5.comboBox1.Items.IndexOf(oku[0].ToString()) == -1 && oku[0].ToString().Trim() != "") frm5.comboBox1.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
        }
        public void kategoriComboEkle()//girilen kayıtların otomatik olarak combolarda gözükmesini sağlıyor.
        {
            frm5.comboBox2.Items.Clear();
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select kategoriAdi from kategoribil";
            SqlDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                if (frm5.comboBox2.Items.IndexOf(oku[0].ToString()) == -1 && oku[0].ToString().Trim() != "") frm5.comboBox2.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gununSatisListele();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //datagridview1 seçme modunu satırı komple satır seç olarak ayarla               
                dataGridView1.Columns[0].HeaderText = "Fatura No";
                //datagridview1 in 0. sütun başlık metni Fatura No olsun
                dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
                dataGridView1.Columns[2].HeaderText = "Müşteri Soyadı";
                dataGridView1.Columns[3].HeaderText = "Tc Kimlik";
                dataGridView1.Columns[4].HeaderText = "Ürün Adı";
                dataGridView1.Columns[5].HeaderText = "Satış Fiyatı";
                dataGridView1.Columns[6].HeaderText = "Adet";
                dataGridView1.Columns[7].HeaderText = "Toplam Tutar";
                dataGridView1.Columns[8].HeaderText = "Kasa No";
                dataGridView1.Columns[9].HeaderText = "Tarih";
            }
            catch
            {
                ;
            }
        }

        private void btnMusIslem_Click(object sender, EventArgs e)
        {
            frm3.ShowDialog();
            //form3 ü aç.
            
        }

        private void btnUrunIslem_Click(object sender, EventArgs e)
        {
            frm6.ShowDialog();
        }

        private void btnKasiyerIslem_Click(object sender, EventArgs e)
        {
            frm11.ShowDialog();
        }

        private void btnStokIslem_Click(object sender, EventArgs e)
        {
            frm14.ShowDialog();
        }

        private void btnSatisIslem_Click(object sender, EventArgs e)
        {
            frm16.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamadan çık.
        }

        private void btnSatisGoster_Click(object sender, EventArgs e)
        {
            gununSatisListele();
        }
    }
}
