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
    public partial class Giderler : Form
    {
        SqlBaglanti sqlbgl = new SqlBaglanti();
        public Giderler()
        {
            InitializeComponent();
        }

        private void Odemeler_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Odemeler (elektrik, su, dogalgaz, internet, gıda, personel_maas, diger_giderler) Values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", sqlbgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", Txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGida.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                komut.ExecuteNonQuery();
                sqlbgl.baglanti().Close();
                MessageBox.Show("Giderler Başarıyla Kaydedildi");
            }
            catch
            {
                MessageBox.Show("Giderler Kaydedilirken Bir Hata Oluştu");
            }
            
        }
    }
}
