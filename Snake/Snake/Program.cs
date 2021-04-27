using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            
            HorizontLine line_Top = new HorizontLine(0, 78, 0, 'o');
            line_Top.Draw();
            HorizontLine line_Bottom = new HorizontLine(0, 78, 24, 'o');
            line_Bottom.Draw();
            VerticalLine line_Left = new VerticalLine(0, 24, 0, 'o');
            line_Left.Draw();
            VerticalLine line_Reight = new VerticalLine(0, 24, 78, 'o');
            line_Reight.Draw();
            Console.ReadKey();

            Point p = new Point(4, 5, '#');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300); 
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);



        }

    }
}
