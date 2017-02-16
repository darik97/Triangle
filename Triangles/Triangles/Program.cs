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

            Console.WriteLine("Perimeter of triangle: " + trianle.Perimeter);
            Console.WriteLine("Area of triangle: " + trianle.Area);

            if (trianle.isRight)
                Console.WriteLine("Triangle is right");
            if (trianle.isIsosceles)
                Console.WriteLine("Triangle is isosceles");

            Console.WriteLine("Введите количество треугольников в массиве: ");
            int count = Convert.ToInt32(Console.ReadLine());
            TriangleArray(count);

            Console.WriteLine("Введите количество углов в многоугольнике: ");
            int vertex = Convert.ToInt32(Console.ReadLine());
            Point[] arrPoint = MakePoligon(vertex);
            Poligon poligon = new Poligon(vertex, arrPoint);
            PrintPoligon(arrPoint, vertex);
            Console.WriteLine(poligon.Perimeter);
            Console.WriteLine(poligon.Area);
        }

        private static void TriangleArray(int count)
        {
            Triangle[] arrTriangle = new Triangle[count];
            double perimeterAll = 0, areaAll = 0;
            int quantityRight = 0, quantityIsosceles = 0;
            for (int i = 0; i < count; i++)
            {
                Random Gen = new Random();

                Point p1 = new Point(Gen.Next(-10, 10), Gen.Next(-10, 10));
                Point p2 = new Point(Gen.Next(-10, 10), Gen.Next(-10, 10));
                Point p3 = new Point(Gen.Next(-10, 10), Gen.Next(-10, 10));

                arrTriangle[i] = new Triangle(p1, p2, p3);

                if (arrTriangle[i].isRight)
                {
                    perimeterAll = perimeterAll + arrTriangle[i].Perimeter;
                    quantityRight++;
                }
                if (arrTriangle[i].isIsosceles)
                {
                    areaAll = areaAll + arrTriangle[i].Area;
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

        private static Point[] MakePoligon(int numberOfVertices)
        {
            Point[] arrPoint = new Point[numberOfVertices];
            //Random Gen = new Random();
            //for (int i = 0; i < numberOfVertices; i++)
            //    arrPoint[i] = new Point(Gen.Next(0, 5), Gen.Next(0, 5));

            for (int i = 0; i < numberOfVertices; i++)
            {
                int j = i + 1;
                Console.WriteLine("Введите координаты " + j + "-ой точки: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                arrPoint[i] = new Point(x, y);
            }
            return arrPoint;
        } 

        private static void PrintPoligon(Point[] arrPoint, int vertix)
        {
            for (int i = 0; i < vertix; i++)
            {
                Console.WriteLine(i + " point: (" + arrPoint[i].x + ", " + arrPoint[i].y + ")");
            }
        }
    }
}
