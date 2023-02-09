using System;

namespace pz_21_2nk2_bezborodykn

{

    class Program
    {

        static void Main(string[] args)
        {
            Patient pat = new Patient();
            Console.WriteLine("Введите имя");
            pat.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            pat.fam = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            pat.otch = Console.ReadLine();
            Console.WriteLine("Введите Дату рождения ");
            pat.dataBirth = Console.ReadLine();
            Console.WriteLine("Введите Дату поступления ");
            pat.receiptDate = Console.ReadLine();
            Console.WriteLine("Введите диагноз ");
            pat.diagnos = Console.ReadLine();
            pat.GetPatientInfo();

        }
    }
}