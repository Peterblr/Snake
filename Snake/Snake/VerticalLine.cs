using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
            public VerticalLine(int y_Top, int y_Bottom, int x, char sym)
            {
                pList = new List<Point>();

                for (int y = y_Top; y <= y_Bottom; y++)
                {
                    Point p = new Point(x, y, sym);
                    pList.Add(p);
                }
            }
    }
}
