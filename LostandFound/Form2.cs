using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LostandFound
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        // Fungsi untuk mengambil jumlah barang hilang dari database
        private void LoadJumlahBarangHilang()
        {
            string connStr = "server=localhost;user=root;database=lostfound;password=;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM barang WHERE status = 'Hilang';";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                        lblTotalHilang.Text = jumlah.ToString(); // tampilkan jumlah ke label
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
        }

        private void LoadBarangKeFlowLayout()
        {
            string connStr = "server=localhost;user=root;database=lostfound;password=;";
            string query = "SELECT * FROM barang";

            try
            {
                flowLayoutPanelBarang.Controls.Clear(); // Bersihkan dulu panelnya

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Ambil data dari setiap baris
                            string nama = reader["nama"].ToString();
                            string deskripsi = reader["deskripsi"].ToString();
                            string lokasi = reader["lokasi"].ToString();
                            string status = reader["status"].ToString();
                            DateTime tanggal = Convert.ToDateTime(reader["tanggal_hilang"]);

                            // Buat panel/card untuk satu barang
                            Panel card = new Panel();
                            card.Width = 250;
                            card.Height = 130;
                            card.Margin = new Padding(10);
                            card.BorderStyle = BorderStyle.FixedSingle;

                            Label lblNama = new Label();
                            lblNama.Text = "Nama: " + nama;
                            lblNama.AutoSize = true;
                            lblNama.Top = 10;
                            lblNama.Left = 10;

                            Label lblLokasi = new Label();
                            lblLokasi.Text = "Lokasi: " + lokasi;
                            lblLokasi.AutoSize = true;
                            lblLokasi.Top = 35;
                            lblLokasi.Left = 10;

                            Label lblTanggal = new Label();
                            lblTanggal.Text = "Tanggal: " + tanggal.ToShortDateString();
                            lblTanggal.AutoSize = true;
                            lblTanggal.Top = 60;
                            lblTanggal.Left = 10;

                            Label lblStatus = new Label();
                            lblStatus.Text = "Status: " + status;
                            lblStatus.AutoSize = true;
                            lblStatus.Top = 85;
                            lblStatus.Left = 10;

                            // Tambahkan komponen ke card
                            card.Controls.Add(lblNama);
                            card.Controls.Add(lblLokasi);
                            card.Controls.Add(lblTanggal);
                            card.Controls.Add(lblStatus);

                            // Tambahkan card ke flowLayoutPanel
                            flowLayoutPanelBarang.Controls.Add(card);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void LoadJumlahBarangDitemukan()
        {
            string connStr = "server=localhost;user=root;database=lostfound;password=;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM barang WHERE status = 'Ditemukan';";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                        lblTotalDitemukan.Text = jumlah.ToString(); // tampilkan di label
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            LoadJumlahBarangHilang(); // Panggil saat form dibuka
            LoadJumlahBarangDitemukan();
            LoadBarangKeFlowLayout();
        }

        // Fungsi-fungsi event handler lainnya (jika ada)
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHalamanLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void BtnLaporHilang_Click(object sender, EventArgs e)
        {
            FormLaporBarang nextForm = new FormLaporBarang();
            nextForm.Show();
            this.Hide();
        }

        private void btnLaporTemukan_Click(object sender, EventArgs e)
        {
            FormLaporTemu nextForm = new FormLaporTemu();
            nextForm.Show();
            this.Hide();
        }

        private void lblTotalDitemukan_Click(object sender, EventArgs e)
        {

        }
    }
}
