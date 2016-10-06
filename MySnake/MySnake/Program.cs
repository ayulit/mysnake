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
            Console.WriteLine("Called func1. x = " + x); // Called func1. x = 1

          //  Point p1 = new Point(1,3,'*');
          //  p1.Draw();

          //  Point p2 = new Point(4,5,'#');
          //  p2.Draw();

            Console.ReadLine();
        }

        public static void func1(int value)
        { 
        
        }
    }
}
