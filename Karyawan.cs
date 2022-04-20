using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4406
{
    public class Karyawan
    {
        //properties
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        //Method
        public void DaftarGaji(int no)
        {
            //apabila gaji kurang dari nol maka secara otomatik akan di set menjadi nol
            if(GajiBulanan <= 0)
            {
                GajiBulanan = 0;
            }
            Console.WriteLine("{0}. {1} {2}                 {3}", no, Nik, Nama, GajiBulanan);
        }

        public void DaftarGajiNew(int no)
        {
            //apabila gaji kurang dari nol maka secara otomatik akan di set menjadi nol
            if (GajiBulanan <= 0)
            {
                GajiBulanan = 0;
            }
            int GajiBulananNew = GajiBulanan + (GajiBulanan*10)/100;
            Console.WriteLine("{0}. {1} {2}                 {3}", no, Nik, Nama, GajiBulananNew);
        }
    }
}
