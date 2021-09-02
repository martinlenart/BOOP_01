﻿using System;

namespace BOOP_01_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Real types examples
            float floatVar1 = 1234567.891F;    // will become 1234567.9 due to digits of precision 
            float floatVar2 = 1.234567891F;    // will become 1.2345679 

            Console.WriteLine("type float");
            Console.WriteLine(sizeof(float));  // 4  
            Console.WriteLine(float.MaxValue); // 3.4028235E+38
            Console.WriteLine(float.MinValue); // -3.4028235E+38
            Console.WriteLine(floatVar1);      // 1234567.9
            Console.WriteLine(floatVar2);      // 1.2345679

            double doubleVar1 = 1234567.891234567891234567D; // will become 1234567,8912345679
            double doubleVar2 = 1.234567891234567891234567D; // will become 1,234567891234568

            Console.WriteLine();
            Console.WriteLine("type double");
            Console.WriteLine(sizeof(double));  // 8  
            Console.WriteLine(double.MaxValue); // 1,7976931348623157E+308
            Console.WriteLine(double.MinValue); // -1,7976931348623157E+308
            Console.WriteLine(doubleVar1);      // 1234567,8912345679
            Console.WriteLine(doubleVar2);      // 1,234567891234568

            decimal decimalVar1 = 1234567.891234567891234567M; // will not change due to 28-29 d.o.p.
            decimal decimalVar2 = 1.234567891234567891234567M; // will not change

            Console.WriteLine();
            Console.WriteLine("type decimal");
            Console.WriteLine(sizeof(decimal));  // 16  
            Console.WriteLine(decimal.MaxValue); // 7,9228162514264337593543950335E+28
            Console.WriteLine(decimal.MinValue); // -7,9228162514264337593543950335E+28
            Console.WriteLine(decimalVar1);      // 1234567,891234567891234567
            Console.WriteLine(decimalVar2);      // 1,234567891234567891234567
        }
    }
}
