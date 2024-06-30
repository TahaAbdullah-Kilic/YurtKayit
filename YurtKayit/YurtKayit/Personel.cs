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
    public partial class Personel : Form
    {
        SqlBaglanti sqlbgl = new SqlBaglanti();
        public Personel()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtotomasyonDataSet6.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtotomasyonDataSet6.Personel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (personel_ad, personel_departman) values (@p1,@p2)", sqlbgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", txtGorev.Text);
            komut.ExecuteNonQuery();
            sqlbgl.baglanti().Close();
            MessageBox.Show("Personel Başarıyla Eklendi");
            this.personelTableAdapter.Fill(this.yurtotomasyonDataSet6.Personel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personel set personel_ad = @p1, personel_departman = @p2 where personel_id = @p3",sqlbgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text); 
            komut.Parameters.AddWithValue("@p2", txtGorev.Text);
            komut.Parameters.AddWithValue("@p3", txtPersonelid.Text);
            komut.ExecuteNonQuery();
            sqlbgl.baglanti().Close();
            this.personelTableAdapter.Fill(this.yurtotomasyonDataSet6.Personel);
            MessageBox.Show("Personel Güncellemesi Yapıldı");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtPersonelid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtPersonelAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtGorev.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where personel_id = @p1", sqlbgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonelid.Text);
            komut.ExecuteNonQuery();
            sqlbgl.baglanti().Close();
            this.personelTableAdapter.Fill(this.yurtotomasyonDataSet6.Personel);
            MessageBox.Show("Personel Başarıyla Silindi");
        }
    }
}
