using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luas_Lingkaran
{
    class Program
    {
        static void Main(string[] args)
        {
            PersegiPj pp = new PersegiPj();
            pp.input();
            pp.proses();
            pp.hasil();
        }
    }

    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class PersegiPj memuat operasi untuk menghitung luas persegi panjang</remarks>
    class PersegiPj
    {
        /// <summary>
        /// mendeklarasikan tipe data variabel panjang
        /// </summary>
        double panjang;

        /// <summary>
        /// mendeklarasikan tipe data variabel lebar
        /// </summary>
        double lebar;

        /// <summary>
        /// mendeklarasikan tipe data variabel luas
        /// </summary>
        double luas;

        /// <summary>
        /// method input untuk memasukkan input untuk diproses
        /// </summary>
        public void input()
        {
            Console.Write("Masukkan panjang = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar = ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// method proses untuk memproses input yang telah diberikan
        /// </summary>
        public void proses()
        {
            luas = panjang * lebar;
        }

        /// <summary>
        /// method hasil untuk menampilkan hasil yang diperoleh dari proses perhitungan
        /// </summary>
        public void hasil()
        {
            Console.Write("Luas Persegi Panjang adalah " + luas);
            Console.ReadKey();
        }
    }
}
