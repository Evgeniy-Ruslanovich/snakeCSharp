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

            Point p2 = new Point(4, 2, '#');

            Point p3 = new Point(1,1,'a');

            List < Point > pList= new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            foreach (Point point in pList)
            {
                point.Draw();
            }

            HorizontalLine hl1 = new HorizontalLine(5,9,5,'*');
            hl1.Draw();

            VerticalLine vl1 = new VerticalLine(8, 2, 10, '+');
            vl1.Draw();

            Console.Read();

            
        }
    } 
}
