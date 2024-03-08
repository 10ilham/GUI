using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Mendefinisikan namespace
namespace GUI
{
    // Mendefinisikan kelas Calculator yang merupakan turunan dari Form
    public partial class Calculator : Form
    {
        // Mendeklarasikan variabel untuk menyimpan bilangan dan hasil operasi
        double bil1, bil2, hasil;

        // Method yang dipanggil ketika tombol kurang diklik
        private void kurang_btn_Click(object sender, EventArgs e)
        {
            // Memeriksa apakah input adalah angka
            if (!double.TryParse(bilSatu_txt.Text, out bil1) || !double.TryParse(bilDua_txt.Text, out bil2))
            {
                // Menampilkan pesan error jika input bukan angka
                MessageBox.Show("Masukkan hanya angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Menghentikan eksekusi jika input tidak valid
            }

            // Melakukan operasi pengurangan dan menyimpan hasilnya
            hasil = bil1 - bil2;
            // Menampilkan hasil operasi
            Hasil_txt.Text = hasil.ToString();
        }

        // Method yang dipanggil ketika tombol kali diklik
        private void kali_btn_Click(object sender, EventArgs e)
        {
            // Memeriksa apakah input adalah angka
            if (!double.TryParse(bilSatu_txt.Text, out bil1) || !double.TryParse(bilDua_txt.Text, out bil2))
            {
                // Menampilkan pesan error jika input bukan angka
                MessageBox.Show("Masukkan hanya angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Melakukan operasi perkalian dan menyimpan hasilnya
            hasil = bil1 * bil2;
            // Menampilkan hasil operasi
            Hasil_txt.Text = hasil.ToString();
        }

        // Method yang dipanggil ketika tombol bagi diklik
        private void bagi_btn_Click(object sender, EventArgs e)
        {
            // Memeriksa apakah input adalah angka
            if (!double.TryParse(bilSatu_txt.Text, out bil1) || !double.TryParse(bilDua_txt.Text, out bil2))
            {
                // Menampilkan pesan error jika input bukan angka
                MessageBox.Show("Masukkan hanya angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Melakukan operasi pembagian dan menyimpan hasilnya
            hasil = bil1 / bil2;
            // Menampilkan hasil operasi
            Hasil_txt.Text = hasil.ToString();
        }

        // Method untuk membersihkan input dan hasil
        void bersihkan()
        {
            bilSatu_txt.Clear();
            bilDua_txt.Clear();
            Hasil_txt.Clear();
        }

        // Method yang dipanggil ketika tombol close diklik
        private void close_btn_Click(object sender, EventArgs e)
        {
            // Menghentikan aplikasi
            Application.Exit();
        }

        // Method yang dipanggil ketika tombol new diklik
        private void new_btn_Click(object sender, EventArgs e)
        {
            // Membersihkan input dan hasil
            bersihkan();
            // Mengatur fokus ke input pertama
            bilSatu_txt.Focus();
        }

        // Method untuk menangani event keydown
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            // Jika tombol N dan Ctrl ditekan bersamaan
            if (e.KeyCode == Keys.N && e.Control)
            {
                // Memanggil method new_btn_Click
                new_btn.PerformClick();
            }
        }

        // Method yang dipanggil ketika tombol enter ditekan di input pertama
        private void bilSatu_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Jika tombol enter ditekan
            if (e.KeyChar == 13)
            {
                // Mengatur fokus ke input kedua
                bilDua_txt.Focus();
            }
        }

        // Konstruktor kelas Calculator
        public Calculator()
        {
            // Inisialisasi komponen GUI
            InitializeComponent();
        }

        // Method yang dipanggil ketika tombol tambah diklik
        private void tambah_btn_Click(object sender, EventArgs e)
        {
            // Memeriksa apakah input adalah angka
            if (!double.TryParse(bilSatu_txt.Text, out bil1) || !double.TryParse(bilDua_txt.Text, out bil2))
            {
                // Menampilkan pesan error jika input bukan angka
                MessageBox.Show("Masukkan hanya angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Melakukan operasi penjumlahan dan menyimpan hasilnya
            hasil = bil1 + bil2;
            // Menampilkan hasil operasi
            Hasil_txt.Text = hasil.ToString();
        }
    }
}
