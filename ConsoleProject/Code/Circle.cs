using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Code
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double _x, double _y, double _radius): base(_x,_y)
        {
            this.Radius = _radius;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
}
