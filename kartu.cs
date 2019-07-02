using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asosiasi
{
    public class Kartu
    {
        public bool IsValid(Karyawan karyawan) {
            return karyawan.status == true;
        }

    }
}
