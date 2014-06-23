using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Projet_2._0
{
    class Triangle
    {
        public enum Base { up, down }

        public float baseX;
        public float delta1;
        public float delta2;
        public float x1;
        public float x2;
        Vector2 a, b, c;
        Base pointing;

        public Triangle(Vector2 b1, Vector2 b2, Vector2 s, Base pointing)
        {
            baseX = b1.Y;
            delta1 = (s.Y - b1.Y) / (s.X - b1.X);
            delta2 = (b2.Y - s.Y) / (b2.X - s.X);
            x1 = s.Y - s.X * delta1;
            x2 = s.Y - s.X * delta2;
            a = b1;
            b = b2;
            c = s;
            this.pointing = pointing;
        }

        public bool Intersect(int x, int y)
        {
            if (pointing == Base.up)
            {
                if (y < baseX)
                    return false;
                if (delta1 * x + x1 < y)
                    return false;
                if (delta2 * x + x2 < y)
                    return false;
                if (y > c.Y || y < a.Y)
                    return false;
            }
            else
            {
                if (y > baseX)
                    return false;
                if (delta1 * x + x1 > y)
                    return false;
                if (delta2 * x + x2 > y)
                    return false;
                if (y < c.Y || y > a.Y)
                    return false;
            }
            return true;
        }
    }
}
