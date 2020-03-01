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
    public partial class Form3 : Form
    {
        public Form1 frm1;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           frm1.musteriListele();
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

        private void ekle_Click(object sender, EventArgs e)
        {
            frm1.frm2.ShowDialog();
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
                    frm1.kmt.CommandText = "DELETE from musteribil WHERE tcKimlik='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.Dispose();
                    frm1.bag.Close();
                    frm1.musteriListele();
                }
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
            //eğer combo1 in metni  Müşteri Adı ise alan değişkine musteriAdi a eşitle yani combo1 de Müşteri Adı seçeneği seçiliyse
            else if (comboBox1.Text == "Müşteri Soyadı") alan = "musteriSoyadi";
            else if (comboBox1.Text == "Tc Kimlik") alan = "tcKimlik";
            else if (comboBox1.Text == "Cep Tel") alan = "cepTel";
            else if (comboBox1.Text == "Ev Tel") alan = "evTel";
            else if(comboBox1.Text == "Adres") alan = "adres";

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
                // textbox1 e girilen değerin belitilen alan içinde geçenleri seç
                frm1.tabloMusteri.Clear();
                adtr.Fill(frm1.tabloMusteri);//tabloMusteri sanal tablosunu adaptör ile doldur.
                frm1.bag.Close();
            }
        
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frm1.frm4.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //form4 deki textbox1 in textine datagridview1 deki seçili satırın 0. hücresindeki değeri yaz.
            frm1.frm4.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm1.frm4.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm1.frm4.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm1.frm4.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm1.frm4.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm1.frm4.ShowDialog();
        }
    }
}
