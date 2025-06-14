using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostandFound
{
    public partial class FormLaporBarang: Form
    {
        public FormLaporBarang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKirimLaporan_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=;database=lostfound"; 
            string namaBarang = txtNamaBarang.Text;
            string deskripsi = txtDeskripsi.Text + "\nKronologi:\n" + txtKronologi.Text;
            string tanggalHilang = WaktuLaporHilang.Value.ToString("yyyy-MM-dd");
            string lokasi = txtLokasiHilang.Text;

            string query = "INSERT INTO barang (nama, deskripsi, tanggal_hilang, lokasi, status) " +
                           "VALUES (@nama, @deskripsi, @tanggal, @lokasi, 'Hilang')";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", namaBarang);
                        cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
                        cmd.Parameters.AddWithValue("@tanggal", tanggalHilang);
                        cmd.Parameters.AddWithValue("@lokasi", lokasi);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Laporan barang hilang berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset isian form
                        txtNama.Clear();
                        txtNoHp.Clear();
                        txtNamaBarang.Clear();
                        txtDeskripsi.Clear();
                        txtKronologi.Clear();
                        txtLokasiHilang.Clear();
                        kategori.SelectedIndex = -1;
                        WaktuLaporHilang.Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
