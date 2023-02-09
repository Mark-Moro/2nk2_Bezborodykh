using System;
using System.Collections.Generic;
using System.Text;

namespace pz_21_2nk2_bezborodykn
{
    class Patient
    {
        public string name { get; set; }
        public string fam { get; set; }
        public string otch { get; set; }
        public string dataBirth { get; set; }
        public string receiptDate { get; set; }
        public string diagnos { get; set; }
        public void GetPatientInfo()
        {
            Console.WriteLine($"{name}({fam}){otch}{dataBirth}{receiptDate}{diagnos}");
        }

    }
}

