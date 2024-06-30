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
    public partial class GiderListesi : Form
    {
        SqlBaglanti sqlbgl = new SqlBaglanti();
        public GiderListesi()
        {
            InitializeComponent();
        }

        private void GiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtotomasyonDataSet4.Odemeler' table. You can move, or remove it, as needed.
            this.odemelerTableAdapter.Fill(this.yurtotomasyonDataSet4.Odemeler);

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GiderDuzenle gdrdzn = new GiderDuzenle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            gdrdzn.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            gdrdzn.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gdrdzn.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            gdrdzn.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            gdrdzn.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            gdrdzn.gida = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            gdrdzn.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            gdrdzn.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            gdrdzn.Show();
        }
    }
}
