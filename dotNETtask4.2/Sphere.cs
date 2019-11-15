using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask4._2
{
    class Sphere : Shape, IDrawable
    {
        void IDrawable.Draw()
        {
            Console.WriteLine("Рисуем сферу явно");
        }

        public override void Draw()
        {
            Console.WriteLine("Рисуем сферу неявно");
        }
    }
}
