﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(80,25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(2, 3, '*');
            Snake snake = new Snake(p, 4, Direction.DOWN);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Direction.LEFT;
                    else if (key.Key == ConsoleKey.RightArrow)
                        snake.direction = Direction.RIGHT;
                    else if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = Direction.DOWN;
                    else if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = Direction.UP;
                    else
                        break;
                }
                Thread.Sleep(100);
                snake.Move();
            }
            
           Console.ReadLine();
        }
    }
}
