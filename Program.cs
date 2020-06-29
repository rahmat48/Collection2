using CollectionInput.classAnak;
using CollectionInput.classInduk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInput
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<KaryawanTetap> Tetap = new List<KaryawanTetap>();
            List<KaryawanHarian> Harian = new List<KaryawanHarian>();
            List<Sales> sales = new List<Sales>();
            menu:
            int pil1;
            int pil2;

            Console.WriteLine("======================================");
            Console.WriteLine("|              MENU UTAMA            |");
            Console.WriteLine("======================================");
            Console.WriteLine("|  1. Input Data Pegawai             |");
            Console.WriteLine("|  2. Lihat Data Pegawai             |");
            Console.WriteLine("|  3. Hapus Data Pegawai             |");
            Console.WriteLine("|  4. Keluar                         |");
            Console.WriteLine("======================================");
            Console.Write(" Masukkan pilihan [1]/[2]/[3]/[4] : ");
            

            pil1 = int.Parse(Console.ReadLine());
            if (pil1 == 1)
            {
                Console.Clear();
                Console.WriteLine("1. Input Data Pegawai Tetap");
                Console.WriteLine("2. Input Data Pegawai Kontrak");
                Console.WriteLine("3. Input Data Sales");
                Console.Write("Masukkan pilihan [1]/[2]/[3] : ");
                pil2 = int.Parse(Console.ReadLine());

                if (pil2 == 1)
                {
                    string nik, name;
                    double Gaji1;
                    Console.Write("Masukan Nama : ");
                    name = Console.ReadLine();
                    Console.Write("Masukan Nik  : ");
                    nik = Console.ReadLine();
                    Console.Write("Gaji Bulanan : ");
                    Gaji1 = int.Parse(Console.ReadLine());
                    Tetap.Add(new KaryawanTetap() {Nik = nik, Nama = name, GajiBulanan = Gaji1});
                }
                else if (pil2 == 2)
                {
                    string nik, name;
                    double jam, upah;
                    Console.Write("Masukan Nama : ");
                    name = Console.ReadLine();
                    Console.Write("Masukan Nik  : ");
                    nik = Console.ReadLine();
                    Console.Write("Masukan Jumlah Jam : ");
                    jam = int.Parse(Console.ReadLine());
                    Console.Write("Masukan Upah : ");
                    upah = int.Parse(Console.ReadLine());

                    Harian.Add(new KaryawanHarian() { Nik = nik, Nama = name, UpahPerJam = upah, JumlahJamKerja = jam });
                }
                else if (pil2 == 3)
                {
                    string name, nik;
                    double jumlah, komisi;
                    Console.Write("Masukan Nama   : ");
                    name = Console.ReadLine();
                    Console.Write("Masukan Nik    : ");
                    nik = Console.ReadLine();
                    Console.Write("Masukan Jumlah Penjualan : ");
                    jumlah = int.Parse(Console.ReadLine());
                    Console.Write("Masukan Komisi : ");
                    komisi = int.Parse(Console.ReadLine());

                    sales.Add(new Sales() { Nik = nik, Nama = name, JumlahPenjualan = jumlah, Komisi = komisi});

                }
                Console.WriteLine("Tekan Enter untuk kembali....");
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            else if (pil1 == 2)
            {
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine("|           List Data Pegawai           |");
                Console.WriteLine("=========================================");
                Console.WriteLine("");
                int no = 1;
                foreach (Karyawan karyawan in Tetap)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Karyawan Tetap",
                    no, karyawan.Nik, karyawan.Nama, karyawan.gaji());
                    no++;
                }
                foreach (Karyawan karyawan in Harian)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Karyawan Harian",
                    no, karyawan.Nik, karyawan.Nama, karyawan.gaji());
                    no++;
                }
                foreach (Karyawan karyawan in sales)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Sales",
                    no, karyawan.Nik, karyawan.Nama, karyawan.gaji());
                    no++;
                }
                Console.WriteLine("Tekan Enter untuk kembali....");
                Console.ReadKey(true);
                Console.Clear();
                goto menu;

            }
            else if (pil1 == 3)
            {
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine("|           List Data Pegawai           |");
                Console.WriteLine("=========================================");
                Console.WriteLine("");
                int no = 1;
                foreach (Karyawan karyawan in Tetap)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Karyawan Tetap",
                    no, karyawan.Nik, karyawan.Nama, karyawan.gaji());
                    no++;
                }
                foreach (Karyawan karyawan in Harian)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Karyawan Harian",
                    no, karyawan.Nik, karyawan.Nama, karyawan.gaji());
                    no++;
                }
                foreach (Karyawan karyawan in sales)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Sales",
                    no, karyawan.Nik, karyawan.Nama, karyawan.gaji());
                    no++;
                }
                Console.WriteLine("======================");
                Console.WriteLine("Pilihan Hapus Karyawan");
                string hapus;
                Console.WriteLine("======================");
                Console.Write("Masukan NIK : ");
                hapus = Console.ReadLine();
                int x = 0;
                foreach (Karyawan karyawan in Tetap)
                {
                    if (hapus == karyawan.Nik)
                    {
                        Tetap.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (Karyawan karyawan in Harian)
                {
                    if (hapus == karyawan.Nik)
                    {
                        Harian.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (Karyawan karyawan in sales)
                {
                    if (hapus == karyawan.Nik)
                    {
                        sales.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                Console.WriteLine("Tekan Enter untuk kembali....");
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            else
            {
                Console.WriteLine("Terimakasih telah menggunakan Aplikasi ini");
            }


            Console.ReadKey(true);
            Console.Clear();

        }
    }
}
