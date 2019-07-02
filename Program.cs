using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asosiasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kartu kartu = new Kartu();

            Karyawan karyawan = new Karyawan();
            karyawan.nama = "paijo";
            karyawan.status = true;

            if (karyawan.login(kartu)) {
                Console.WriteLine("mashoook pak eko");
            }
            else {
                Console.WriteLine("pakceklik");
            }
            Console.ReadKey();
        }
    
    }
}
