using System;

namespace Triangles
{
    class Triangle
    {
        public readonly Point P1;
        public readonly Point P2;
        public readonly Point P3;

        double len1, len2, len3;

        public Triangle(Point point1, Point point2, Point point3)
        {
            P1 = point1;
            P2 = point2;
            P3 = point3;

            Edge e1 = new Edge(P1, P2);
            Edge e2 = new Edge(P1, P3);
            Edge e3 = new Edge(P2, P3);

            len1 = e1.Length;
            len2 = e2.Length;
            len3 = e3.Length;

            if (len1 >= len2 + len3 || len2 >= len1 + len3 || len3 >= len1 + len2
                || len1 == 0 || len2 == 0 || len3 == 0)
            {
                throw new ArgumentException("Треугольник не существует");
            }
        }

        public double Perimeter
        {
            get
            {
                return len1 + len2 + len3;
            }
        }

        public double Area
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - len1) * (p - len2) * (p - len3));
            }
        }

        public bool IsRight
        {
            get
            {
                return len1 == Math.Sqrt(Math.Pow(len2, 2) + Math.Pow(len3, 2)) ||
                    len2 == Math.Sqrt(Math.Pow(len1, 2) + Math.Pow(len3, 2)) ||
                    len3 == Math.Sqrt(Math.Pow(len1, 2) + Math.Pow(len2, 2));
            }
        }

        public bool isIsosceles
        {
            get
            {
                return len1 == len2 || len1 == len3 || len2 == len3;
            }
        }

        public static bool operator ==(Triangle tr1, Triangle tr2)
        {
            return tr1.P1 == tr2.P1 && tr1.P2 == tr2.P2 && tr1.P3 == tr2.P3;
        }

        public static bool operator !=(Triangle tr1, Triangle tr2)
        {
            return tr1.P1 != tr2.P1 || tr1.P2 != tr2.P2 || tr1.P3 != tr2.P3;
        }
    }
}
