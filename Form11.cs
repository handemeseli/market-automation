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
    public partial class Form11 : Form
    {
        public Form1 frm1;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            frm1.kasiyerListele();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "Adı";
                dataGridView1.Columns[1].HeaderText = "Soyadı";
                dataGridView1.Columns[2].HeaderText = "Tc Kimlik";
                dataGridView1.Columns[3].HeaderText = "Cep Tel";
                dataGridView1.Columns[4].HeaderText = "Ev Tel";
                dataGridView1.Columns[5].HeaderText = "Adres";
                dataGridView1.Columns[6].HeaderText = "Maaş";
                dataGridView1.Columns[7].HeaderText = "Görevli Old. Kasa";
                dataGridView1.Columns[8].HeaderText = "Görev Başlangıcı";
                dataGridView1.Columns[9].HeaderText = "Görev Bitimi";
            }
            catch
            {
                ;
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            frm1.frm10.ShowDialog();
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
                    frm1.kmt.CommandText = "DELETE from kasiyerbil WHERE tcKimlik='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.Dispose();
                    frm1.bag.Close();
                    frm1.kasiyerListele();
                }
            }
            catch
            {
                ;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frm1.frm12.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm1.frm12.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm1.frm12.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm1.frm12.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm1.frm12.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm1.frm12.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm1.frm12.textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm1.frm12.textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm1.frm12.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm1.frm12.dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm1.frm12.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select ad,soyad,tcKimlik,cepTel,evTel,adres,maas,kasaNo,gorevBaslangici,gorevBitimi From kasiyerbil", frm1.bag);
            string alan = "";
            if (comboBox1.Text == "Adı") alan = "ad";
                //eğer combo1 in metni  Adı ise alan değişkine ad a eşitle yani combo1 de Adı seçeneği seçiliyse
            else if (comboBox1.Text == "Soyadı") alan = "soyad";
            else if (comboBox1.Text == "Tc Kimlik") alan = "tcKimlik";
            else if (comboBox1.Text == "Cep Tel") alan = "cepTel";
            else if (comboBox1.Text == "Ev Tel") alan = "evTel";
            else if (comboBox1.Text == "Adres") alan = "adres";
            else if (comboBox1.Text == "Maaş") alan = "maas";
            else if (comboBox1.Text == "Görevli old. Kasa") alan = "kasaNo";
            else if (comboBox1.Text == "Görev Başlangıcı") alan = "gorevBaslangici";
            else if (comboBox1.Text == "Görev Bitimi") alan = "gorevBitimi";

            if (comboBox1.Text == "Tümü")
            {
                frm1.bag.Open();
                frm1.tabloKasiyer.Clear();
                frm1.kmt.Connection = frm1.bag;
                frm1.kmt.CommandText = "Select ad,soyad,tcKimlik,cepTel,evTel,adres,maas,kasaNo,gorevBaslangici,gorevBitimi from kasiyerbil";//tüm kayıtları seç
                adtr.SelectCommand = frm1.kmt;
                adtr.Fill(frm1.tabloKasiyer);
                frm1.bag.Close();
            }
            if (alan != "")//alan değişkeni boş değilse
            {
                frm1.bag.Open();
                adtr.SelectCommand.CommandText = " Select ad,soyad,tcKimlik,cepTel,evTel,adres,maas,kasaNo,gorevBaslangici,gorevBitimi From kasiyerbil" + " where(" + alan + " like '%" + textBox1.Text + "%' )";
                // textbox1 e girilen değerin belitilen alan içinde geçenleri seç
                frm1.tabloKasiyer.Clear();
                adtr.Fill(frm1.tabloKasiyer);//tabloKasiyer sanal tablosunu adaptör ile doldur.
                frm1.bag.Close();
            }
        }
    }
}
