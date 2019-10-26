using System;

namespace Area
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double pi = 3.14;
            double r, areaOfCircle;

            Console.WriteLine("Enter a radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            areaOfCircle = pi * r * r;

            Console.WriteLine("The area of a circle with radius "+ r +" is: " + areaOfCircle + ".");
            Console.ReadLine();
        }
    }
}
