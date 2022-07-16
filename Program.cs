using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        class Mahasiswa
        {
            public string Nim { get; set; }
            public string NamaMahasiswa { get; set; }
            public string JenisKelamin { get; set; }
            public string Ipk { get; set; }
        }

        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> mhs = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            // Console.Title = "Responsi UAS Matakuliah Pemrograman";

            //int nomorMenu = 0;


            while (true)
            {
                TampilMenu();
                Console.Write("\n\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(nomorMenu);

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
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
            Console.Write("Pilih Menu Aplikasi");
            Console.Write("\n\n1.Tambah Mahasiswa");
            Console.Write("\n2.Tampil Mahasiswa");
            Console.Write("\n3.Keluar");
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Console.Write("Tambah Data Mahasiswa\n");
            Console.Write("\n");
            String jkelamin;

            // Console.Write("Isi data?");
            //String jawab = Console.ReadLine();
            Console.Write("NIM : ");
            String nim1 = Console.ReadLine();
            Console.Write("Nama : ");
            String nama = Console.ReadLine();
            Console.Write("Jenis Kelamin (L/P) : ");
            String jk = Console.ReadLine();
            if (jk == "L")
            {
                jkelamin = "Laki-Laki";

            }
            else if (jk == "P")
            {
                jkelamin = "Perempuan";
            }
            else
            {
                jkelamin = "Data yang anda masukkan tidak sesuai";
            }
            Console.Write("IPK : ");
            String ipk = Console.ReadLine();

            mhs.Add(new Mahasiswa
            {
                NamaMahasiswa = nama,
                Nim = nim1,
                JenisKelamin = jkelamin,
                Ipk = ipk
            });


            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Console.Write("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();



        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Kumpulan Data Mahasiswa");
            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            foreach (var data in mhs)
            {

                Console.WriteLine("Nim : {0}", data.Nim);
                Console.WriteLine("Nama Mahasiswa : {0}", data.NamaMahasiswa);
                Console.WriteLine("Jenis Kelamin : {0}", data.JenisKelamin);
                Console.WriteLine("Nilai IPK : {0}", data.Ipk);
                Console.WriteLine("==============");

            }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
            // TampilMenu();
        }
    }
}









