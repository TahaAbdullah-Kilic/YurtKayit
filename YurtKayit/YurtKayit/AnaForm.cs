using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayit
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtotomasyonDataSet1.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtotomasyonDataSet1.Ogrenci);

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
    }
}
