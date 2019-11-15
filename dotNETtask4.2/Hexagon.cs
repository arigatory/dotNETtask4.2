using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask4._2
{
    class Hexagon : Shape, IPoint
    {
        public int Point
        {
            get { return 6; }
        }

        public override void Draw()
        {
            Console.WriteLine("Рисуем шестиугольник");
        }
    }
}
