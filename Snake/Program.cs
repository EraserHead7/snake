using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(200, 100);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine dwLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            dwLine.Drow();
            leftLine.Drow();
            rightLine.Drow();


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(77, 23, '$');
            Point food = foodCreator.CreateFood();
            food.Drow();

            while (true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Drow();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandLeKey(key.Key);
                }


            }
           
            //while (true)
            //{
            //    if(Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo key = Console.ReadKey();
            //        snake.HandLeKey(key.Key);
            //    }
            //    Thread.Sleep(80);
            //    snake.Move();
            //}

        }      
    }
}
