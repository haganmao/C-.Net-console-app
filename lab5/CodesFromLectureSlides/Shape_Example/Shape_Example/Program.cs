using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape("Sue");
            Console.WriteLine(s1.ToString());

            Circle c1 = new Circle(5, "Clyde");
            Console.WriteLine(c1.ToString());

            Rectangle r1 = new Rectangle(2, 4, "Rhonda");
            Console.WriteLine(r1.ToString());
            Console.ReadLine();


        }
    }
}
