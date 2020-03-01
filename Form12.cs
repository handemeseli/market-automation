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
    public partial class Form12 : Form
    {
        public Form1 frm1;
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
            {
                frm1.bag.Open();
                frm1.kmt.Connection = frm1.bag;
                frm1.kmt.CommandText = "UPDATE kasiyerbil SET ad='" + textBox1.Text + "',soyad='" + textBox2.Text + "',tcKimlik='" + textBox3.Text + "',cepTel='" + textBox4.Text + "',evTel='" + textBox5.Text + "',adres='" + textBox6.Text + "',maas='" + textBox7.Text + "',kasaNo='" + textBox8.Text + "',gorevBaslangici='" + dateTimePicker1.Text+ "',gorevBitimi='" + dateTimePicker2.Text+ "' WHERE tcKimlik='" + frm1.frm11.dataGridView1.CurrentRow.Cells[2].Value.ToString() + "' AND ad='" + frm1.frm11.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                //güncelleme sorgusu
                frm1.kmt.ExecuteNonQuery();
                frm1.kmt.Dispose();
                frm1.bag.Close();
                frm1.kasiyerListele();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Ad-Soyad-Tckimlik alanlarını boş bırakmayınız !!!");
            }
        }
    }
}
