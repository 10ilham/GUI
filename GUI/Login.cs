using System; // Menggunakan namespace System yang berisi kelas-kelas dasar dan inti
using System.Collections.Generic; // Menggunakan namespace yang berisi interface dan kelas yang mendefinisikan jenis koleksi generik
using System.ComponentModel; // Menggunakan namespace yang berisi kelas yang digunakan untuk mengimplementasikan atribut dan kelas yang mendefinisikan tipe konversi tipe
using System.Data; // Menggunakan namespace yang berisi kelas untuk mengakses dan mengelola data dari sumber data
using System.Drawing; // Menggunakan namespace yang berisi kelas untuk grafik dasar
using System.Linq; // Menggunakan namespace yang berisi kelas dan interface yang mendukung query yang menggunakan Language-Integrated Query (LINQ)
using System.Text; // Menggunakan namespace yang berisi kelas yang merepresentasikan blok teks ASCII dan Unicode
using System.Threading.Tasks; // Menggunakan namespace yang menyediakan tipe yang menyederhanakan bekerja dengan Task dan data paralel
using System.Windows.Forms; // Menggunakan namespace yang berisi kelas untuk membuat aplikasi Windows yang memiliki antarmuka pengguna grafis

namespace GUI // Mendefinisikan namespace dengan nama GUI
{
    public partial class Login : Form // Mendefinisikan kelas Login yang merupakan bagian dari Form
    {
        public Login() // Konstruktor kelas Login
        {
            InitializeComponent(); // Metode untuk menginisialisasi komponen pada form
        }

        private void label3_Click(object sender, EventArgs e) // Metode yang akan dipanggil saat label3 diklik
        {

        }

        private void Login_Click(object sender, EventArgs e) // Metode yang akan dipanggil saat tombol Login diklik
        {
            if (User_id.Text == "220102037" && Password.Text == "220102037") // Jika User_id dan Password sesuai
            {
                Dashboard dashboard = new Dashboard(); // Membuat objek baru dari kelas Dashboard
                dashboard.Show(); // Menampilkan form Dashboard
                this.Hide(); // Menyembunyikan form Login
            }
            else // Jika User_id dan Password tidak sesuai
            {
                MessageBox.Show("Maaf, User ID Atau Password Anda Salah.",
                    "Kesalahan", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation); // Menampilkan pesan kesalahan
                User_id.Focus(); // Mengatur fokus ke User_id
                User_id.SelectAll(); // Memilih semua teks di User_id
            }
        }

        private void Exit_Click(object sender, EventArgs e) // Metode yang akan dipanggil saat tombol Exit diklik
        {
            if (MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
               "Konfirmasi", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes) // Jika user memilih 'Yes' pada dialog konfirmasi
            {
                Application.Exit(); // Aplikasi akan ditutup
            }
        }

        private void Password_TextChanged(object sender, EventArgs e) // Metode yang akan dipanggil saat teks di Password berubah
        {

        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e) // Metode yang akan dipanggil saat tombol ditekan di Password
        {
            if (e.KeyChar == 13) // Jika tombol yang ditekan adalah 'Enter' (ASCII 13)
            {
                Login_btn.PerformClick(); // Mengeksekusi klik pada tombol Login
            }
        }

        private void User_id_TextChanged(object sender, EventArgs e) // Metode yang akan dipanggil saat teks di User_id berubah
        {

        }

        private void Login_Load(object sender, EventArgs e) // Metode yang akan dipanggil saat form Login dimuat
        {

        }
    }
}