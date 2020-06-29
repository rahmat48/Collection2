using CollectionInput.classInduk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInput.classAnak
{
    public class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override string Nama { get; set; }
        public override string Nik { get; set; }

        public override double gaji()
        {
            return this.GajiBulanan;
        }
    }
}
