using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asosiasi
{
    public class Karyawan
    {
        public string nama;
        public bool status;
        
        public bool login(Kartu kartu)
        {
            return kartu.IsValid(this);
        }
    }

}
