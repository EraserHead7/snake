using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {          

            //Point p1 = new Point(1, 3, '*');
            //p1.Drow();

            //HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            //line.Drow();

            //VerticalLine lineV = new VerticalLine(7, 12, 10, '$');
            //lineV.Drow();


            Point p = new Point(4, 5, '~');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }      
    }
}
