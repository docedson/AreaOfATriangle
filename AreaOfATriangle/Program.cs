using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfATriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The test was for me to create a program that calculates the area of a triangle. The formula (typed out)
             * is "A = 1/2 *(bh)"  */

            //The length of the base of the triangle
            float b = 2;

            //The hight of the triangle
            float h = 4;

            //The math
            float area = 0.5f * b * h;

            //The results
            Console.WriteLine("Base: " + b);
            Console.WriteLine("Height: " + h);
            Console.WriteLine("Area: " + area);
        }
    }
}
