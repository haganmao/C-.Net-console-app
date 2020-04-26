using System;

// 1.This is basic c# lab task for practising class, constructors, methods
// 2.Circle class has two constructors, one is default constructor and other one is constructor can be used create objects.
// 3.public functions can be used to get the attributes of the object. 

namespace Lab3_task1
{
    class Program
    {
        static void Main(string[] args)
        {
             //##############################################################################################################################
            //1.2
            //create an instance called c1 of Circle datatype
            // Circle c1 = Create_Circle();
            // Console.Write("Circle " + c1.cName());
            // Console.WriteLine("created with radius " + c1.cRadius());
            // Console.WriteLine("Its area is: " + c1.CircleArea());
            //Console.ReadLine(); 


            // create two obejects and comparing the area values.
            // Circle circleA =  Create_Circle();
            // Console.WriteLine("Circle " + circleA.cName() + ", radius is " + circleA.cRadius() + ", Area is " + circleA.CircleArea());

            // Circle circleB = Create_Circle();
            // Console.WriteLine("Circle " + circleB.cName() + ", radius is " + circleB.cRadius() + ", Area is " + circleB.CircleArea());
            


            // if(circleA.Is_Greater_Than(circleB)){
            //     Console.WriteLine("Circle " + circleA.cName() + " is greater than " + circleB.cName());
            // }

            // else if(circleB.Is_Greater_Than(circleA)){
            //     Console.WriteLine("Circle " + circleB.cName() + " is greater than " + circleA.cName());
            // }

            // else{
            //     Console.WriteLine("Circle " + circleA.cName() + " is equal to " + "Circle" + circleB.cName());
            // }

            // Console.WriteLine();   
            //##############################################################################################################################
            //1.3
            Circle c1;
            Circle c2;

            c1 = new Circle("Circle1",5.0);
            c2 = new Circle("Circle1",5.0);

            if(c1==c2)
            {

                Console.WriteLine("C1 and C2 are equal");
            }

            else
            {

                Console.WriteLine("C1 and C2 are not equal");
            }
            Console.ReadLine();
        }

        //return type is Circle
         static Circle Create_Circle(){
            String name,temp;
            double raduis;

            //Get user input
            Console.WriteLine("Please enter circle name: ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter circle raduis: ");
            temp = Console.ReadLine();
            //raduis = Console.ReadLine();
            raduis = double.Parse(temp);
            return new Circle(name, raduis);
        }

    }
}
