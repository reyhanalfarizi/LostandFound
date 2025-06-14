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
    public partial class FormLaporTemu: Form
    {
        public FormLaporTemu()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnLaporTemu_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=lostfound;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO barang 
                            (nama, deskripsi, tanggal_hilang, lokasi, status)
                            VALUES (@nama, @deskripsi, @tanggal, @lokasi, 'Ditemukan')";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", txtNamaBarang.Text); // nama barang
                        cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                        cmd.Parameters.AddWithValue("@tanggal", WaktuLaporHilang.Value.Date);
                        cmd.Parameters.AddWithValue("@lokasi", txtLokasiTemu.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data barang ditemukan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset form
                        txtNamaBarang.Clear();
                        txtDeskripsi.Clear();
                        txtLokasiTemu.Clear();
                        WaktuLaporHilang.Value = DateTime.Now;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
