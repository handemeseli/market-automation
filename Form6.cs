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
    public partial class Form6 : Form
    {
        public Form1 frm1;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            frm1.urunListele();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "Ürün Adı";
                dataGridView1.Columns[1].HeaderText = "Ürün Kodu";
                dataGridView1.Columns[2].HeaderText = "Firma Adı";
                dataGridView1.Columns[3].HeaderText = "Alış fiyatı";
                dataGridView1.Columns[4].HeaderText = "Satış Fiyatı";
                dataGridView1.Columns[5].HeaderText = "Kategori";
            }
            catch
            {
                ;
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            frm1.frm5.ShowDialog();
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
                    frm1.kmt.CommandText = "DELETE from urunbil WHERE urunKodu='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'";
                    //şarta uyan kaydı silme sorgusu
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.Dispose();
                    frm1.bag.Close();
                    frm1.urunListele();
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frm1.frm7.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //form7 deki textbox1 in textine datagridview1 deki seçili satırın 0. hücresindeki değeri yaz.
            frm1.frm7.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm1.frm7.comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm1.frm7.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm1.frm7.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm1.frm7.comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm1.frm7.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select urunAdi,urunKodu,firmaAdi,alisFiyati,satisFiyati,kategori From urunbil", frm1.bag);
            string alan = "";
            if (comboBox1.Text == "Ürün Adı") alan = "urunAdi";
            else if (comboBox1.Text == "Ürün Kodu") alan = "urunKodu";
            else if (comboBox1.Text == "Firma Adı") alan = "firmaAdi";
            else if (comboBox1.Text == "Alış Fiyatı") alan = "alisFiyati";
            else if (comboBox1.Text == "Satış Fiyatı") alan = "satisFiyati";
            else if (comboBox1.Text == "Kategori") alan = "kategori";
            if (comboBox1.Text == "Tümü")//eğer texbox boş ise
            {
                frm1.bag.Open();
                frm1.tabloUrun.Clear();
                frm1.kmt.Connection = frm1.bag;
                frm1.kmt.CommandText = "Select urunAdi,urunKodu,firmaAdi,alisFiyati,satisFiyati,kategori from urunbil";//tüm kayıtları seç
                adtr.SelectCommand = frm1.kmt;
                adtr.Fill(frm1.tabloUrun);
                frm1.bag.Close();
            }
            if (alan != "")
            {
                frm1.bag.Open();
                adtr.SelectCommand.CommandText = " Select urunAdi,urunKodu,firmaAdi,alisFiyati,satisFiyati,kategori From urunbil" + " where(" + alan + " like '%" + textBox1.Text + "%' )";
                frm1.tabloUrun.Clear();
                adtr.Fill(frm1.tabloUrun);
                frm1.bag.Close();
            }
        }
    }
}
