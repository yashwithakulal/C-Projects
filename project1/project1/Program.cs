using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the radius");
            double radius = Convert.ToDouble(Console.ReadLine());
            const double pi = 3.14567;
            double Area = pi * radius* radius;
            Console.WriteLine("Radius is:{0},area is:{1}", radius, Area);
            Console.ReadLine();

            
         }
    }
}
