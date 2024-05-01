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
    }
}
