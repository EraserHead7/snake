﻿using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {          

            Point p1 = new Point(1, 3, '*');
            p1.Drow();

            Point p2 = new Point(4, 5, '#');
            p2.Drow();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();

            Console.ReadLine();
        }      
    }
}
