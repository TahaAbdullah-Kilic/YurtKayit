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
    public partial class OgrenciDuzenle : Form
    {
        public string id, ad, soyad, tc, telefon, dogum, bolum, mail, oda, veliad, velitelefon, veliadres;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Ogrenci where @a1 = ogrenci_id", sqlbgl.baglanti());
            komut.Parameters.AddWithValue("@a1", Txtid.Text);
            komut.ExecuteNonQuery();
            sqlbgl.baglanti().Close();
            MessageBox.Show("Ogrenci Başarıyla Silindi.");

            SqlCommand komutoda = new SqlCommand("Update Odalar set oda_aktif=oda_aktif-1 where oda_no = @k1", sqlbgl.baglanti());
            komutoda.Parameters.AddWithValue("@k1", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            sqlbgl.baglanti().Close();

            SqlCommand komutborc = new SqlCommand("delete from Borc where @p1 = ogrenci_id", sqlbgl.baglanti());
            komut.Parameters.AddWithValue("@a1", Txtid.Text);
            komut.ExecuteNonQuery();
            sqlbgl.baglanti().Close();
        }

        SqlBaglanti sqlbgl = new SqlBaglanti();
        public OgrenciDuzenle()
        {
            InitializeComponent();
        }
        private void OgrenciDuzenle_Load(object sender, EventArgs e)
        {
            Txtid.Text = id;
            TxtAd.Text = ad;
            TxtSoyad.Text = soyad;
            MskTc.Text = tc;
            MskTel.Text = telefon;
            MskDogumTrh.Text = dogum;
            CmbBolum.Text = bolum;
            TxtMail.Text = mail;
            CmbOdaNo.Text = oda;
            TxtVeliAdSoyad.Text = veliad;
            MskVeliTel.Text = velitelefon;
            RtxVeli.Text = veliadres;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set ogrenci_isim = @p2, ogrenci_soyisim = @p3, ogrenci_tc = @p4, ogrenci_telefon = @p5, ogrenci_dogumtarih = @p6, ogrenci_bolum = @p7, ogrenci_mail = @p8, ogrenci_odano = @p9, ogrenci_veli_isim = @p10, ogrenci_veli_telefon = @p11, ogrenci_veli_adres = @p12 where ogrenci_id = @p1", sqlbgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.Parameters.AddWithValue("@p2", TxtAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskTc.Text);
                komut.Parameters.AddWithValue("@p5", MskTel.Text);
                komut.Parameters.AddWithValue("@p6", MskDogumTrh.Text);
                komut.Parameters.AddWithValue("@p7", CmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", TxtMail.Text);
                komut.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", MskVeliTel.Text);
                komut.Parameters.AddWithValue("@p12", RtxVeli.Text);
                komut.ExecuteNonQuery();
                sqlbgl.baglanti().Close();
                MessageBox.Show("Öğrenci Bilgileri Güncellendi");
            }
            catch
            {
                MessageBox.Show("Bilgiler Düzenlenirken Hata Oluştu");
            }
        }
    }
}
