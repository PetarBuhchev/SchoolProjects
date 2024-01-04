using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointProject;
namespace ProjectLine
{
    internal class Center : PointProject.Point
    {
        public Center(double x, double y) : base(x, y)
        {
        }

        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(number);
        }
    }
}
