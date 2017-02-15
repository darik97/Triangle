using System;

namespace Triangles
{
    class Edge
    {
        public readonly Point p1;
        public readonly Point p2;

        public Edge(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2));
            }
        }
    }
}
