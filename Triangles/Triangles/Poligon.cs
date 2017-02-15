using System;

namespace Triangles
{
    class Poligon
    {
        private int angle;
        private Point[] arrPoint;

        public Poligon(int QuantityEdge)
        {
            angle = QuantityEdge;

            Random Gen = new Random();
            arrPoint = new Point[angle];
            for (int i = 0; i < angle; i++)
                arrPoint[i] = new Point(Gen.Next(0, 5), Gen.Next(0, 5));

            Edge[] arrEdges = new Edge[angle];
            for (int i = 0; i < angle - 1; i++)
                arrEdges[i] = new Edge(arrPoint[i], arrPoint[i + 1]);
            arrEdges[angle - 1] = new Edge(arrPoint[angle - 1], arrPoint[0]);

            double[] length = new double[angle];
            for (int i = 0; i < angle; i++)
            {
                length[i] = arrEdges[i].Length;
                if (length[i] == 0 || angle < 3)
                {
                    Console.WriteLine("Многоугольник не существует");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine(angle + "-угольник создан");
        }

        /*public double PerimeterPoligon
        {
            get
            {
                double perimeter = 0;
                for (int i = 0; i < quantity; i++)
                    perimeter = perimeter + length[i];
                return perimeter;
            }
        }*/
    }
}
