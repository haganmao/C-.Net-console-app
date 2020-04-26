using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Circle
    {
        public String name;
        public double radius = 0.0;

        public double Area() {
            return 3.141592 * radius * radius;
        }

        public Circle(double r)
        {
            radius = r;
        }

        public Circle(String n, double r) {
            name = n;
            radius = r;
            
        }

        public String Name () {
            return name;
        }

        public double Radius() {
            return radius;
        }

        public bool is_Greater_Than(Circle other) {
            if (this.Radius() > other.Radius()) {
                return true;
            }

            else {
                return false;
            }
        }


    }
}
