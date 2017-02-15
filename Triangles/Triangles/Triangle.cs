using System;

namespace Triangles
{
    class Triangle
    {
        private Point p1;
        private Point p2;
        private Point p3;

        double len1, len2, len3;

        public Triangle(Point point1, Point point2, Point point3)
        {
            p1 = point1;
            p2 = point2;
            p3 = point3;

            Edge e1 = new Edge(p1, p2);
            Edge e2 = new Edge(p1, p3);
            Edge e3 = new Edge(p2, p3);

            len1 = e1.Length;
            len2 = e2.Length;
            len3 = e3.Length;

            if (len1 >= len2 + len3 || len2 >= len1 + len3 || len3 >= len1 + len2
                || len1 == 0 || len2 == 0 || len3 == 0)
            {
                throw new ArgumentException("Треугольник не существует");
            }
        }

        public double PerimeterTriangle
        {
            get
            {
                return len1 + len2 + len3;
            }
        }

        public double AreaTriangle
        {
            get
            {
                double p = PerimeterTriangle / 2;
                return Math.Sqrt(p * (p - len1) * (p - len2) * (p - len3));
            }
        }

        public bool RightTriangle
        {
            get
            {
                return len1 == Math.Sqrt(Math.Pow(len2, 2) + Math.Pow(len3, 2)) ||
                    len2 == Math.Sqrt(Math.Pow(len1, 2) + Math.Pow(len3, 2)) ||
                    len3 == Math.Sqrt(Math.Pow(len1, 2) + Math.Pow(len2, 2));
            }
        }

        public bool IsoscelesTriangle
        {
            get
            {
                return len1 == len2 || len1 == len3 || len2 == len3;
            }
        }
    }
}
