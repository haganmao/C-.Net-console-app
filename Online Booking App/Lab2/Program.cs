using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle c1 = Create_Circle();
            //c1 = new Circle("CircleOne",5.0);
            //c1.radius = 5.0;
            //Double c1_area = c1.Area();
            //Console.WriteLine("The new Circle name is: " + c1.name);
            //Console.WriteLine("The new Circle name is: " + c1.Area());
            //Console.ReadLine();

            Circle Circle_A = Create_Circle();
            Console.Write("Circle" + Circle_A.Name());


            Console.Write("Circle " + Circle_A.Name());
            Console.WriteLine("Created with Radius: " + Circle_A.Radius());
            Console.WriteLine("its area is: " + Circle_A.Area());

            Circle Circle_B = Create_Circle();
            Console.Write("Circle " + Circle_B.Name());
            Console.WriteLine("Created with Radius: " + Circle_B.Radius());
            Console.WriteLine("its area is: " + Circle_B.Area());

            if (Circle_A.is_Greater_Than(Circle_B))
            {
                Console.Write("Circle " + Circle_A.Name() + " is greater than ");
                Console.WriteLine("Circle " + Circle_B.Name());
            }

            else if (Circle_B.is_Greater_Than(Circle_A))
            {
                Console.Write("Circle " + Circle_B.Name() + " is greater than ");
                Console.WriteLine("Circle " + Circle_A.Name());
            }

            else {
                Console.Write("Circle " + Circle_A.Name() + " and Circle " + Circle_B.Name());
                Console.WriteLine(" are same size");
            }

            Console.ReadKey();
            Console.ReadLine();
        }

        static Circle Create_Circle()
        {
            String name, temp;
            double radius;
            Console.Write("Please enter name for new Circle:");
            name = Console.ReadLine();
            Console.Write("Please enter radius: ");
            temp = Console.ReadLine();
            radius = double.Parse(temp);
            return new Circle(name, radius);
        }


    }
}
