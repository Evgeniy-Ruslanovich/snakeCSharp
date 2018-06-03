using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 4, '*');
            p1.Draw();

            Point p2 = new Point(4, 2, '#');
            p2.Draw();

            Point p3 = new Point(1,1,'a');
            p1 = p3;
            p1.Draw();

            Increment_point(p3);
            p1.Draw();

            Console.Read();

            
        }

        static void Increment_point(Point p)
        {
            p.x++;
            p.y++;
        }
    } 
}
