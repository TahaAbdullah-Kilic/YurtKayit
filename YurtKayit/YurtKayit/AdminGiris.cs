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
    public partial class AdminGiris : Form
    {
        SqlBaglanti sqlbgl = new SqlBaglanti();
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Yonetici where Yonetici_ad = @p1 and Yonetici_sifre = @p2",sqlbgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read()) 
            {
                AnaForm frm = new AnaForm();
                frm.ad = txtKullaniciAd.Text;
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi Girdiniz");
                txtKullaniciAd.Clear();
                txtSifre.Clear();
                txtKullaniciAd.Focus();
            }
            sqlbgl.baglanti().Close();
        }
    }
}
