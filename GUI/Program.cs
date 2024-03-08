using System; // Menggunakan namespace System yang berisi fungsi-fungsi dasar
using System.Collections.Generic; // Menggunakan namespace untuk bekerja dengan koleksi data
using System.Linq; // Menggunakan namespace untuk bekerja dengan data, seperti melakukan query
using System.Threading.Tasks; // Menggunakan namespace untuk bekerja dengan threading dan task
using System.Windows.Forms; // Menggunakan namespace untuk bekerja dengan Windows Forms

namespace GUI // Mendefinisikan namespace dengan nama GUI
{
    internal static class Program // Mendefinisikan kelas statis bernama Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] // Atribut yang menunjukkan bahwa thread saat ini berjalan dalam model thread tunggal
        static void Main() // Metode utama yang akan dieksekusi saat aplikasi dijalankan
        {
            Application.EnableVisualStyles(); // Mengaktifkan visual styles untuk aplikasi
            Application.SetCompatibleTextRenderingDefault(false); // Mengatur pengaturan rendering teks default
            Application.Run(new Calculator()); // Menjalankan instansiasi baru dari kelas Calculator
        }
    }
}
