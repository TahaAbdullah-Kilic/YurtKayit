namespace YurtKayit
{
    partial class Bolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bolumler));
            this.dataGridBolumler = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtotomasyonDataSet = new YurtKayit.yurtotomasyonDataSet();
            this.bolumlerTableAdapter = new YurtKayit.yurtotomasyonDataSetTableAdapters.BolumlerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.TxtBolumid = new System.Windows.Forms.TextBox();
            this.BolumDuzenleBTN = new System.Windows.Forms.PictureBox();
            this.BolumSilBTN = new System.Windows.Forms.PictureBox();
            this.BolumEkleBTN = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBolumler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BolumDuzenleBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BolumSilBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BolumEkleBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBolumler
            // 
            this.dataGridBolumler.AutoGenerateColumns = false;
            this.dataGridBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBolumler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumisimDataGridViewTextBoxColumn});
            this.dataGridBolumler.DataSource = this.bolumlerBindingSource;
            this.dataGridBolumler.Location = new System.Drawing.Point(0, 171);
            this.dataGridBolumler.Name = "dataGridBolumler";
            this.dataGridBolumler.RowHeadersWidth = 51;
            this.dataGridBolumler.Size = new System.Drawing.Size(547, 358);
            this.dataGridBolumler.TabIndex = 0;
            this.dataGridBolumler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBolumler_CellClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "bolum_id";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "bolum_id";
            this.bolumidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumidDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumisimDataGridViewTextBoxColumn
            // 
            this.bolumisimDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumisimDataGridViewTextBoxColumn.DataPropertyName = "bolum_isim";
            this.bolumisimDataGridViewTextBoxColumn.HeaderText = "bolum_isim";
            this.bolumisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumisimDataGridViewTextBoxColumn.Name = "bolumisimDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtotomasyonDataSet;
            // 
            // yurtotomasyonDataSet
            // 
            this.yurtotomasyonDataSet.DataSetName = "yurtotomasyonDataSet";
            this.yurtotomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölüm adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bölüm id:";
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBolumAd.Location = new System.Drawing.Point(122, 15);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(330, 30);
            this.TxtBolumAd.TabIndex = 3;
            // 
            // TxtBolumid
            // 
            this.TxtBolumid.Enabled = false;
            this.TxtBolumid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBolumid.Location = new System.Drawing.Point(122, 53);
            this.TxtBolumid.Name = "TxtBolumid";
            this.TxtBolumid.Size = new System.Drawing.Size(330, 30);
            this.TxtBolumid.TabIndex = 4;
            // 
            // BolumDuzenleBTN
            // 
            this.BolumDuzenleBTN.Image = global::YurtKayit.Properties.Resources.edit_1287617_640;
            this.BolumDuzenleBTN.Location = new System.Drawing.Point(352, 105);
            this.BolumDuzenleBTN.Name = "BolumDuzenleBTN";
            this.BolumDuzenleBTN.Size = new System.Drawing.Size(100, 60);
            this.BolumDuzenleBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BolumDuzenleBTN.TabIndex = 7;
            this.BolumDuzenleBTN.TabStop = false;
            this.toolTip1.SetToolTip(this.BolumDuzenleBTN, "Bölüm Güncelle");
            this.BolumDuzenleBTN.Click += new System.EventHandler(this.BolumDuzenleBTN_Click);
            // 
            // BolumSilBTN
            // 
            this.BolumSilBTN.Image = global::YurtKayit.Properties.Resources.remove_151678_640;
            this.BolumSilBTN.InitialImage = null;
            this.BolumSilBTN.Location = new System.Drawing.Point(202, 105);
            this.BolumSilBTN.Name = "BolumSilBTN";
            this.BolumSilBTN.Size = new System.Drawing.Size(100, 60);
            this.BolumSilBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BolumSilBTN.TabIndex = 6;
            this.BolumSilBTN.TabStop = false;
            this.BolumSilBTN.Tag = "";
            this.toolTip1.SetToolTip(this.BolumSilBTN, "Bölüm Sil");
            this.BolumSilBTN.Click += new System.EventHandler(this.BolumSilBTN_Click);
            // 
            // BolumEkleBTN
            // 
            this.BolumEkleBTN.Image = global::YurtKayit.Properties.Resources.plus_297823_640;
            this.BolumEkleBTN.Location = new System.Drawing.Point(52, 105);
            this.BolumEkleBTN.Name = "BolumEkleBTN";
            this.BolumEkleBTN.Size = new System.Drawing.Size(100, 60);
            this.BolumEkleBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BolumEkleBTN.TabIndex = 5;
            this.BolumEkleBTN.TabStop = false;
            this.BolumEkleBTN.Tag = "";
            this.toolTip1.SetToolTip(this.BolumEkleBTN, "Bölüm ekle");
            this.BolumEkleBTN.Click += new System.EventHandler(this.BolumEkleBTN_Click);
            // 
            // Bolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(546, 529);
            this.Controls.Add(this.BolumDuzenleBTN);
            this.Controls.Add(this.BolumSilBTN);
            this.Controls.Add(this.BolumEkleBTN);
            this.Controls.Add(this.TxtBolumid);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridBolumler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bolumler";
            this.Text = "Bolumler";
            this.Load += new System.EventHandler(this.Bolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBolumler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BolumDuzenleBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BolumSilBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BolumEkleBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        

        private System.Windows.Forms.DataGridView dataGridBolumler;
        private yurtotomasyonDataSet yurtotomasyonDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private yurtotomasyonDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private System.Windows.Forms.TextBox TxtBolumid;
        private System.Windows.Forms.PictureBox BolumEkleBTN;
        private System.Windows.Forms.PictureBox BolumSilBTN;
        private System.Windows.Forms.PictureBox BolumDuzenleBTN;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}