using System.Globalization;

namespace PZ_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char simvol = 'f';
            for (int i = 20; i <= 100; i += 4)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine(simvol);
                simvol++;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= 5; j++) 
                {
                    Console.WriteLine(j);
                }
            }
            for (int i = 0; i < 100; i++)
            {
                if (i % 11==0)
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 0; j = 40; j - i>= 19; i++, j--)
            {
                Console.WriteLine(i);
                Console.WriteLine(j);
            }
            }
        }
    }
