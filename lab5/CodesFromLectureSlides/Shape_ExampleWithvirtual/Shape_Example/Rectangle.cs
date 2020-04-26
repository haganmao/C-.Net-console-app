using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Example 
{
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length_, double width_, String name_) : base(name_)
        {
            length = length_;
            width = width_;
        }
        public double Length
        {
            get { return length; }
        }

        public double Width
        {
            get { return width; }
        }

        public override double Area()
        {
            return length * width;
        } 


        public override String ToString()
        {
            return "I am a " +
                length + " by " + width +
                " rectangle by the name of " + name;
        }

    }
}
