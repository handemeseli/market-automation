namespace market_takip
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnkategoriEkle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.kapat = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 150);
            this.dataGridView1.TabIndex = 134;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "ara.gif");
            this.ımageList1.Images.SetKeyName(2, "hhh.jpg");
            this.ımageList1.Images.SetKeyName(3, "sil.gif");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Firma Adı";
            // 
            // btnkategoriEkle
            // 
            this.btnkategoriEkle.Location = new System.Drawing.Point(123, 82);
            this.btnkategoriEkle.Name = "btnkategoriEkle";
            this.btnkategoriEkle.Size = new System.Drawing.Size(75, 23);
            this.btnkategoriEkle.TabIndex = 5;
            this.btnkategoriEkle.Text = "Ekle";
            this.btnkategoriEkle.UseVisualStyleBackColor = true;
            this.btnkategoriEkle.Click += new System.EventHandler(this.btnkategoriEkle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnkategoriEkle);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 119);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adres";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // kapat
            // 
            this.kapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kapat.ImageKey = "hhh.jpg";
            this.kapat.ImageList = this.ımageList1;
            this.kapat.Location = new System.Drawing.Point(364, 205);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(75, 55);
            this.kapat.TabIndex = 137;
            this.kapat.Text = "Kapat";
            this.kapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // sil
            // 
            this.sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sil.ImageKey = "sil.gif";
            this.sil.ImageList = this.ımageList1;
            this.sil.Location = new System.Drawing.Point(263, 205);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 55);
            this.sil.TabIndex = 136;
            this.sil.Text = "Sil";
            this.sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 326);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkategoriEkle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}