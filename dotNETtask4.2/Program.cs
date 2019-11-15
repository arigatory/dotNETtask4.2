using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[4]
            {
                new Circle(), new Hexagon(), new Sphere(), new Triangle()
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                AnalyzeShape(shapes[i]);
            }

            Console.ReadLine();
        }

        public static void AnalyzeShape(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("***** Начало анализа: *****");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            if (shape is IPoint)
                Console.WriteLine("Фигура содержит точек: {0}",((IPoint)shape).Point);
            else
            {
                Console.WriteLine("Фигура не содержит точек");
            }
            shape.Draw();
            if (shape is IDrawable)
                ((IDrawable) shape).Draw();
            Console.WriteLine("_____ Конец анализа _____\n");
            }
    }
}
