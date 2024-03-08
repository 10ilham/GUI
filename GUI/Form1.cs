using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            isiAgama(); //Memanggil prosedur isiAgama
            isiJenjang(); //Memanggil prosedur isiJenjang
            isiJurusan(); //Memanggil prosedur isiJurusan
            isiKota(); //Memanggil prosedur isiKota
        }

        //Prosedur untuk mengisi combo box agama
        void isiAgama()
        {
            Agama_lsb.Items.Clear();
            Agama_lsb.Items.Add("Islam");
            Agama_lsb.Items.Add("Kristen");
            Agama_lsb.Items.Add("Katolik");
            Agama_lsb.Items.Add("Hindu");
            // Menambahkan item "Budha" ke dalam list box Agama_lsb
            Agama_lsb.Items.Add("Budha");
            // Menambahkan item "Konghucu" ke dalam list box Agama_lsb
            Agama_lsb.Items.Add("Konghucu");
        }

        // Fungsi untuk mengisi list box Jurusan_lsb
        void isiJurusan()
        {
            // Menghapus semua item yang ada di dalam list box Jurusan_lsb
            Jurusan_lsb.Items.Clear();
            // Menambahkan item-item berikut ke dalam list box Jurusan_lsb
            Jurusan_lsb.Items.Add("Teknik Informatika");
            Jurusan_lsb.Items.Add("Teknik Listrik");
            Jurusan_lsb.Items.Add("Teknik Elektro");
            Jurusan_lsb.Items.Add("Teknik Mesin");
            Jurusan_lsb.Items.Add("Teknik Sipil");
        }

        // Fungsi untuk mengisi list box Jenjang_lsb
        void isiJenjang()
        {
            // Menghapus semua item yang ada di dalam list box Jenjang_lsb
            Jenjang_lsb.Items.Clear();
            // Menambahkan item-item berikut ke dalam list box Jenjang_lsb
            Jenjang_lsb.Items.Add("D3");
            Jenjang_lsb.Items.Add("D4");
            Jenjang_lsb.Items.Add("S2");
            Jenjang_lsb.Items.Add("S3");
        }

        // Fungsi untuk mengisi list box Kota_lsb
        void isiKota()
        {
            // Menghapus semua item yang ada di dalam list box Kota_lsb
            Kota_lsb.Items.Clear();
            // Menambahkan item-item berikut ke dalam list box Kota_lsb
            Kota_lsb.Items.Add("Jakarta");
            Kota_lsb.Items.Add("Bandung");
            Kota_lsb.Items.Add("Surabaya");
            Kota_lsb.Items.Add("Semarang");
            Kota_lsb.Items.Add("Yogyakarta");
        }

        // Fungsi yang dipanggil saat form pertama kali dimuat
        private void Form1_Load(object sender, EventArgs e)
        {
            // isiAgama();
        }

        // Fungsi yang dipanggil saat radio button 1 berubah status checked-nya
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Fungsi yang dipanggil saat item yang dipilih di list box 1 berubah
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Fungsi yang dipanggil saat label 3 diklik
        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Fungsi yang dipanggil saat label 9 diklik
        private void label9_Click(object sender, EventArgs e)
        {

        }

        // Fungsi untuk menampilkan data
        string tampilkanData()
        {
            // Membuat variabel jenis dan mengisinya berdasarkan radio button yang dipilih
            string jenis = "";
            if (Laki_laki.Checked == true)
            {
                jenis = Laki_laki.Text;
            }
            else if (Perempuan.Checked == true)
            {
                jenis = Perempuan.Text;
            }

            // Membuat string informasi berdasarkan data yang ada
            string informasi = "No.Induk\t: " + No_induk.Text + "\n" +
                 "Nama Mahasiswa\t: " + Mahasiswa.Text + "\n" +
                 "Jenis Kelamin\t: " + jenis + "\n" +
                 "Agama\t\t: " + Agama_lsb.Text + "\n" +
                 "Jurusan\t\t: " + Jurusan_lsb.Text + "\n" +
                 "Jenjang\t\t: " + Jenjang_lsb.Text + "\n" +
                 "Alamat\t\t: " + Alamat_lsb.Text + "\n" +
                 "Kota\t\t: " + Kota_lsb.Text + "\n" +
                 "Telpon\t\t: " + Telpon_lsb.Text;

            // Mengembalikan string informasi
            return informasi;
        }

        // Fungsi yang dipanggil saat teks di No_induk berubah
        private void No_induk_TextChanged(object sender, EventArgs e)
        {

        }

        // Fungsi untuk membersihkan semua field
        void bersihkan()
        {
            // Menghapus teks di No_induk
            No_induk.Clear();
            // Menghapus teks di Mahasiswa
            Mahasiswa.Clear();
            // Mengatur radio button Laki_laki dan Perempuan menjadi tidak dipilih
            Laki_laki.Checked = false;
            Perempuan.Checked = false;
            // Mengatur item yang dipilih di Agama_lsb, Jurusan_lsb, Jenjang_lsb, dan Kota_lsb menjadi tidak ada
            Agama_lsb.SelectedIndex = -1;
            Jurusan_lsb.SelectedIndex = -1;
            Jenjang_lsb.SelectedIndex = -1;
            // Menghapus teks di Alamat_lsb
            Alamat_lsb.Clear();
            // Mengatur item yang dipilih di Kota_lsb menjadi tidak ada
            Kota_lsb.SelectedIndex = -1;
            // Menghapus teks di Telpon_lsb
            Telpon_lsb.Clear();
        }

        // Fungsi yang dipanggil saat tombol Tambah_lsb diklik
        private void Tambah_lsb_Click(object sender, EventArgs e)
        {
            // Membersihkan semua field
            bersihkan();
            // Mengatur fokus ke No_induk
            No_induk.Focus();
        }

        // Fungsi yang dipanggil saat tombol enter ditekan di No_induk
        private void No_induk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                // Mengatur fokus ke Mahasiswa
                Mahasiswa.Focus();
            }
        }

        // Fungsi yang dipanggil saat tombol keyboard ditekan di form
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Jika tombol T dan control ditekan bersamaan, klik tombol Tampil_lsb
            if (e.KeyCode == Keys.T && e.Control)
            {
                Tampil_lsb.PerformClick();
            }
        }

        // Fungsi yang dipanggil saat tombol Keluar diklik
        private void Keluar_Click(object sender, EventArgs e)
        {
            // Menutup form
            Close();
            // Application.Exit();
        }

        // Fungsi yang dipanggil saat tombol Tampil_lsb diklik
        private void Tampil_lsb_Click(object sender, EventArgs e)
        {
            // Menampilkan pesan dengan informasi mahasiswa
            MessageBox.Show(tampilkanData(),
            "Informasi Mahasiswa",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        // Fungsi yang dipanggil saat teks di Mahasiswa berubah
        private void Mahasiswa_TextChanged(object sender, EventArgs e)
        {

        }

        // Fungsi yang dipanggil saat teks di Alamat_lsb berubah
        private void Alamat_lsb_TextChanged(object sender, EventArgs e)
        {

        }

        // Fungsi yang dipanggil saat item yang dipilih di Agama_lsb berubah
        private void Agama_lsb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
