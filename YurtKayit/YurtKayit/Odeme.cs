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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YurtKayit
{
    public partial class Odeme : Form
    {
        SqlBaglanti sqlbgl = new SqlBaglanti();
        public Odeme()
        {
            InitializeComponent();
        }
        
        private void Odeme_Load(object sender, EventArgs e)
        {
            this.borcTableAdapter.Fill(this.yurtotomasyonDataSet2.Borc);        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalanborc;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalanborc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtOgrid.Text = id;
            txtOgrKalan.Text = kalanborc;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            txtArama.Text = "";
            string aranan = txtArama.Text;
            arama(aranan);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int odenen, borc, kalan;
                odenen = Convert.ToInt16(txtOgrOdenen.Text);
                borc = Convert.ToInt16(txtOgrKalan.Text);
                if (odenen <= borc)
                {
                    kalan = borc - odenen;
                    txtOgrKalan.Text = kalan.ToString();


                    SqlCommand komut = new SqlCommand("update Borc set ogrenci_borc = @p1 where ogrenci_id = @p2", sqlbgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtOgrKalan.Text);
                    komut.Parameters.AddWithValue("@p2", txtOgrid.Text);
                    komut.ExecuteNonQuery();
                    sqlbgl.baglanti().Close();
                    MessageBox.Show("Borç ödemesi gerçekleştirildi");
                    arama("");
                    this.borcTableAdapter.Fill(this.yurtotomasyonDataSet2.Borc);
                }
                
                else
                {
                    MessageBox.Show("Ödenilen Değer Borçdan Büyük Olamaz!");
                }
                
                
                SqlCommand komut2 = new SqlCommand("insert into Kasa (ogrenci_id,Odeme_Ay,Odeme_Yil,Odeme_Miktar) values (@k1,@k2,@k3,@k4)", sqlbgl.baglanti());
                komut2.Parameters.AddWithValue("@k1", txtOgrid.Text);
                komut2.Parameters.AddWithValue("@k2", cmbAy.Text);
                komut2.Parameters.AddWithValue("@k3", cmbYil.Text);
                komut2.Parameters.AddWithValue("@k4", txtOgrOdenen.Text);
                komut2.ExecuteNonQuery();
                sqlbgl.baglanti().Close();
            }
            catch
            {
                MessageBox.Show("Ödeme Esnasında Bir Hata Oluştu");
            }
            
        }
        public void arama(string aranan)
        {
                SqlCommand komut2 = new SqlCommand("Select * from Borc where(ogrenci_ad) like '%" + aranan + "%'", sqlbgl.baglanti());
                SqlDataAdapter adapter = new SqlDataAdapter(komut2);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                sqlbgl.baglanti().Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string aranan = txtArama.Text.ToString();
            arama(aranan);
        }

        private void txtOgrOdenen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
