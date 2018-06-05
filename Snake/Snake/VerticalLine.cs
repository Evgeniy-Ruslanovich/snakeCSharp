using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        //Конструктор
        public VerticalLine(int x, int yTop, int yDown, char sym)
        {
            pList = new List<Point>();
            if (yTop > yDown)
            {
                yDown = yTop;//Защита от бесконечного цикла, если нам правый зададут меньше, чем левый
            }
            for (int y = yTop; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
