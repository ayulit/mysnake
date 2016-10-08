using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class HorizontalLine
    {
        List<Point> pList; // атрибутом будет список точек - определим его.

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        // Метод для вывода линии на экран
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }


    }
}
