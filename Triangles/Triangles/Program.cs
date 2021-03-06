﻿using System;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(0, 4);
            Point point2 = new Point(4, 0);
            Point point3 = new Point(0, 0);

            Triangle triangle = new Triangle(point1, point2, point3);

            Console.WriteLine("Периметр треугольника: " + triangle.Perimeter);
            Console.WriteLine("Площадь треугольника: " + triangle.Area);

            if (triangle.IsRight)
                Console.WriteLine("Треугольник прямоугольный");
            if (triangle.IsIsosceles)
                Console.WriteLine("Треугольник равнобедренный");

            Console.WriteLine("Введите количество треугольников в массиве: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            TriangleArray(amount);

            Console.WriteLine("Введите количество углов в многоугольнике: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Point[] arrPoint = MakeArrayOfPoints(size);
            Polygon poligon = new Polygon(arrPoint);
            PrintPoligon(arrPoint);
            Console.WriteLine(poligon.Perimeter);
            Console.WriteLine(poligon.Area);
        }

        private static void TriangleArray(int amount)
        {
            Triangle[] arrTriangle = new Triangle[amount];
            double perimeterAll = 0, areaAll = 0;
            int quantityRight = 0, quantityIsosceles = 0;
            for (int i = 0; i < amount; i++)
            {
                Random Gen = new Random();

                Point p1 = new Point(Gen.Next(0, 5), Gen.Next(0, 5));
                Point p2 = new Point(Gen.Next(0, 5), Gen.Next(0, 5));
                Point p3 = new Point(Gen.Next(0, 5), Gen.Next(0, 5));

                //Point p1 = new Point(0, 5);
                //Point p2 = new Point(5, 5);
                //Point p3 = new Point(0, 0);

                arrTriangle[i] = new Triangle(p1, p2, p3);

                if (arrTriangle[i].IsRight)
                {
                    perimeterAll = perimeterAll + arrTriangle[i].Perimeter;
                    quantityRight++;
                }
                if (arrTriangle[i].IsIsosceles)
                {
                    areaAll = areaAll + arrTriangle[i].Area;
                    quantityIsosceles++;
                }
            }

            if (quantityRight != 0)
                Console.WriteLine("Средний периметр прямоугольных треугольников " + perimeterAll / quantityRight);
            else
                Console.WriteLine("Средний периметр прямоугольных треугольников " + 0);
            if (quantityIsosceles != 0)
                Console.WriteLine("Средний периметр равнобедренных треугольников " + areaAll / quantityIsosceles);
            else
                Console.WriteLine("Средний периметр равнобедренных треугольников " + 0);

            //if (arrTriangle[0] == arrTriangle[1])
            //{
            //    Console.WriteLine("Треугольники равны");
            //}
            //else
            //{
            //    Console.WriteLine("Треугольники не равны");
            //}
        }

        private static Point[] MakeArrayOfPoints(int size)
        {
            Point[] arrPoint = new Point[size];

            for (int i = 0; i < size; i++)
            {
                int j = i + 1;
                Console.WriteLine("Введите координаты " + j + "-ой точки: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                arrPoint[i] = new Point(x, y);
            }
            return arrPoint;
        } 

        private static void PrintPoligon(Point[] arrPoint)
        {
            int size = arrPoint.Length;
            for (int i = 0; i < size; i++)
            {
                int j = i + 1;
                Console.WriteLine(j + "-я точка: (" + arrPoint[i].X + ", " + arrPoint[i].Y + ")");
            }
        }
    }
}
