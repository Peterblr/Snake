﻿using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Drow();

            Point p2 = new Point(4, 7, '#');
            p2.Drow();

        }

    }
}
