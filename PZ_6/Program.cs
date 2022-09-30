namespace PZ_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            int a = 0;
            int b = 1;
            int nextMember;
            int i = 0;

            do
            {
                nextMember = a + b;
                a = b;
                b = nextMember;
                i++;
            }
            while (i < n - 1);
            Console.WriteLine(nextMember);
        }
    }
}