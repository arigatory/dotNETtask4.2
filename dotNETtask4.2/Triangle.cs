using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask4._2
{
    class Triangle : Shape, IPoint
    {
        public int Point => throw new NotImplementedException();

        public override void Draw()
        {
            Console.WriteLine("Рисуем треугольник");
        }
    }
}
