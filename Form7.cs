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
    public partial class Form7 : Form
    {
        public Form1 frm1;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                frm1.bag.Open();
                frm1.kmt.Connection = frm1.bag;
                frm1.kmt.CommandText = "UPDATE urunbil SET urunAdi='" + textBox1.Text + "',urunKodu='" + textBox2.Text + "',firmaAdi='" + comboBox1.Text + "',alisFiyati='" + textBox3.Text + "',satisFiyati='" + textBox4.Text + "',kategori='" +comboBox2.Text + "' WHERE urunKodu='" + frm1.frm6.dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' AND urunAdi='" + frm1.frm6.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                frm1.kmt.ExecuteNonQuery();
                frm1.kmt.Dispose();
                frm1.bag.Close();
                frm1.urunListele();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Ürün Adı - Ürün Kodu alanlarını boş bırakmayınız !!!");
            }
        }
    }
}
