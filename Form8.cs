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
    public partial class Form8 : Form
    {
        public Form1 frm1;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            frm1.kategoriListele();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "Kategori Adı";
            }
            catch
            {
                ;
            }
        }

        private void btnkategoriEkle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                frm1.bag.Open();
                frm1.kmt.Connection = frm1.bag;
                frm1.kmt.CommandText = "INSERT INTO kategoribil(kategoriAdi) VALUES ('" + textBox1.Text + "') ";
                //kayıt ekleme sorgu metni
                frm1.kmt.ExecuteNonQuery();//sorguyu çalıştır                                                      
                frm1.kmt.Dispose();//Komut kullanımını kapatıyoruz
                frm1.bag.Close(); //veritabanımızı kapatıyoruz
                frm1.kategoriListele();
                frm1.kategoriComboEkle();
                MessageBox.Show("Kayıt işlemi tamamlandı ! ");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Kategori Adı alanını boş bırakmayınız !!!");
            }
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
                    frm1.kmt.CommandText = "DELETE from kategoribil WHERE kategoriAdi='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.Dispose();
                    frm1.bag.Close();
                    frm1.kategoriListele();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
