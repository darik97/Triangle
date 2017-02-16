using System;

namespace Triangles
{
    class Poligon
    {
        private int size;
        public readonly Point[] ArrPoint;
        private double[] length;

        public Poligon(Point[] ArrayOfPoints)
        {
            size = ArrayOfPoints.Length;
            ArrPoint = ArrayOfPoints;           

            Edge[] arrEdges = new Edge[size];
            for (int i = 0; i < size - 1; i++)
                arrEdges[i] = new Edge(ArrPoint[i], ArrPoint[i + 1]);
            arrEdges[size - 1] = new Edge(ArrPoint[size - 1], ArrPoint[0]);

            this.length = new double[size];
            for (int i = 0; i < size; i++)
            {
                length[i] = arrEdges[i].Length;
                if (length[i] == 0 || size < 3)
                {
                    throw new ArgumentException("Многоугольник не существует");
                }
            }
            Console.WriteLine(size + "-угольник создан");
        }

        public double Perimeter
        {
            get
            {
                double perimeter = 0;
                for (int i = 0; i < size; i++)
                    perimeter = perimeter + length[i];
                return perimeter;
            }
        }

        public double Area
        {
            get
            {
                double area = 0;
                for (int i = 0; i < size - 1; i++)
                {
                    area += (ArrPoint[i].X * ArrPoint[i + 1].Y - ArrPoint[i].Y * ArrPoint[i + 1].X);
                }
                area += (ArrPoint[size - 1].X * ArrPoint[0].Y - ArrPoint[size - 1].Y * ArrPoint[0].X);
                return Math.Abs(area / 2);
            }
        }
    }
}
