using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointProject
{
    public class Point
    {
        Random r = new Random();
        public double x;
        public double y;
        protected internal int number;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            this.number = r.Next(1, 101);
        }
    }
}

