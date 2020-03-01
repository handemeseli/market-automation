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
    public partial class Form9 : Form
    {
        public Form1 frm1;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            frm1.firmaListele();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "Firma Adı";
                dataGridView1.Columns[1].HeaderText = "Firma Adresi";                
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
                frm1.kmt.CommandText = "INSERT INTO firmabil(firmaAdi,firmaAdresi) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "') ";
                //kayıt ekleme sorgu metni
                frm1.kmt.ExecuteNonQuery();//sorguyu çalıştır                                                      
                frm1.kmt.Dispose();//Komut kullanımını kapatıyoruz
                frm1.bag.Close(); //veritabanımızı kapatıyoruz
                frm1.firmaListele();
                frm1.firmaComboEkle();
                MessageBox.Show("Kayıt işlemi tamamlandı ! ");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Firma Adı alanını boş bırakmayınız !!!");
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Close();
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
                    frm1.kmt.CommandText = "DELETE from firmabil WHERE firmaAdi='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.Dispose();
                    frm1.bag.Close();
                    frm1.firmaListele();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
