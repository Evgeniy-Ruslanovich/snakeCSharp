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
            p3.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
            Console.WriteLine(numList[1]);

            foreach (int i in numList)
            {
                Console.WriteLine(numList[i]);
            }
            numList.RemoveAt(0);

            List < Point > pList= new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

            Console.Read();

            
        }
    } 
}
