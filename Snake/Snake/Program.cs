using System;
using System.Collections.Generic;

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

            List<int> nuList = new List<int>();
            nuList.Add(0);
            nuList.Add(1);
            nuList.Add(2);

            int x = nuList[0];
            int y = nuList[1];
            int z = nuList[2];

            foreach(int i in nuList)
            {
                Console.WriteLine(i);
            }

            nuList.RemoveAt(0);
            List < Point > pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);


        }

    }
}
