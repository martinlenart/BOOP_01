using System;

namespace BOOP_01_14
{
    class Program
    {
        public struct Point
        {
            public int X, Y;                       // instance data members
            private static int s_nrWriteLines = 0; // private static datamember

            public void WriteLine()                // instance function member
            {
                s_nrWriteLines = s_nrWriteLines + 1;
                Console.WriteLine(X + ", " + Y);
            }
            public static void NrWriteLines()       // static function member
            {
                Console.WriteLine(s_nrWriteLines);
            }
        }

        static void Main(string[] args)
        {
            var point1 = new Point { X = 0, Y = 0 };
            var point2 = new Point { X = 100, Y = 100 };

            point1.WriteLine();
            point2.WriteLine();

            //Console.WriteLine(Point.s_nrWriteLines);  // Error - Cannot be accessed 
            Point.NrWriteLines();
        }
    }
}
