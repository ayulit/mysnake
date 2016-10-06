using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1; // cell one in stack = 1
            func1(x);  // cell two in stack = 1
            Console.WriteLine("Called func1(). x = " + x); // Called func1(). x = 1

            x = 1;    // cell one in stack = 1
            func2(x); // cell two in stack = 2
            Console.WriteLine("Called func2(). x = " + x); // Called func2(). x = 1

            Point p1 = new Point(1, 3, '*'); // cell three in stack = address_1; cell one in heap = 1, cell two in heap = 3, cell three in heap = '*'
            Move(p1, 10, 10); // cell four in stack = address_1, cell five in stack = 10, cell six in stack = 10; cell one in heap = 11, cell two in heap = 13, cell three in heap = '*'
            Console.WriteLine("Called Move(). p1.x = " + p1.x + ", p1.y = " + p1.y); // Called Move(). p1.x = 11, p1.y = 13
            
          //  Console.WriteLine("Called Move(). p1.x = " + p1.x + ", p1.y = " + p1.y + "; p2.x = " + p2.x + ", p2.y = " + p2.y); // Called func2. x = 1

          //  Point p1 = new Point(1,3,'*');
          //  p1.Draw();

          //  Point p2 = new Point(4,5,'#');
          //  p2.Draw();

            Console.ReadLine();
        }

        public static void func1(int value)
        {        
        }

        public static void func2(int value)
        {
            value++;
            Console.WriteLine("Called func1. value = " + value); // Called func2. value = 2
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x += dx;
            p.y += dy;            
        }


    }
}
