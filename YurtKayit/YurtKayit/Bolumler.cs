using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayit
{
    public partial class Bolumler : Form
    {
        public Bolumler()
        {
            InitializeComponent();
        }

        SqlBaglanti sqlbgl = new SqlBaglanti();

        private void Bolumler_Load(object sender, EventArgs e)
        {
            this.bolumlerTableAdapter.Fill(this.yurtotomasyonDataSet.Bolumler);

        }
        private void BolumEkleBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Bolumler (bolum_isim) values (@p1)", sqlbgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtBolumid.Text);
                komut.ExecuteNonQuery();
                sqlbgl.baglanti().Close();
                MessageBox.Show("Bölüm Eklendi");
                this.bolumlerTableAdapter.Fill(this.yurtotomasyonDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("Bölüm Eklerken Bir Hata Oluştu");
            }
        }

        private void BolumSilBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Bolumler where bolum_id = @p1", sqlbgl.baglanti());
                komut.Parameters.AddWithValue("p1", TxtBolumid.Text);
                komut.ExecuteNonQuery();
                sqlbgl.baglanti().Close();
                MessageBox.Show("Bölüm Silindi");
                this.bolumlerTableAdapter.Fill(this.yurtotomasyonDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("Bölüm Silerken Bir Hata Oluştu");
            }
        }
        private void dataGridBolumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, bolumad;
            secilen = dataGridBolumler.SelectedCells[0].RowIndex;
            id = dataGridBolumler.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridBolumler.Rows[secilen].Cells[1].Value.ToString();

            TxtBolumid.Text = id;
            TxtBolumAd.Text = bolumad;
        }

        private void BolumDuzenleBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Update Bolumler Set bolum_isim = @p1 where bolum_id = @p2",sqlbgl.baglanti());
                komut.Parameters.AddWithValue("@p2", TxtBolumid.Text);
                komut.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut.ExecuteNonQuery();
                sqlbgl.baglanti().Close();
                MessageBox.Show("Bölüm Başarıyla Düzenlendi");
                this.bolumlerTableAdapter.Fill(this.yurtotomasyonDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("Bölüm Düzenlenirken Bir Hata Oluştu");
            }
            
        }
    }
}
