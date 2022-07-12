using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            bool statusMenu = true;

            while (statusMenu)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampil Penjualan");
            Console.WriteLine("3. Keluar");
            Console.WriteLine();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Tambah Penjualan");
            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Console.Write("Nota: ");
            string nota = Console.ReadLine();
            Console.Write("Tanggal: ");
            string tanggal = Console.ReadLine();
            Console.Write("Customer: ");
            string customer = Console.ReadLine();
            Console.Write("Jenis [T/K]: ");
            char tipe = Convert.ToChar(Console.ReadLine());
            string jenisPembayaran;
            if (tipe == 'T')
            {
                jenisPembayaran = "Tunai";
            } else
            {
                jenisPembayaran = "Kredit";
            }

            Console.Write("Total Nota: ");
            string totalnota = Console.ReadLine();

            Penjualan penjualan = new Penjualan();
            penjualan.Nota = nota;
            penjualan.Tanggal = tanggal;
            penjualan.Customer = customer;
            penjualan.JenisPembayaran = jenisPembayaran;
            penjualan.TotalNota = totalnota;

            daftarPenjualan.Add(new Penjualan());

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Data Penjualan\n");
            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int i = 1;
            foreach (Penjualan daftar in daftarPenjualan)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, i, ")
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
