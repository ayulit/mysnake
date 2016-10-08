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

        public HorizontalLine()
        {

            pList = new List<Point>(); // в конструкторе создаем объект списка точек
            
            // и создаем немного точек
            Point p1 = new Point( 4, 4, '*' );
            Point p2 = new Point( 5, 4, '*');
            Point p3 = new Point( 6, 4, '*');

            // и добавляем все эти 3 точки в список
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
        }

        // Метод для вывода линии на экран


    }
}
