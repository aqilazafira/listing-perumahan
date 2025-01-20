using perumahan.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perumahan.view
{
    public partial class DaftarRumah : Form
    {
        Koneksi koneksi = new Koneksi();

        public DaftarRumah()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            dataPerumahan.DataSource = koneksi.ShowData("SELECT * FROM t_perumahan");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DaftarRumah_Load(object sender, EventArgs e)
        {

        }
    }
}
