using System;

namespace BOOP_01_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            float f = 1.50F;

            i *= 3;
            f /= 3;
            Console.WriteLine(i); // 15
            Console.WriteLine(f); // 0.5

            i += 10;
            f -= 1.0F;
            Console.WriteLine(i); // 25
            Console.WriteLine(f); // -0.5

            int k = default;

            i = ++k;
            Console.WriteLine(i); // 1
            Console.WriteLine(k); // 1

            i = k++;
            Console.WriteLine(i); // 1
            Console.WriteLine(k); // 2
        }
    }
}
