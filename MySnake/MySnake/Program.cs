using System;
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

            Walls walls = new Walls(80, 25);
            walls.Draw();
            
            // Отрисовка точек
            Point p = new Point(2, 3, '*');
            Snake snake = new Snake(p, 9, Direction.DOWN);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break; // game over
                }
                if (snake.Eat(food))
                {
                    // если змейка съела еду, то сгенерим еще
                    food = foodCreator.CreateFood();
                    food.Draw();
                }

                snake.Move();

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            
           //Console.ReadLine();
        }
    }
}
