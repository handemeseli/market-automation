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
    public partial class Form14 : Form
    {
        public Form1 frm1;
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            frm1.stokListele();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "Ürün Adı";
                dataGridView1.Columns[1].HeaderText = "Adet";
                dataGridView1.Columns[2].HeaderText = "Birim Fiyat";
                dataGridView1.Columns[3].HeaderText = "Kdv";
                dataGridView1.Columns[4].HeaderText = "Satış Fiyatı";
            }
            catch
            {
                ;
            }
        }

        private void yeniEkle_Click(object sender, EventArgs e)
        {
            frm1.frm13.ShowDialog();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes && dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
                {
                    frm1.bag.Open();
                    frm1.kmt.Connection = frm1.bag;
                    frm1.kmt.CommandText = "DELETE from stokbil WHERE urunAdi='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.Dispose();
                    frm1.bag.Close();
                    frm1.stokListele();
                }
            }
            catch
            {
                ;
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
            {
                int adet;
               
                adet = int.Parse(textBox3.Text);
                //adet değişkenine textbox3 deki değeri ata.
                frm1.bag.Open();
                frm1.kmt.Connection = frm1.bag;
                
                frm1.kmt.CommandText = "UPDATE stokbil SET adet=adet+'"+adet+"' WHERE urunAdi='" + textBox2.Text + "' ";
                //urunAdi textbox2 texti olan kaydın adet alan değerini adet değişkeni kadar artır.
                frm1.kmt.ExecuteNonQuery();
                frm1.kmt.Dispose();
                frm1.bag.Close();
                frm1.stokListele();
                
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız !!!");
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            frm1.frm15.comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //form15 deki combo1 in textine datagridview1 deki seçili satırın 0. hücresindeki değeri yaz.
            frm1.frm15.textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm1.frm15.textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm1.frm15.textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();            
            frm1.frm15.ShowDialog();
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select urunAdi,adet,birimFiyat,kdv,satisFiyat From stokbil", frm1.bag);
            string alan = "";
            if (comboBox1.Text == "Ürün Adı") alan = "urunAdi";
            else if (comboBox1.Text == "Adet") alan = "adet";
            else if (comboBox1.Text == "Birim Fiyat") alan = "birimFiyat";
            else if (comboBox1.Text == "Kdv") alan = "kdv";
            else if (comboBox1.Text == "Satış Fiyatı") alan = "satisFiyat";
           
            if (comboBox1.Text == "Tümü")//eğer texbox boş ise
            {
                frm1.bag.Open();
                frm1.tabloStok.Clear();
                frm1.kmt.Connection = frm1.bag;
                frm1.kmt.CommandText = "Select urunAdi,adet,birimFiyat,kdv,satisFiyat from stokbil";//tüm kayıtları seç
                adtr.SelectCommand = frm1.kmt;
                adtr.Fill(frm1.tabloStok);
                frm1.bag.Close();
            }
            if (alan != "")
            {
                frm1.bag.Open();
                adtr.SelectCommand.CommandText = " Select urunAdi,adet,birimFiyat,kdv,satisFiyat From stokbil" + " where(" + alan + " like '%" + textBox1.Text + "%' )";
                frm1.tabloStok.Clear();
                adtr.Fill(frm1.tabloStok);
                frm1.bag.Close();
            }
        }
    }
}
