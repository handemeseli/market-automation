namespace market_takip
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kapat = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.yeniEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tümü",
            "Ürün Adı",
            "Adet",
            "Birim Fiyat",
            "Kdv",
            "Satış Fiyatı"});
            this.comboBox1.Location = new System.Drawing.Point(266, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 141;
            this.comboBox1.Text = "Tümü";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 140;
            // 
            // btnAra
            // 
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.ImageKey = "ara.gif";
            this.btnAra.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(421, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 35);
            this.btnAra.TabIndex = 139;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
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
            // kapat
            // 
            this.kapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kapat.ImageKey = "hhh.jpg";
            this.kapat.ImageList = this.ımageList1;
            this.kapat.Location = new System.Drawing.Point(432, 217);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(75, 55);
            this.kapat.TabIndex = 138;
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
            this.sil.Location = new System.Drawing.Point(336, 217);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 55);
            this.sil.TabIndex = 137;
            this.sil.Text = "Sil";
            this.sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // yeniEkle
            // 
            this.yeniEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.yeniEkle.ImageKey = "add.png";
            this.yeniEkle.ImageList = this.ımageList1;
            this.yeniEkle.Location = new System.Drawing.Point(240, 215);
            this.yeniEkle.Name = "yeniEkle";
            this.yeniEkle.Size = new System.Drawing.Size(75, 55);
            this.yeniEkle.TabIndex = 136;
            this.yeniEkle.Text = "Yeni Ekle";
            this.yeniEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.yeniEkle.UseVisualStyleBackColor = true;
            this.yeniEkle.Click += new System.EventHandler(this.yeniEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(10, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(545, 139);
            this.dataGridView1.TabIndex = 135;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.ImageKey = "add.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(666, 120);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 55);
            this.btnEkle.TabIndex = 142;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(651, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 143;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(651, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 145;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 146;
            this.label2.Text = "Adet";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.yeniEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button yeniEkle;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}