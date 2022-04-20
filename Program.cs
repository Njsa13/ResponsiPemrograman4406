using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4406
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor
            Karyawan karyawan1 = new Karyawan();
            Karyawan karyawan2 = new Karyawan();

            //properties
            karyawan1.Nik = "123456789";
            karyawan1.Nama = "Najib";
            karyawan1.GajiBulanan = 2000000;

            karyawan2.Nik = "987654321";
            karyawan2.Nama = "Sauqi";
            karyawan2.GajiBulanan = 3000000;

            //method
            Console.WriteLine("No Nik/Nama                  Gaji Bulanan");
            Console.WriteLine("-----------------------------------------");
            karyawan1.DaftarGaji(1);
            karyawan2.DaftarGaji(2);
            Console.WriteLine();

            //kenaikan gaji
            Console.WriteLine("Asiiik kenaikan gaji 10% !!!!!");
            Console.WriteLine();
            Console.WriteLine("No Nik/Nama                  Gaji Bulanan");
            Console.WriteLine("-----------------------------------------");
            karyawan1.DaftarGajiNew(1);
            karyawan2.DaftarGajiNew(2);

            Console.ReadKey();
        }
    }
}
