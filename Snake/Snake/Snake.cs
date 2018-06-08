using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;//с подчеркиванием - это чтоб не путать с свойством класса
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, _direction);
                pList.Add(p);
            }
        }

        internal void Step()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = getHead();
            pList.Add(head);
            tail.Clear();
            head.Draw();
        }

        public Point getHead()
        {
            Point head = new Point(pList.Last());
            head.Move(1, direction);
            return head;
        }
    }
}
