using System;

namespace pz_21_2nk2_bezborodykn

{

    class Program
    {

        static void Main(string[] args)
        {
            Patient pat = new Patient();
            Console.WriteLine("������� ���");
            pat.name = Console.ReadLine();
            Console.WriteLine("������� �������");
            pat.fam = Console.ReadLine();
            Console.WriteLine("������� ��������");
            pat.otch = Console.ReadLine();
            Console.WriteLine("������� ���� �������� ");
            pat.dataBirth = Console.ReadLine();
            Console.WriteLine("������� ���� ����������� ");
            pat.receiptDate = Console.ReadLine();
            Console.WriteLine("������� ������� ");
            pat.diagnos = Console.ReadLine();
            pat.GetPatientInfo();

        }
    }
}