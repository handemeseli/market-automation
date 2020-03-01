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
    public partial class Form15 : Form
    {
        public Form1 frm1;
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            frm1.urunComboEkle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frm1.urunKontrol();
            if (textBox1.Text.Trim() != "" )
            {
                double sfiyat;
                sfiyat = double.Parse(textBox1.Text) + double.Parse(textBox1.Text) * (double.Parse(textBox2.Text) / 100);
                frm1.bag.Open();
                frm1.kmt.Connection = frm1.bag;
                frm1.kmt.CommandText = "UPDATE stokbil SET urunAdi='" + comboBox1.Text + "',adet='" + textBox3.Text + "',birimFiyat='" + textBox1.Text + "',kdv='" + textBox2.Text + "',satisFiyat='" + sfiyat+ "' WHERE urunAdi='" + frm1.frm14.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ";
                frm1.kmt.ExecuteNonQuery();
                frm1.kmt.Dispose();
                frm1.bag.Close();
                frm1.stokListele();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Ürün Adı alanını boş bırakmayınız !!!");
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; //combo1 de klavye tuşlarını kilitle.
        }

       
    }
}
