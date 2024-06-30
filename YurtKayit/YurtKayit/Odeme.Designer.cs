namespace YurtKayit
{
    partial class Odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odeme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencisoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciborcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtotomasyonDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtotomasyonDataSet2 = new YurtKayit.yurtotomasyonDataSet2();
            this.borcTableAdapter = new YurtKayit.yurtotomasyonDataSet2TableAdapters.BorcTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrid = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrOdenen = new System.Windows.Forms.TextBox();
            this.txtOgrKalan = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciidDataGridViewTextBoxColumn,
            this.ogrenciadDataGridViewTextBoxColumn,
            this.ogrencisoyadDataGridViewTextBoxColumn,
            this.ogrenciborcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borcBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(363, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(569, 287);
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
            // 
            // ogrenciadDataGridViewTextBoxColumn
            // 
            this.ogrenciadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciadDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_ad";
            this.ogrenciadDataGridViewTextBoxColumn.HeaderText = "ogrenci_ad";
            this.ogrenciadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciadDataGridViewTextBoxColumn.Name = "ogrenciadDataGridViewTextBoxColumn";
            // 
            // ogrencisoyadDataGridViewTextBoxColumn
            // 
            this.ogrencisoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrencisoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_soyad";
            this.ogrencisoyadDataGridViewTextBoxColumn.HeaderText = "ogrenci_soyad";
            this.ogrencisoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrencisoyadDataGridViewTextBoxColumn.Name = "ogrencisoyadDataGridViewTextBoxColumn";
            // 
            // ogrenciborcDataGridViewTextBoxColumn
            // 
            this.ogrenciborcDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciborcDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_borc";
            this.ogrenciborcDataGridViewTextBoxColumn.HeaderText = "ogrenci_borc";
            this.ogrenciborcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciborcDataGridViewTextBoxColumn.Name = "ogrenciborcDataGridViewTextBoxColumn";
            // 
            // borcBindingSource
            // 
            this.borcBindingSource.DataMember = "Borc";
            this.borcBindingSource.DataSource = this.yurtotomasyonDataSet2BindingSource;
            // 
            // yurtotomasyonDataSet2BindingSource
            // 
            this.yurtotomasyonDataSet2BindingSource.DataSource = this.yurtotomasyonDataSet2;
            this.yurtotomasyonDataSet2BindingSource.Position = 0;
            // 
            // yurtotomasyonDataSet2
            // 
            this.yurtotomasyonDataSet2.DataSetName = "yurtotomasyonDataSet2";
            this.yurtotomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borcTableAdapter
            // 
            this.borcTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(164, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ödeme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ogrenci id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(37, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kalan Borç:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(4, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ödenen Miktar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğrenci Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(2, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Öğrenci Soyad:";
            // 
            // txtOgrid
            // 
            this.txtOgrid.Enabled = false;
            this.txtOgrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtOgrid.Location = new System.Drawing.Point(149, 37);
            this.txtOgrid.Name = "txtOgrid";
            this.txtOgrid.Size = new System.Drawing.Size(183, 28);
            this.txtOgrid.TabIndex = 7;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Enabled = false;
            this.txtOgrAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtOgrAd.Location = new System.Drawing.Point(149, 77);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(183, 28);
            this.txtOgrAd.TabIndex = 8;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Enabled = false;
            this.txtOgrSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtOgrSoyad.Location = new System.Drawing.Point(149, 117);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(183, 28);
            this.txtOgrSoyad.TabIndex = 9;
            // 
            // txtOgrOdenen
            // 
            this.txtOgrOdenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtOgrOdenen.Location = new System.Drawing.Point(149, 197);
            this.txtOgrOdenen.Name = "txtOgrOdenen";
            this.txtOgrOdenen.Size = new System.Drawing.Size(183, 28);
            this.txtOgrOdenen.TabIndex = 10;
            this.txtOgrOdenen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOgrOdenen_KeyPress);
            // 
            // txtOgrKalan
            // 
            this.txtOgrKalan.Enabled = false;
            this.txtOgrKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtOgrKalan.Location = new System.Drawing.Point(149, 157);
            this.txtOgrKalan.Name = "txtOgrKalan";
            this.txtOgrKalan.Size = new System.Drawing.Size(183, 28);
            this.txtOgrKalan.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(804, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Arama";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtArama.Location = new System.Drawing.Point(615, 30);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(183, 28);
            this.txtArama.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(31, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ödenen Ay:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(33, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ödenen Yıl:";
            // 
            // cmbAy
            // 
            this.cmbAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbAy.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbAy.Location = new System.Drawing.Point(149, 237);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(183, 30);
            this.cmbAy.TabIndex = 18;
            // 
            // cmbYil
            // 
            this.cmbYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cmbYil.Location = new System.Drawing.Point(149, 277);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(183, 30);
            this.cmbYil.TabIndex = 19;
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 367);
            this.Controls.Add(this.cmbYil);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtOgrKalan);
            this.Controls.Add(this.txtOgrOdenen);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.txtOgrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Odeme";
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource yurtotomasyonDataSet2BindingSource;
        private yurtotomasyonDataSet2 yurtotomasyonDataSet2;
        private System.Windows.Forms.BindingSource borcBindingSource;
        private yurtotomasyonDataSet2TableAdapters.BorcTableAdapter borcTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrid;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrOdenen;
        private System.Windows.Forms.TextBox txtOgrKalan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencisoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciborcDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.ComboBox cmbYil;
    }
}