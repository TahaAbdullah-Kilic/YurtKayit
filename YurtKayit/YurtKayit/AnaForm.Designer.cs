namespace YurtKayit
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ogrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciDuzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolumlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolumDuzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciÖdemesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirİstatistikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderİstatistikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erişimKolaylığıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yurtotomasyonDataSet = new YurtKayit.yurtotomasyonDataSet();
            this.yurtotomasyonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtotomasyonDataSet1 = new YurtKayit.yurtotomasyonDataSet1();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new YurtKayit.yurtotomasyonDataSet1TableAdapters.OgrenciTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencisoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencitelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciodanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrencilerToolStripMenuItem,
            this.bolumlerToolStripMenuItem,
            this.ödemelerToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.istatistiklerToolStripMenuItem,
            this.yöneticiToolStripMenuItem,
            this.erişimKolaylığıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ogrencilerToolStripMenuItem
            // 
            this.ogrencilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciEkleToolStripMenuItem,
            this.ogrenciListesiToolStripMenuItem,
            this.ogrenciDuzenleToolStripMenuItem});
            this.ogrencilerToolStripMenuItem.Name = "ogrencilerToolStripMenuItem";
            this.ogrencilerToolStripMenuItem.Size = new System.Drawing.Size(117, 32);
            this.ogrencilerToolStripMenuItem.Text = "Ögrenciler";
            // 
            // ogrenciEkleToolStripMenuItem
            // 
            this.ogrenciEkleToolStripMenuItem.Name = "ogrenciEkleToolStripMenuItem";
            this.ogrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.ogrenciEkleToolStripMenuItem.Text = "Ögrenci Ekle";
            this.ogrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.ogrenciEkleToolStripMenuItem_Click);
            // 
            // ogrenciListesiToolStripMenuItem
            // 
            this.ogrenciListesiToolStripMenuItem.Name = "ogrenciListesiToolStripMenuItem";
            this.ogrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.ogrenciListesiToolStripMenuItem.Text = "Ögrenci Listesi";
            this.ogrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.ogrenciListesiToolStripMenuItem_Click);
            // 
            // ogrenciDuzenleToolStripMenuItem
            // 
            this.ogrenciDuzenleToolStripMenuItem.Name = "ogrenciDuzenleToolStripMenuItem";
            this.ogrenciDuzenleToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.ogrenciDuzenleToolStripMenuItem.Text = "Ögrenci Duzenle";
            // 
            // bolumlerToolStripMenuItem
            // 
            this.bolumlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolumDuzenleToolStripMenuItem});
            this.bolumlerToolStripMenuItem.Name = "bolumlerToolStripMenuItem";
            this.bolumlerToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.bolumlerToolStripMenuItem.Text = "Bölümler";
            // 
            // bolumDuzenleToolStripMenuItem
            // 
            this.bolumDuzenleToolStripMenuItem.Name = "bolumDuzenleToolStripMenuItem";
            this.bolumDuzenleToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.bolumDuzenleToolStripMenuItem.Text = "Bölüm Duzenle";
            this.bolumDuzenleToolStripMenuItem.Click += new System.EventHandler(this.bolumDuzenleToolStripMenuItem_Click);
            // 
            // ödemelerToolStripMenuItem
            // 
            this.ödemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciÖdemesiToolStripMenuItem});
            this.ödemelerToolStripMenuItem.Name = "ödemelerToolStripMenuItem";
            this.ödemelerToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
            this.ödemelerToolStripMenuItem.Text = "Ödemeler";
            // 
            // öğrenciÖdemesiToolStripMenuItem
            // 
            this.öğrenciÖdemesiToolStripMenuItem.Name = "öğrenciÖdemesiToolStripMenuItem";
            this.öğrenciÖdemesiToolStripMenuItem.Size = new System.Drawing.Size(249, 32);
            this.öğrenciÖdemesiToolStripMenuItem.Text = "Öğrenci Ödemesi";
            this.öğrenciÖdemesiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciÖdemesiToolStripMenuItem_Click);
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giderEkleToolStripMenuItem,
            this.giderListesiToolStripMenuItem});
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // giderEkleToolStripMenuItem
            // 
            this.giderEkleToolStripMenuItem.Name = "giderEkleToolStripMenuItem";
            this.giderEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.giderEkleToolStripMenuItem.Text = "Gider Ekle";
            // 
            // giderListesiToolStripMenuItem
            // 
            this.giderListesiToolStripMenuItem.Name = "giderListesiToolStripMenuItem";
            this.giderListesiToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.giderListesiToolStripMenuItem.Text = "Gider Listesi";
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirİstatistikleriToolStripMenuItem,
            this.giderİstatistikleriToolStripMenuItem});
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.istatistiklerToolStripMenuItem.Text = "İstatistikler";
            // 
            // gelirİstatistikleriToolStripMenuItem
            // 
            this.gelirİstatistikleriToolStripMenuItem.Name = "gelirİstatistikleriToolStripMenuItem";
            this.gelirİstatistikleriToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.gelirİstatistikleriToolStripMenuItem.Text = "Gelir İstatistikleri";
            // 
            // giderİstatistikleriToolStripMenuItem
            // 
            this.giderİstatistikleriToolStripMenuItem.Name = "giderİstatistikleriToolStripMenuItem";
            this.giderİstatistikleriToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.giderİstatistikleriToolStripMenuItem.Text = "Gider İstatistikleri";
            // 
            // yöneticiToolStripMenuItem
            // 
            this.yöneticiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşlemleriToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem});
            this.yöneticiToolStripMenuItem.Name = "yöneticiToolStripMenuItem";
            this.yöneticiToolStripMenuItem.Size = new System.Drawing.Size(94, 32);
            this.yöneticiToolStripMenuItem.Text = "Yönetici";
            // 
            // öğrenciİşlemleriToolStripMenuItem
            // 
            this.öğrenciİşlemleriToolStripMenuItem.Name = "öğrenciİşlemleriToolStripMenuItem";
            this.öğrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.öğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // erişimKolaylığıToolStripMenuItem
            // 
            this.erişimKolaylığıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.paintToolStripMenuItem,
            this.radyolarToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.erişimKolaylığıToolStripMenuItem.Name = "erişimKolaylığıToolStripMenuItem";
            this.erişimKolaylığıToolStripMenuItem.Size = new System.Drawing.Size(76, 32);
            this.erişimKolaylığıToolStripMenuItem.Text = "Menü";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.paintToolStripMenuItem.Text = "Paint";
            // 
            // radyolarToolStripMenuItem
            // 
            this.radyolarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radyo1ToolStripMenuItem,
            this.radyo2ToolStripMenuItem,
            this.radyo3ToolStripMenuItem});
            this.radyolarToolStripMenuItem.Name = "radyolarToolStripMenuItem";
            this.radyolarToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.radyolarToolStripMenuItem.Text = "Radyolar";
            // 
            // radyo1ToolStripMenuItem
            // 
            this.radyo1ToolStripMenuItem.Name = "radyo1ToolStripMenuItem";
            this.radyo1ToolStripMenuItem.Size = new System.Drawing.Size(165, 32);
            this.radyo1ToolStripMenuItem.Text = "Radyo1";
            // 
            // radyo2ToolStripMenuItem
            // 
            this.radyo2ToolStripMenuItem.Name = "radyo2ToolStripMenuItem";
            this.radyo2ToolStripMenuItem.Size = new System.Drawing.Size(165, 32);
            this.radyo2ToolStripMenuItem.Text = "Radyo2";
            // 
            // radyo3ToolStripMenuItem
            // 
            this.radyo3ToolStripMenuItem.Name = "radyo3ToolStripMenuItem";
            this.radyo3ToolStripMenuItem.Size = new System.Drawing.Size(165, 32);
            this.radyo3ToolStripMenuItem.Text = "Radyo3";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // yurtotomasyonDataSet
            // 
            this.yurtotomasyonDataSet.DataSetName = "yurtotomasyonDataSet";
            this.yurtotomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yurtotomasyonDataSetBindingSource
            // 
            this.yurtotomasyonDataSetBindingSource.DataSource = this.yurtotomasyonDataSet;
            this.yurtotomasyonDataSetBindingSource.Position = 0;
            // 
            // yurtotomasyonDataSet1
            // 
            this.yurtotomasyonDataSet1.DataSetName = "yurtotomasyonDataSet1";
            this.yurtotomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtotomasyonDataSet1;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciisimDataGridViewTextBoxColumn,
            this.ogrencisoyisimDataGridViewTextBoxColumn,
            this.ogrencitelefonDataGridViewTextBoxColumn,
            this.ogrenciodanoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(807, 349);
            this.dataGridView1.TabIndex = 1;
            // 
            // ogrenciisimDataGridViewTextBoxColumn
            // 
            this.ogrenciisimDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciisimDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_isim";
            this.ogrenciisimDataGridViewTextBoxColumn.FillWeight = 75F;
            this.ogrenciisimDataGridViewTextBoxColumn.HeaderText = "Öğrenci Adı";
            this.ogrenciisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciisimDataGridViewTextBoxColumn.Name = "ogrenciisimDataGridViewTextBoxColumn";
            // 
            // ogrencisoyisimDataGridViewTextBoxColumn
            // 
            this.ogrencisoyisimDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrencisoyisimDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_soyisim";
            this.ogrencisoyisimDataGridViewTextBoxColumn.FillWeight = 75F;
            this.ogrencisoyisimDataGridViewTextBoxColumn.HeaderText = "Öğrenci Soyadı";
            this.ogrencisoyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrencisoyisimDataGridViewTextBoxColumn.Name = "ogrencisoyisimDataGridViewTextBoxColumn";
            // 
            // ogrencitelefonDataGridViewTextBoxColumn
            // 
            this.ogrencitelefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrencitelefonDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_telefon";
            this.ogrencitelefonDataGridViewTextBoxColumn.FillWeight = 75F;
            this.ogrencitelefonDataGridViewTextBoxColumn.HeaderText = "Telefon No";
            this.ogrencitelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrencitelefonDataGridViewTextBoxColumn.Name = "ogrencitelefonDataGridViewTextBoxColumn";
            // 
            // ogrenciodanoDataGridViewTextBoxColumn
            // 
            this.ogrenciodanoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciodanoDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_odano";
            this.ogrenciodanoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.ogrenciodanoDataGridViewTextBoxColumn.HeaderText = "Oda No";
            this.ogrenciodanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciodanoDataGridViewTextBoxColumn.Name = "ogrenciodanoDataGridViewTextBoxColumn";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaForm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ogrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciDuzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolumlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolumDuzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciÖdemesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirİstatistikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderİstatistikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erişimKolaylığıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyo3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.BindingSource yurtotomasyonDataSetBindingSource;
        private yurtotomasyonDataSet yurtotomasyonDataSet;
        private yurtotomasyonDataSet1 yurtotomasyonDataSet1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private yurtotomasyonDataSet1TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencisoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencitelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciodanoDataGridViewTextBoxColumn;
    }
}