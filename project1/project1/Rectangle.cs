using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class Rectangle
    {
        double length;
        double width;
        public void Details()
        {
            length = 4.5;
            width = 5.5;

        }
        public double Area()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("length of rectangle:{0}", length);
            Console.WriteLine("width of rectangle:{0}", width);
            Console.WriteLine("Area of Rectangle:{0}", Area());

        }
    }
}
