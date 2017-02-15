using System;

namespace Triangles
{
    class Poligon
    {
        private int angle;
        private Point[] arrPoint;
        private double[] length;
        private Edge[] arrEdges;

        public Poligon(int QuantityEdge)
        {
            angle = QuantityEdge;

            Random Gen = new Random();
            this.arrPoint = new Point[angle];
            for (int i = 0; i < angle; i++)
                arrPoint[i] = new Point(Gen.Next(0, 5), Gen.Next(0, 5));

            this.arrEdges = new Edge[angle];
            for (int i = 0; i < angle - 1; i++)
                arrEdges[i] = new Edge(arrPoint[i], arrPoint[i + 1]);
            arrEdges[angle - 1] = new Edge(arrPoint[angle - 1], arrPoint[0]);

            this.length = new double[angle];
            for (int i = 0; i < angle; i++)
            {
                length[i] = arrEdges[i].Length;
                if (length[i] == 0 || angle < 3)
                {
                    throw new ArgumentException("Многоугольник не существует");
                }
            }
            Console.WriteLine(angle + "-угольник создан");
        }

        public double PerimeterPoligon
        {
            get
            {
                double perimeter = 0;
                for (int i = 0; i < angle; i++)
                    perimeter = perimeter + length[i];
                return perimeter;
            }
        }

        public double AreaPoligon
        {
            get
            {
                double area = 0;
                for (int i = 0; i < angle - 1; i++)
                {
                    area = area + (arrPoint[i].x + arrPoint[i + 1].x) * (arrPoint[i].y + arrPoint[i + 1].y);
                }
                return Math.Abs(area / 2);
            }
        }
    }
}
