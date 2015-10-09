using System;

namespace Snake
{
    class SnakeMain
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line1 = new HorizontalLine(5, 10, 8, '+');
            line1.LineDraw();

            VerticalLine line2 = new VerticalLine(3, 11, 2, '+');
            line2.LineDraw();

            Console.ReadLine();
        }
    }
}
