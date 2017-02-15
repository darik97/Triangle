using System;

namespace Triangles
{
    class Poligon
    {
        private int vertex;
        public readonly Point[] arrPoint;
        private double[] length;

        public Poligon(int QuantityEdge, Point[] ArrayOfPoints)
        {
            vertex = QuantityEdge;
            arrPoint = ArrayOfPoints;           

            Edge[] arrEdges = new Edge[vertex];
            for (int i = 0; i < vertex - 1; i++)
                arrEdges[i] = new Edge(arrPoint[i], arrPoint[i + 1]);
            arrEdges[vertex - 1] = new Edge(arrPoint[vertex - 1], arrPoint[0]);

            this.length = new double[vertex];
            for (int i = 0; i < vertex; i++)
            {
                length[i] = arrEdges[i].Length;
                if (length[i] == 0 || vertex < 3)
                {
                    throw new ArgumentException("Многоугольник не существует");
                }
            }
            Console.WriteLine(vertex + "-угольник создан");
        }

        public double Perimeter
        {
            get
            {
                double perimeter = 0;
                for (int i = 0; i < vertex; i++)
                    perimeter = perimeter + length[i];
                return perimeter;
            }
        }

        public double Area
        {
            get
            {
                double area = 0;
                for (int i = 0; i < vertex - 1; i++)
                {
                    area += (arrPoint[i].x * arrPoint[i + 1].y - arrPoint[i].y * arrPoint[i + 1].x);
                }
                area += (arrPoint[vertex - 1].x * arrPoint[0].y - arrPoint[vertex - 1].y * arrPoint[0].x);
                return Math.Abs(area / 2);
            }
        }
    }
}
