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
    public partial class AnaForm : Form
    {
        public string ad;
        public AnaForm()
        {
            InitializeComponent();
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = ad;

        }

        private void ogrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListesi frm = new OgrenciListesi();
            frm.Show();
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciKayitForm frm = new  OgrenciKayitForm();
            frm.Show();
        }

        private void bolumDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bolumler frm = new Bolumler();
            frm.Show();
        }

        private void öğrenciÖdemesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odeme frm = new Odeme();
            frm.Show();
        }

        private void ogrenciDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciDuzenle frm = new OgrenciDuzenle();
            frm.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giderler frm = new Giderler();
            frm.Show();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiderListesi frm = new GiderListesi();
            frm.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gelir frm = new Gelir();
            frm.Show();
        }

        private void öğrenciİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiDuzenle frm = new YoneticiDuzenle();
            frm.Show();
        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel frm = new Personel();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }
    }
}
