using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayit
{
    public partial class YoneticiDuzenle : Form
    {
        SqlBaglanti sqlbgl = new SqlBaglanti();
        public YoneticiDuzenle()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.yoneticiTableAdapter.Fill(this.yurtotomasyonDataSet5.Yonetici);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Yonetici (yonetici_ad,yonetici_sifre) values (@p1,@p2)",sqlbgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.ExecuteNonQuery();
            sqlbgl.baglanti().Close();
            MessageBox.Show("Yonetici Eklendi");
            this.yoneticiTableAdapter.Fill(this.yurtotomasyonDataSet5.Yonetici);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKullaniciAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Yonetici where Yonetici_id = @p1", sqlbgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            sqlbgl.baglanti().Close();
            MessageBox.Show("Yönetici Başarılı Bir Şekilde Silindi.");
            this.yoneticiTableAdapter.Fill(this.yurtotomasyonDataSet5.Yonetici);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Yonetici set Yonetici_id = @p1, Yonetici_ad = @p2, Yonetici_sifre = @p3", sqlbgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.Parameters.AddWithValue("@p2", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p3", txtSifre.Text);
            sqlbgl.baglanti().Close();
            MessageBox.Show("Yönetici Başarılı Bir Şekilde Güncellendi.");
            this.yoneticiTableAdapter.Fill(this.yurtotomasyonDataSet5.Yonetici);
        }
    }
}
