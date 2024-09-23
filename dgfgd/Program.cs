using System.Runtime.InteropServices;

namespace dgfgd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;

            int b = a - 5;

            a -= 2 * --b;

            b *= a++;

            int x = a + b;

            Console.WriteLine(x);

        }
    }
}
