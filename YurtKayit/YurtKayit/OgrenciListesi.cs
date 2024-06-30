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
    public partial class OgrenciListesi : Form
    {
        public OgrenciListesi()
        {
            InitializeComponent();
        }

        private void OgrenciListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtotomasyonDataSet3.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtotomasyonDataSet3.Ogrenci);

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OgrenciDuzenle liste = new OgrenciDuzenle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            liste.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            liste.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            liste.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            liste.tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            liste.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            liste.dogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            liste.bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            liste.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            liste.oda = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            liste.veliad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            liste.velitelefon = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            liste.veliadres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            OgrenciListesi ogrlist = new OgrenciListesi();
            liste.Show();
        }
    }
}
