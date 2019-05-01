using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2278
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karpertama = new Karyawan();

            karpertama.Nik = "2278";
            karpertama.Nama = "Van";
            karpertama.GajiBulanan = 5000000;

            Karyawan karkedua = new Karyawan();

            karkedua.Nik = "7822";
            karkedua.Nama = "Daarten";
            karkedua.GajiBulanan = 3000000;

            Console.WriteLine("No. \tNIK/nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karpertama.Nik, karpertama.Nama, karpertama.GajiBulanan);
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karkedua.Nik, karkedua.Nama, karkedua.GajiBulanan);
            Console.WriteLine("\n\n");
            Console.WriteLine("Asik dapat kenaikan gaji 10% !!");
            Console.WriteLine("\n");
            Console.WriteLine("No. \tNIK/nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karpertama.Nik, karpertama.Nama, karpertama.GajiBulanan + (karpertama.GajiBulanan * 0.10));
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karkedua.Nik, karkedua.Nama, karkedua.GajiBulanan + (karkedua.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }
}
