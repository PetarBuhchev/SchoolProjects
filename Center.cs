using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointProject
{
    public class Center : Point
    {
        public Center(double x, double y) : base(0, 0)
        {
        }

        public void Print()
        {
            Console.WriteLine(this.x);
            Console.WriteLine(this.y);
            Console.WriteLine(this.number);
        }
    }
}
