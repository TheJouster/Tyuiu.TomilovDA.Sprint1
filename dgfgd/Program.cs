using System.Runtime.InteropServices;

namespace dgfgd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;

            int b = --a + 2;

            int c = b;

            a = a + b + c;

            c = b++ + a;

            b = b - a;

            int x = a + b + c;
            Console.WriteLine(x);

        }
    }
}
