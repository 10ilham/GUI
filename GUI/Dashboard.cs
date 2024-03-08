using System; // Menggunakan namespace System yang berisi kelas-kelas dasar dan inti
using System.Collections.Generic; // Menggunakan namespace untuk bekerja dengan koleksi data
using System.ComponentModel; // Menggunakan namespace untuk implementasi komponen dan kontrol
using System.Data; // Menggunakan namespace untuk akses data dan manajemen data
using System.Drawing; // Menggunakan namespace untuk akses ke fungsi grafis dasar GDI+
using System.Linq; // Menggunakan namespace untuk bekerja dengan data menggunakan LINQ (Language Integrated Query)
using System.Text; // Menggunakan namespace untuk bekerja dengan teks
using System.Threading.Tasks; // Menggunakan namespace untuk bekerja dengan threading dan tugas paralel
using System.Windows.Forms; // Menggunakan namespace untuk membuat aplikasi Windows Forms

namespace GUI // Mendefinisikan namespace bernama GUI
{
    public partial class Dashboard : Form // Mendefinisikan kelas parcial (partial) bernama Dashboard yang merupakan turunan dari kelas Form
    {
        public Dashboard() // Konstruktor untuk kelas Dashboard
        {
            InitializeComponent(); // Memanggil metode untuk menginisialisasi komponen pada form
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e) // Metode yang akan dipanggil ketika item menu 'mahasiswa' diklik
        {
            Form1 form1 = new Form1(); // Membuat instance baru dari Form1
            form1.ShowDialog(); // Menampilkan Form1 sebagai dialog
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) // Metode yang akan dipanggil ketika item menu 'logout' diklik
        {
            Login login = new Login(); // Membuat instance baru dari Login
            login.Show(); // Menampilkan form Login
            Close(); // Menutup form Dashboard
        }
    }
}
