namespace YurtKayit
{
    partial class OgrenciListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencisoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencitcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencitelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencidogumtarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencibolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencimailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciodanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciveliisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencivelitelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciveliadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtotomasyonDataSet3 = new YurtKayit.yurtotomasyonDataSet3();
            this.ogrenciTableAdapter = new YurtKayit.yurtotomasyonDataSet3TableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciidDataGridViewTextBoxColumn,
            this.ogrenciisimDataGridViewTextBoxColumn,
            this.ogrencisoyisimDataGridViewTextBoxColumn,
            this.ogrencitcDataGridViewTextBoxColumn,
            this.ogrencitelefonDataGridViewTextBoxColumn,
            this.ogrencidogumtarihDataGridViewTextBoxColumn,
            this.ogrencibolumDataGridViewTextBoxColumn,
            this.ogrencimailDataGridViewTextBoxColumn,
            this.ogrenciodanoDataGridViewTextBoxColumn,
            this.ogrenciveliisimDataGridViewTextBoxColumn,
            this.ogrencivelitelefonDataGridViewTextBoxColumn,
            this.ogrenciveliadresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1512, 559);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrenciidDataGridViewTextBoxColumn
            // 
            this.ogrenciidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciidDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_id";
            this.ogrenciidDataGridViewTextBoxColumn.HeaderText = "ogrenci_id";
            this.ogrenciidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciidDataGridViewTextBoxColumn.Name = "ogrenciidDataGridViewTextBoxColumn";
            this.ogrenciidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciisimDataGridViewTextBoxColumn
            // 
            this.ogrenciisimDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciisimDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_isim";
            this.ogrenciisimDataGridViewTextBoxColumn.HeaderText = "ogrenci_isim";
            this.ogrenciisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciisimDataGridViewTextBoxColumn.Name = "ogrenciisimDataGridViewTextBoxColumn";
            // 
            // ogrencisoyisimDataGridViewTextBoxColumn
            // 
            this.ogrencisoyisimDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrencisoyisimDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_soyisim";
            this.ogrencisoyisimDataGridViewTextBoxColumn.HeaderText = "ogrenci_soyisim";
            this.ogrencisoyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrencisoyisimDataGridViewTextBoxColumn.Name = "ogrencisoyisimDataGridViewTextBoxColumn";
            // 
            // ogrencitcDataGridViewTextBoxColumn
            // 
            this.ogrencitcDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrencitcDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_tc";
            this.ogrencitcDataGridViewTextBoxColumn.HeaderText = "ogrenci_tc";
            this.ogrencitcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrencitcDataGridViewTextBoxColumn.Name = "ogrencitcDataGridViewTextBoxColumn";
            // 
            // ogrencitelefonDataGridViewTextBoxColumn
            // 
            this.ogrencitelefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrencitelefonDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_telefon";
            this.ogrencitelefonDataGridViewTextBoxColumn.HeaderText = "ogrenci_telefon";
            this.ogrencitelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrencitelefonDataGridViewTextBoxColumn.Name = "ogrencitelefonDataGridViewTextBoxColumn";
            // 
            // ogrencidogumtarihDataGridViewTextBoxColumn
            // 
            this.ogrencidogumtarihDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrencidogumtarihDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_dogumtarih";
            this.ogrencidogumtarihDataGridViewTextBoxColumn.HeaderText = "ogrenci_dogumtarih";
            this.ogrencidogumtarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrencidogumtarihDataGridViewTextBoxColumn.Name = "ogrencidogumtarihDataGridViewTextBoxColumn";
            // 
            // ogrencibolumDataGridViewTextBoxColumn
            // 
            this.ogrencibolumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrencibolumDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_bolum";
            this.ogrencibolumDataGridViewTextBoxColumn.HeaderText = "ogrenci_bolum";
            this.ogrencibolumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrencibolumDataGridViewTextBoxColumn.Name = "ogrencibolumDataGridViewTextBoxColumn";
            // 
            // ogrencimailDataGridViewTextBoxColumn
            // 
            this.ogrencimailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrencimailDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_mail";
            this.ogrencimailDataGridViewTextBoxColumn.HeaderText = "ogrenci_mail";
            this.ogrencimailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrencimailDataGridViewTextBoxColumn.Name = "ogrencimailDataGridViewTextBoxColumn";
            // 
            // ogrenciodanoDataGridViewTextBoxColumn
            // 
            this.ogrenciodanoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciodanoDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_odano";
            this.ogrenciodanoDataGridViewTextBoxColumn.HeaderText = "ogrenci_odano";
            this.ogrenciodanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciodanoDataGridViewTextBoxColumn.Name = "ogrenciodanoDataGridViewTextBoxColumn";
            // 
            // ogrenciveliisimDataGridViewTextBoxColumn
            // 
            this.ogrenciveliisimDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciveliisimDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_veli_isim";
            this.ogrenciveliisimDataGridViewTextBoxColumn.HeaderText = "ogrenci_veli_isim";
            this.ogrenciveliisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciveliisimDataGridViewTextBoxColumn.Name = "ogrenciveliisimDataGridViewTextBoxColumn";
            // 
            // ogrencivelitelefonDataGridViewTextBoxColumn
            // 
            this.ogrencivelitelefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrencivelitelefonDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_veli_telefon";
            this.ogrencivelitelefonDataGridViewTextBoxColumn.HeaderText = "ogrenci_veli_telefon";
            this.ogrencivelitelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrencivelitelefonDataGridViewTextBoxColumn.Name = "ogrencivelitelefonDataGridViewTextBoxColumn";
            // 
            // ogrenciveliadresDataGridViewTextBoxColumn
            // 
            this.ogrenciveliadresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciveliadresDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_veli_adres";
            this.ogrenciveliadresDataGridViewTextBoxColumn.HeaderText = "ogrenci_veli_adres";
            this.ogrenciveliadresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciveliadresDataGridViewTextBoxColumn.Name = "ogrenciveliadresDataGridViewTextBoxColumn";
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtotomasyonDataSet3;
            // 
            // yurtotomasyonDataSet3
            // 
            this.yurtotomasyonDataSet3.DataSetName = "yurtotomasyonDataSet3";
            this.yurtotomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // OgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 559);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciListesi";
            this.Text = "OgrenciListesi";
            this.Load += new System.EventHandler(this.OgrenciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yurtotomasyonDataSet3 yurtotomasyonDataSet3;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private yurtotomasyonDataSet3TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencisoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencitcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencitelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencidogumtarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencibolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencimailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciodanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciveliisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencivelitelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciveliadresDataGridViewTextBoxColumn;
    }
}