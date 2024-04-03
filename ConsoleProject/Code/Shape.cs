using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Code
{
    public abstract  class Shape
    {
        public double x { get; set; }
        public double y { get; set; }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double area();
    }
}
