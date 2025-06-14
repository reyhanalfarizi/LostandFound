using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Tambahkan ini

namespace LostandFound
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // Pastikan kamu punya TextBox bernama txtUsername
            string password = txtPassword.Text; // Dan txtPassword

            string connStr = "server=localhost;user=root;database=lostfound;password=;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form6 dashboard = new Form6(); // Form setelah login
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
