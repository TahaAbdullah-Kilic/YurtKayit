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
    public partial class GiderDuzenle : Form
    {
        public string id, elektrik, dogalgaz, su, internet, gida, personel, diger;
        SqlBaglanti sqlbgl = new SqlBaglanti();

        public GiderDuzenle()
        {
            InitializeComponent();
        }

        private void GiderDuzenle_Load(object sender, EventArgs e)
        {
            Txtid.Text = id;
            TxtElektrik.Text = elektrik;
            TxtSu.Text = su;
            TxtDogalgaz.Text = dogalgaz;
            Txtinternet.Text = internet;
            TxtGida.Text = gida;
            TxtPersonel.Text = personel;
            TxtDiger.Text = diger;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Odemeler set elektrik = @p1, su = @p2, dogalgaz = @p3, internet = @p4, gıda = @p5, personel_maas = @p6, diger_giderler = @p7 where odeme_id = @p8", sqlbgl.baglanti());
                komut.Parameters.AddWithValue("@p8", Txtid.Text);
                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", Txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGida.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                komut.ExecuteNonQuery();
                sqlbgl.baglanti().Close();
                MessageBox.Show("Başarıyla Güncellendi");
            }
            catch
            {
                MessageBox.Show("Güncellenirken Bir Hata Oluştu");  
            }
            
        }
    }
}
