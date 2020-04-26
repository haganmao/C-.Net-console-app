using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Example
{
    class Circle : Shape
    {
        double radius;

        public Circle(double radius_, String name_) : base(name_)
        {
            this.radius = radius_;
        }

        public double Radius
        {
            get { return radius; }
        }
        public override String ToString()
        {
            return "I am a Circle of radius " + radius +
                    " by the name of " + name;
        }

    }
}
