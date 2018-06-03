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
            int x1 = 1;
            int y1 = 4;
            char symbol1 = '*';
            //Console.SetCursorPosition(x1, y1);
            //Console.Write(symbol1);
            WriteSymbol(x1, y1, symbol1);

            int x2 = 4;
            int y2 = 2;
            char symbol2 = '#';
            //Console.SetCursorPosition(x2, y2);
            //Console.Write(symbol2);
            WriteSymbol(x2, y2, symbol2);

            Console.Read();

            
        }

        static void WriteSymbol(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }

    
}
