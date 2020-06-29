using CollectionInput.classInduk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInput.classAnak
{
    public class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override string Nama { get; set; }
        public override string Nik { get; set; }

        public override double gaji()
        {
            return Komisi * JumlahPenjualan;
        }
    }
}
