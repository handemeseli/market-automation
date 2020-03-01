namespace market_takip
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMusIslem = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUrunIslem = new System.Windows.Forms.Button();
            this.btnKasiyerIslem = new System.Windows.Forms.Button();
            this.btnStokIslem = new System.Windows.Forms.Button();
            this.btnSatisIslem = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSatisGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusIslem
            // 
            this.btnMusIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusIslem.ImageKey = "musteri.png";
            this.btnMusIslem.ImageList = this.ımageList1;
            this.btnMusIslem.Location = new System.Drawing.Point(76, 21);
            this.btnMusIslem.Name = "btnMusIslem";
            this.btnMusIslem.Size = new System.Drawing.Size(90, 54);
            this.btnMusIslem.TabIndex = 5;
            this.btnMusIslem.Text = "Müşteri İşlemleri";
            this.btnMusIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusIslem.UseVisualStyleBackColor = true;
            this.btnMusIslem.Click += new System.EventHandler(this.btnMusIslem_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cikis.png");
            this.ımageList1.Images.SetKeyName(1, "list.png");
            this.ımageList1.Images.SetKeyName(2, "musteri.png");
            this.ımageList1.Images.SetKeyName(3, "person.png");
            this.ımageList1.Images.SetKeyName(4, "satış.png");
            this.ımageList1.Images.SetKeyName(5, "stok.png");
            this.ımageList1.Images.SetKeyName(6, "urun.png");
            // 
            // btnUrunIslem
            // 
            this.btnUrunIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUrunIslem.ImageIndex = 6;
            this.btnUrunIslem.ImageList = this.ımageList1;
            this.btnUrunIslem.Location = new System.Drawing.Point(189, 21);
            this.btnUrunIslem.Name = "btnUrunIslem";
            this.btnUrunIslem.Size = new System.Drawing.Size(83, 54);
            this.btnUrunIslem.TabIndex = 6;
            this.btnUrunIslem.Text = "Ürün İşlemleri";
            this.btnUrunIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunIslem.UseVisualStyleBackColor = true;
            this.btnUrunIslem.Click += new System.EventHandler(this.btnUrunIslem_Click);
            // 
            // btnKasiyerIslem
            // 
            this.btnKasiyerIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKasiyerIslem.ImageKey = "person.png";
            this.btnKasiyerIslem.ImageList = this.ımageList1;
            this.btnKasiyerIslem.Location = new System.Drawing.Point(295, 21);
            this.btnKasiyerIslem.Name = "btnKasiyerIslem";
            this.btnKasiyerIslem.Size = new System.Drawing.Size(96, 54);
            this.btnKasiyerIslem.TabIndex = 7;
            this.btnKasiyerIslem.Text = "Kasiyer İşlemleri";
            this.btnKasiyerIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKasiyerIslem.UseVisualStyleBackColor = true;
            this.btnKasiyerIslem.Click += new System.EventHandler(this.btnKasiyerIslem_Click);
            // 
            // btnStokIslem
            // 
            this.btnStokIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStokIslem.ImageKey = "stok.png";
            this.btnStokIslem.ImageList = this.ımageList1;
            this.btnStokIslem.Location = new System.Drawing.Point(414, 21);
            this.btnStokIslem.Name = "btnStokIslem";
            this.btnStokIslem.Size = new System.Drawing.Size(83, 54);
            this.btnStokIslem.TabIndex = 8;
            this.btnStokIslem.Text = "Stok İşlemleri";
            this.btnStokIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStokIslem.UseVisualStyleBackColor = true;
            this.btnStokIslem.Click += new System.EventHandler(this.btnStokIslem_Click);
            // 
            // btnSatisIslem
            // 
            this.btnSatisIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatisIslem.ImageKey = "satış.png";
            this.btnSatisIslem.ImageList = this.ımageList1;
            this.btnSatisIslem.Location = new System.Drawing.Point(520, 21);
            this.btnSatisIslem.Name = "btnSatisIslem";
            this.btnSatisIslem.Size = new System.Drawing.Size(83, 54);
            this.btnSatisIslem.TabIndex = 9;
            this.btnSatisIslem.Text = "Satış İşlemleri";
            this.btnSatisIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatisIslem.UseVisualStyleBackColor = true;
            this.btnSatisIslem.Click += new System.EventHandler(this.btnSatisIslem_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "cikis.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(626, 21);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(83, 54);
            this.btnCikis.TabIndex = 140;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(520, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 139;
            // 
            // btnSatisGoster
            // 
            this.btnSatisGoster.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatisGoster.ImageIndex = 1;
            this.btnSatisGoster.ImageList = this.ımageList1;
            this.btnSatisGoster.Location = new System.Drawing.Point(626, 101);
            this.btnSatisGoster.Name = "btnSatisGoster";
            this.btnSatisGoster.Size = new System.Drawing.Size(83, 54);
            this.btnSatisGoster.TabIndex = 138;
            this.btnSatisGoster.Text = "Göster";
            this.btnSatisGoster.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatisGoster.UseVisualStyleBackColor = true;
            this.btnSatisGoster.Click += new System.EventHandler(this.btnSatisGoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(251, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 137;
            this.label1.Text = "Satış Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(27, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(722, 242);
            this.dataGridView1.TabIndex = 136;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 415);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSatisGoster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSatisIslem);
            this.Controls.Add(this.btnStokIslem);
            this.Controls.Add(this.btnKasiyerIslem);
            this.Controls.Add(this.btnUrunIslem);
            this.Controls.Add(this.btnMusIslem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusIslem;
        private System.Windows.Forms.Button btnUrunIslem;
        private System.Windows.Forms.Button btnKasiyerIslem;
        private System.Windows.Forms.Button btnStokIslem;
        private System.Windows.Forms.Button btnSatisIslem;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSatisGoster;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;

    }
}

