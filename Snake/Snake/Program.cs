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
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 4;
            p1.sym = '*';
            p1.Draw();
           /* int x1 = 1;
            int y1 = 4;
            char symbol1 = '*';
            //Console.SetCursorPosition(x1, y1);
            //Console.Write(symbol1);*/
           // WriteSymbol(p1.x, p1.y, p1.sym);

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 2;
            p2.sym = '#';
            p2.Draw();
            /*int x2 = 4;
            int y2 = 2;
            char symbol2 = '#';
            //Console.SetCursorPosition(x2, y2);
            //Console.Write(symbol2);*/
           // WriteSymbol(p2.x, p2.y, p2.sym);

            Console.Read();

            
        }

        //static void WriteSymbol(int x, int y, char symbol)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(symbol);
        //}
    }

    
}
