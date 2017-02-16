using System;

namespace Triangles
{
    class Edge
    {
        public readonly Point P1;
        public readonly Point P2;

        public Edge(Point p1, Point p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow((P2.X - P1.X), 2) + Math.Pow((P2.Y - P1.Y), 2));
            }
        }

        public static bool operator ==(Edge e1, Edge e2)
        {
            return e1.P1 == e2.P1 && e1.P2 == e2.P2;
        }

        public static bool operator !=(Edge e1, Edge e2)
        {
            return e1.P1 != e2.P1 || e1.P2 != e2.P2;
        }
    }
}
