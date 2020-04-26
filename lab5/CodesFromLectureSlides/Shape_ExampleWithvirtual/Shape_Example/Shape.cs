using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Example
{
    class Shape
    {
        protected String name;

        public String Name
        {
           get  { return name; }
        }

        public Shape(String name_)
        {
            name = name_;
        }
        public virtual double Area()
        {
            return 10.0;
        }

        public override string ToString()
        {
            return "I am a shape by the name of " + name;
        }

    }
}
