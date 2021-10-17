using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JualBeli_LIB;

namespace _160420014_MichaelTalahatu_JualBeliForm
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            try
            {
                Koneksi mysqlConnection = new Koneksi(db.Default.DbServer, db.Default.DbDatabase, db.Default.DbUsername, db.Default.DbPassword);
                MessageBox.Show("Koneksi berhasil!!","Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal... "+ex.Message,"Informasi");
            }
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["formDaftarKategoriView"];

            if (form == null)
            {
                formDaftarKategoriView form1 = new formDaftarKategoriView();
                form1.MdiParent = this;
                form1.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }

        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = Application.OpenForms["FormDaftarBarang"];

            if (form == null)
            {
                FormDaftarBarang form2 = new FormDaftarBarang();
                form2.MdiParent = this;
                form2.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }

        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarPegawai"];

            if (form == null)
            {
                FormDaftarPegawai form3 = new FormDaftarPegawai();
                form3.MdiParent = this;
                form3.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarPelanggan"];

            if (form == null)
            {
                FormDaftarPelanggan form4 = new FormDaftarPelanggan();
                form4.MdiParent = this;
                form4.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarSupplier"];

            if (form == null)
            {
                FormDaftarSupplier form5 = new FormDaftarSupplier();
                form5.MdiParent = this;
                form5.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarNotaJual"];

            if (form == null)
            {
                FormDaftarNotaJual form6 = new FormDaftarNotaJual();
                form6.MdiParent = this;
                form6.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarNotaBeli"];

            if (form == null)
            {
                FormDaftarNotaBeli form7 = new FormDaftarNotaBeli();
                form7.MdiParent = this;
                form7.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void keluarSistemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
