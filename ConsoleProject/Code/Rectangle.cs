using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Code
{
    public  class Rectangle: Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double _x, double _y, double _length, double _width): base(_x,_y)
        {
            Length = _length;
            Width = _width;
        }


        public override double area()
        {
            return this.Length * this.Width;
        }
    }
}
