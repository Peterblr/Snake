using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontLine : Figure
    {
        public HorizontLine(int x_Left, int x_Reight, int y, char sym)
        {
            pList = new List<Point>();

            for(int x = x_Left; x <= x_Reight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
            
        }

    }
}
