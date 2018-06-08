using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(1, 4, '*');

            //Point p2 = new Point(4, 2, '#');

            //Point p3 = new Point(1,1,'a');

            //List < Point > pList= new List<Point>();
            //pList.Add(p1);
            //pList.Add(p2);
            //pList.Add(p3);
            //foreach (Point point in pList)
            //{
            //    point.Draw();
            //}
            int fieldWidth = Console.WindowWidth - 1;
            int fieldHeight = Console.WindowHeight - 2;
            HorizontalLine ceil = new HorizontalLine(0, fieldWidth, 0,'+');
            ceil.Draw();
            VerticalLine leftWall = new VerticalLine(0, 0, fieldHeight, '+');
            leftWall.Draw();
            HorizontalLine floor = new HorizontalLine(0, fieldWidth, fieldHeight, '+');
            floor.Draw();
            VerticalLine rightWall = new VerticalLine(fieldWidth, 0, fieldHeight, '+');
            rightWall.Draw();

            Point tail = new Point(1, 10, '*');

            Snake snake = new Snake(tail, 4, Direction.RIGHT);
            snake.Draw();
            snake.Step();
            Thread.Sleep(300);
            snake.Step();
            Thread.Sleep(300);
            snake.Step();
            Thread.Sleep(300);
            Console.Read();

            
        }
    } 
}
