namespace LostandFound
{
    partial class FormLaporBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WaktuLaporHilang = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLokasiHilang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKronologi = new System.Windows.Forms.TextBox();
            this.btnKirimLaporan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNamaBarang.Location = new System.Drawing.Point(117, 373);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(741, 26);
            this.txtNamaBarang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Deskripsi Barang";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDeskripsi.Location = new System.Drawing.Point(118, 495);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(738, 26);
            this.txtDeskripsi.TabIndex = 4;
            this.txtDeskripsi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(521, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "FORMULIR LAPORAN KEHILANGAN BARANG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(421, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Silahkan Isi Data Kehilangan Dengan Lengkap dan Akurat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Identitas Pelapor";
            // 
            // kategori
            // 
            this.kategori.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kategori.FormattingEnabled = true;
            this.kategori.Items.AddRange(new object[] {
            "Elektronik",
            "Dokumen",
            "Aksesoris",
            "Tas/Dompet",
            "Kunci"});
            this.kategori.Location = new System.Drawing.Point(118, 428);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(738, 28);
            this.kategori.TabIndex = 11;
            this.kategori.Text = "Pilih Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Detail Barang Hilang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nama Lengkap";
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNama.Location = new System.Drawing.Point(115, 194);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(741, 26);
            this.txtNama.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nomor HP";
            // 
            // txtNoHp
            // 
            this.txtNoHp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNoHp.Location = new System.Drawing.Point(115, 252);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(741, 26);
            this.txtNoHp.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(109, 583);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "Informasi Kejadian";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 623);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tanggal Kehilangan";
            // 
            // WaktuLaporHilang
            // 
            this.WaktuLaporHilang.Location = new System.Drawing.Point(122, 646);
            this.WaktuLaporHilang.Name = "WaktuLaporHilang";
            this.WaktuLaporHilang.Size = new System.Drawing.Size(212, 26);
            this.WaktuLaporHilang.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 689);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Lokasi Kehilangan";
            // 
            // txtLokasiHilang
            // 
            this.txtLokasiHilang.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLokasiHilang.Location = new System.Drawing.Point(120, 712);
            this.txtLokasiHilang.Name = "txtLokasiHilang";
            this.txtLokasiHilang.Size = new System.Drawing.Size(738, 26);
            this.txtLokasiHilang.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(120, 752);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Kronologi Kejadian";
            // 
            // txtKronologi
            // 
            this.txtKronologi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtKronologi.Location = new System.Drawing.Point(122, 775);
            this.txtKronologi.Name = "txtKronologi";
            this.txtKronologi.Size = new System.Drawing.Size(738, 26);
            this.txtKronologi.TabIndex = 24;
            // 
            // btnKirimLaporan
            // 
            this.btnKirimLaporan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKirimLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKirimLaporan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKirimLaporan.Location = new System.Drawing.Point(390, 834);
            this.btnKirimLaporan.Name = "btnKirimLaporan";
            this.btnKirimLaporan.Size = new System.Drawing.Size(187, 44);
            this.btnKirimLaporan.TabIndex = 25;
            this.btnKirimLaporan.Text = "Kirim Laporan";
            this.btnKirimLaporan.UseVisualStyleBackColor = false;
            this.btnKirimLaporan.Click += new System.EventHandler(this.btnKirimLaporan_Click);
            // 
            // FormLaporBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 931);
            this.Controls.Add(this.btnKirimLaporan);
            this.Controls.Add(this.txtKronologi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtLokasiHilang);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.WaktuLaporHilang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNoHp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNamaBarang);
            this.Name = "FormLaporBarang";
            this.Text = "Form Laporkan Kehilangan Barang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker WaktuLaporHilang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLokasiHilang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKronologi;
        private System.Windows.Forms.Button btnKirimLaporan;
    }
}