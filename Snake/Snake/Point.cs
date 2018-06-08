using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int new_x, int new_y, char new_sym)
        {
            x = new_x;
            y = new_y;
            sym = new_sym;
        }

        public Point(Point sample) 
        {
            x = sample.x;
            y = sample.y;
            sym = sample.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Move(int distance, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + distance;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - distance;
            }
            else if (direction == Direction.UP)
            {
                y = y - distance;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + distance;
            }
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()//Это чтоб удобно было смотреть в отладчике
        {
            return "X:" + x + ", Y:" + y + ", " + sym;
        }
    }
}
