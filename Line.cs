using System;
using System.Collections.Generic;
//using System.Drawing;

//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointProject;
namespace ProjectLine
{
    internal class Line
    {
        internal Center a;
        internal Center b;

        public Line(Center a, Center b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
