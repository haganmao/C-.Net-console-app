using System;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is not dynamic programming");
            //Console.WriteLine(getFib(5));
            //Console.ReadLine();

            //Invoving array to record the fib value
            //Console.WriteLine("#####################################");
            //Console.WriteLine("This is basic dynamic programming");
            //Console.WriteLine(getFibDynamic(5));
            //Console.ReadLine();


            double a = 98, b = 0;
            double result = 0;

            try
            {
                result = SafeDivision(a,b);
                Console.WriteLine("{0} divided by {1} = {2}",a,b,result); 
            }
            catch (DivideByZeroException e){
                Console.WriteLine("Attempted divided by zero");

            }
            Console.ReadLine();
        }
        static double SafeDivision(double x, double y) {

            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
   
        }







        //static int getFib(int n) {
        //    if (n == 1)
        //        return 1;
        //    if (n == 2)
        //        return 1;
        //    return getFib(n - 1) + getFib(n-2);
        //}


        //static int[] fib = new int[6];
        //static int getFibDynamic(int n)
        //{
        //    if (n == 1)
        //        return fib[1]=1;
        //    if (n == 2)
        //        return fib[2]=1;
        //    if (fib[n] != 0)
        //    {

        //        return fib[n];
        //    }

        //    else { 

        //        return fib[n]= getFibDynamic(n - 1) + getFibDynamic(n - 2);
        //    }
        //}


    }
}
