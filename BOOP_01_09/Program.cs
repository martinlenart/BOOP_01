using System;

namespace BOOP_01_09
{
    class Program
    {
        public struct Point
        {
            public int X, Y;        // data members
            public void WriteLine() // function member
            {
                Console.WriteLine(X + ", " + Y);
            }
        }
        public struct Rectangle
        {
            public bool Visible; 
            public Point TopLeft, BottomRight;
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle { Visible = true, 
                BottomRight = new Point { X = 0, Y = 0 }, TopLeft = new Point { X = 100, Y = 100 } };
            
            Console.WriteLine(rect.Visible);    // True
            rect.BottomRight.WriteLine();       // 0, 0
            rect.TopLeft.WriteLine();           // 100, 100
        }
    }
}
