using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            
            HorizontLine line_Top = new HorizontLine(0, 78, 0, 'o');
            line_Top.Drow();
            HorizontLine line_Bottom = new HorizontLine(0, 78, 24, 'o');
            line_Bottom.Drow();
            VerticalLine line_Left = new VerticalLine(0, 24, 0, 'o');
            line_Left.Drow();
            VerticalLine line_Reight = new VerticalLine(0, 24, 78, 'o');
            line_Reight.Drow();
            Console.ReadKey();

        }

    }
}
