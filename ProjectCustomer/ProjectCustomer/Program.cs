using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        Environment.Exit(0);
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
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Customer");
            Customer customer = new Customer();
            Console.Write("Kode Customer:");
            customer.kode = Console.ReadLine();
            Console.Write("Nama Customer:");
            customer.nama = Console.ReadLine();
            Console.Write("Total Piutang:");
            customer.piutang = Convert.ToInt32(Console.ReadLine());
            daftarCustomer.Add(customer);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Customer");
            var kodedelete = Console.ReadLine();
            if (daftarCustomer.Exists(customer => customer.kode == kodedelete))
            {
                var ditemukan = daftarCustomer.First(customer => customer.kode == kodedelete);
                daftarCustomer.Remove(ditemukan);
                Console.WriteLine("Data Customer Berhasil Dihapus");
            }
            else
            {
                Console.WriteLine("Kode Customer Tidak Ditemukan");
            }
                Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();
            Console.WriteLine("Data Customer");
            int noUrut = 1;
            foreach (Customer customer in daftarCustomer)
            {
                Console.WriteLine("{0}. {1}, {2}, {3} ", noUrut, customer.kode, customer.nama, customer.piutang);
                noUrut++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
