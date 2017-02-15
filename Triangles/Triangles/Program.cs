using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(0, 4);
            Point point2 = new Point(4, 0);
            Point point3 = new Point(0, 0);

            Triangle trianle = new Triangle(point1, point2, point3);

            Console.WriteLine("Perimeter of triangle: " + trianle.PerimeterTriangle);
            Console.WriteLine("Area of triangle: " + trianle.AreaTriangle);

            if (trianle.RightTriangle)
                Console.WriteLine("Triangle is right");
            if (trianle.IsoscelesTriangle)
                Console.WriteLine("Triangle is isosceles");

            Console.WriteLine("Введите количество треугольников в массиве: ");
            int count = Convert.ToInt32(Console.ReadLine());
            TriangleArray(count);

            Console.WriteLine("Введите количество углов в многоугольнике: ");
            int angle = Convert.ToInt32(Console.ReadLine());
            Poligon poligon = new Poligon(angle);
        }

        private static void TriangleArray(int count)
        {
            Triangle[] arrTriangle = new Triangle[count];
            double perimeterAll = 0;
            double areaAll = 0;
            int quantityRight = 0;
            int quantityIsosceles = 0;
            for (int i = 0; i < count; i++)
            {
                Random Gen = new Random();

                Point p1 = new Point(Gen.Next(0, 5), Gen.Next(0, 5));
                Point p2 = new Point(Gen.Next(0, 5), Gen.Next(0, 5));
                Point p3 = new Point(Gen.Next(0, 5), Gen.Next(0, 5));

                arrTriangle[i] = new Triangle(p1, p2, p3);

                if (arrTriangle[i].RightTriangle)
                {
                    perimeterAll = perimeterAll + arrTriangle[i].PerimeterTriangle;
                    quantityRight++;
                }
                if (arrTriangle[i].IsoscelesTriangle)
                {
                    areaAll = areaAll + arrTriangle[i].AreaTriangle;
                    quantityIsosceles++;
                }
            }

            if (quantityRight != 0)
                Console.WriteLine("Average perimeter " + perimeterAll / quantityRight);
            else
                Console.WriteLine("Average perimeter " + 0);
            if (quantityIsosceles != 0)
                Console.WriteLine("Average area " + areaAll / quantityIsosceles);
            else
                Console.WriteLine("Average area " + 0);
        }
    }
}
