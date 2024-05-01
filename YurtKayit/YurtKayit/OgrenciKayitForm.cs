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
    public partial class OgrenciKayitForm : Form
    {
        public OgrenciKayitForm()
        {
            InitializeComponent();
        }

        SqlBaglanti sqlbgl = new SqlBaglanti();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bölüm Listeleme
            SqlCommand komut = new SqlCommand("Select bolum_isim From Bolumler", sqlbgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            sqlbgl.baglanti().Close();

            //Boş Oda Listeleme
            SqlCommand komut2 = new SqlCommand("Select oda_no From Odalar where oda_kapasite != oda_aktif", sqlbgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            sqlbgl.baglanti().Close();

        }
   
        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                //Öğrenci kayıt işlemi
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(ogrenci_isim,ogrenci_soyisim,ogrenci_tc,ogrenci_telefon,ogrenci_dogumtarih,ogrenci_bolum,ogrenci_mail,ogrenci_odano,ogrenci_veli_isim,ogrenci_veli_telefon,ogrenci_veli_adres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", sqlbgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", TxtAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", MskTc.Text);
                komutkaydet.Parameters.AddWithValue("@p4", MskTel.Text);
                komutkaydet.Parameters.AddWithValue("@p5", MskDogumTrh.Text);
                komutkaydet.Parameters.AddWithValue("@p6", CmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", TxtMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", MskVeliTel.Text);
                komutkaydet.Parameters.AddWithValue("@p11", RtxVeli.Text);
                komutkaydet.ExecuteNonQuery();
                sqlbgl.baglanti().Close();
                MessageBox.Show("Başarıyla Kayıt Yapıldı");

                //Borç kayıt işlemi
                SqlCommand kaydet = new SqlCommand("select ogrenci_id from Ogrenci", sqlbgl.baglanti());
                SqlDataReader oku = kaydet.ExecuteReader();
                while(oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                sqlbgl.baglanti().Close();

                SqlCommand komutkaydet2 = new SqlCommand("insert into Borc(ogrenci_id,ogrenci_ad,ogrenci_soyad) values(@b1,@b2,@b3)",sqlbgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", TxtAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", TxtSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                sqlbgl.baglanti().Close();
            }
            catch
            {
                MessageBox.Show("Kaydederken Bir Hata Oluştu");
            }
        }
    }
}
