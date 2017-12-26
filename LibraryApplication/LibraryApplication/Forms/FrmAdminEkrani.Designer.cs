namespace LibraryApplication.Forms
{
    partial class FrmAdminEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminEkrani));
            this.lstListeler = new System.Windows.Forms.ListBox();
            this.tsBtnKullanıcılar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAdminler = new System.Windows.Forms.ToolStripButton();
            this.tsBtnKategoriler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnYazarlar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnYayinEvleri = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSonEklenenler = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCezaVer = new System.Windows.Forms.Button();
            this.dgEkran = new System.Windows.Forms.DataGridView();
            this.btnAdminSil = new System.Windows.Forms.Button();
            this.btnAdminGuncelle = new System.Windows.Forms.Button();
            this.btnAdminEkle = new System.Windows.Forms.Button();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.tslblKullaniciAdi = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnCikisYap = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEkran)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstListeler
            // 
            this.lstListeler.FormattingEnabled = true;
            this.lstListeler.Location = new System.Drawing.Point(0, 186);
            this.lstListeler.Name = "lstListeler";
            this.lstListeler.Size = new System.Drawing.Size(133, 264);
            this.lstListeler.TabIndex = 10;
            // 
            // tsBtnKullanıcılar
            // 
            this.tsBtnKullanıcılar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnKullanıcılar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnKullanıcılar.Image")));
            this.tsBtnKullanıcılar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnKullanıcılar.Name = "tsBtnKullanıcılar";
            this.tsBtnKullanıcılar.Size = new System.Drawing.Size(69, 22);
            this.tsBtnKullanıcılar.Text = "Kullanıcılar";
            this.tsBtnKullanıcılar.Click += new System.EventHandler(this.tsBtnKullanıcılar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnAdminler
            // 
            this.tsBtnAdminler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnAdminler.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAdminler.Image")));
            this.tsBtnAdminler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdminler.Name = "tsBtnAdminler";
            this.tsBtnAdminler.Size = new System.Drawing.Size(60, 22);
            this.tsBtnAdminler.Text = "Adminler";
            this.tsBtnAdminler.Click += new System.EventHandler(this.tsBtnAdminler_Click);
            // 
            // tsBtnKategoriler
            // 
            this.tsBtnKategoriler.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnKategoriler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnKategoriler.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnKategoriler.Image")));
            this.tsBtnKategoriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnKategoriler.Name = "tsBtnKategoriler";
            this.tsBtnKategoriler.Size = new System.Drawing.Size(68, 22);
            this.tsBtnKategoriler.Text = "Kategoriler";
            this.tsBtnKategoriler.Click += new System.EventHandler(this.tsBtnKategoriler_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnYazarlar
            // 
            this.tsBtnYazarlar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnYazarlar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnYazarlar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnYazarlar.Image")));
            this.tsBtnYazarlar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnYazarlar.Name = "tsBtnYazarlar";
            this.tsBtnYazarlar.Size = new System.Drawing.Size(51, 22);
            this.tsBtnYazarlar.Text = "Yazarlar";
            this.tsBtnYazarlar.Click += new System.EventHandler(this.tsBtnYazarlar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnYayinEvleri
            // 
            this.tsBtnYayinEvleri.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnYayinEvleri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnYayinEvleri.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnYayinEvleri.Image")));
            this.tsBtnYayinEvleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnYayinEvleri.Name = "tsBtnYayinEvleri";
            this.tsBtnYayinEvleri.Size = new System.Drawing.Size(70, 22);
            this.tsBtnYayinEvleri.Text = "Yayın Evleri";
            this.tsBtnYayinEvleri.Click += new System.EventHandler(this.tsBtnYayinEvleri_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnSonEklenenler
            // 
            this.tsBtnSonEklenenler.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnSonEklenenler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSonEklenenler.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSonEklenenler.Image")));
            this.tsBtnSonEklenenler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSonEklenenler.Name = "tsBtnSonEklenenler";
            this.tsBtnSonEklenenler.Size = new System.Drawing.Size(88, 22);
            this.tsBtnSonEklenenler.Text = "Son Eklenenler";
            this.tsBtnSonEklenenler.Click += new System.EventHandler(this.tsBtnSonEklenenler_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AllowDrop = true;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSonEklenenler,
            this.toolStripSeparator7,
            this.tsBtnYayinEvleri,
            this.toolStripSeparator4,
            this.tsBtnYazarlar,
            this.toolStripSeparator1,
            this.tsBtnKategoriler,
            this.tsBtnAdminler,
            this.toolStripSeparator2,
            this.tsBtnKullanıcılar,
            this.toolStripSeparator3});
            this.toolStrip2.Location = new System.Drawing.Point(163, 158);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(439, 25);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCezaVer
            // 
            this.btnCezaVer.Location = new System.Drawing.Point(493, 105);
            this.btnCezaVer.Name = "btnCezaVer";
            this.btnCezaVer.Size = new System.Drawing.Size(109, 23);
            this.btnCezaVer.TabIndex = 5;
            this.btnCezaVer.Text = "Ceza Ver";
            this.btnCezaVer.UseVisualStyleBackColor = true;
            // 
            // dgEkran
            // 
            this.dgEkran.AllowUserToAddRows = false;
            this.dgEkran.AllowUserToDeleteRows = false;
            this.dgEkran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEkran.Location = new System.Drawing.Point(123, 186);
            this.dgEkran.Name = "dgEkran";
            this.dgEkran.ReadOnly = true;
            this.dgEkran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEkran.Size = new System.Drawing.Size(636, 264);
            this.dgEkran.TabIndex = 11;
            // 
            // btnAdminSil
            // 
            this.btnAdminSil.Location = new System.Drawing.Point(638, 105);
            this.btnAdminSil.Name = "btnAdminSil";
            this.btnAdminSil.Size = new System.Drawing.Size(109, 23);
            this.btnAdminSil.TabIndex = 8;
            this.btnAdminSil.Text = "Admin Sil";
            this.btnAdminSil.UseVisualStyleBackColor = true;
            this.btnAdminSil.Click += new System.EventHandler(this.btnAdminSil_Click);
            // 
            // btnAdminGuncelle
            // 
            this.btnAdminGuncelle.Location = new System.Drawing.Point(638, 76);
            this.btnAdminGuncelle.Name = "btnAdminGuncelle";
            this.btnAdminGuncelle.Size = new System.Drawing.Size(109, 23);
            this.btnAdminGuncelle.TabIndex = 7;
            this.btnAdminGuncelle.Text = "Admin Güncelle";
            this.btnAdminGuncelle.UseVisualStyleBackColor = true;
            this.btnAdminGuncelle.Click += new System.EventHandler(this.btnAdminGuncelle_Click);
            // 
            // btnAdminEkle
            // 
            this.btnAdminEkle.Location = new System.Drawing.Point(638, 47);
            this.btnAdminEkle.Name = "btnAdminEkle";
            this.btnAdminEkle.Size = new System.Drawing.Size(109, 23);
            this.btnAdminEkle.TabIndex = 6;
            this.btnAdminEkle.Text = "Admin Ekle";
            this.btnAdminEkle.UseVisualStyleBackColor = true;
            this.btnAdminEkle.Click += new System.EventHandler(this.btnAdminEkle_Click);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Location = new System.Drawing.Point(12, 105);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(109, 23);
            this.btnKitapSil.TabIndex = 4;
            this.btnKitapSil.Text = "Kitap Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.Location = new System.Drawing.Point(12, 76);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(109, 23);
            this.btnKitapGuncelle.TabIndex = 3;
            this.btnKitapGuncelle.Text = "Kitap Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            this.btnKitapGuncelle.Click += new System.EventHandler(this.btnKitapGuncelle_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(12, 47);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(109, 23);
            this.btnKitapEkle.TabIndex = 2;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // tslblKullaniciAdi
            // 
            this.tslblKullaniciAdi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblKullaniciAdi.Name = "tslblKullaniciAdi";
            this.tslblKullaniciAdi.Size = new System.Drawing.Size(20, 22);
            this.tslblKullaniciAdi.Text = "txt";
            // 
            // tsbtnCikisYap
            // 
            this.tsbtnCikisYap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnCikisYap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCikisYap.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCikisYap.Image")));
            this.tsbtnCikisYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCikisYap.Name = "tsbtnCikisYap";
            this.tsbtnCikisYap.Size = new System.Drawing.Size(58, 22);
            this.tsbtnCikisYap.Text = "Çıkış Yap";
            this.tsbtnCikisYap.Click += new System.EventHandler(this.tsbtnCikisYap_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCikisYap,
            this.tslblKullaniciAdi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Location = new System.Drawing.Point(163, 105);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(109, 23);
            this.btnKullaniciSil.TabIndex = 12;
            this.btnKullaniciSil.Text = "Kullanıcı Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // FrmAdminEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.btnKullaniciSil);
            this.Controls.Add(this.lstListeler);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.btnCezaVer);
            this.Controls.Add(this.dgEkran);
            this.Controls.Add(this.btnAdminSil);
            this.Controls.Add(this.btnAdminGuncelle);
            this.Controls.Add(this.btnAdminEkle);
            this.Controls.Add(this.btnKitapSil);
            this.Controls.Add(this.btnKitapGuncelle);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Ekranı";
            this.Load += new System.EventHandler(this.FrmAdminEkrani_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEkran)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListeler;
        private System.Windows.Forms.ToolStripButton tsBtnKullanıcılar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnAdminler;
        private System.Windows.Forms.ToolStripButton tsBtnKategoriler;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnYazarlar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnYayinEvleri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsBtnSonEklenenler;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnCezaVer;
        private System.Windows.Forms.DataGridView dgEkran;
        private System.Windows.Forms.Button btnAdminSil;
        private System.Windows.Forms.Button btnAdminGuncelle;
        private System.Windows.Forms.Button btnAdminEkle;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.ToolStripLabel tslblKullaniciAdi;
        private System.Windows.Forms.ToolStripButton tsbtnCikisYap;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnKullaniciSil;
    }
}