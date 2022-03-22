using System;

namespace AssignmentThreeandFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 3
            
            var l = 1;
            var f = 1;
            var n = 2;
            var s = 1;
            var w = 1;

            var y = l - (Math.Pow(f, n) * ((s * l / f) + Math.Pow(20 / f, w)) / Math.Pow(20, n));

            //Assignment 4

            var a = 10;var b = 20;var c = 30;
            bool condition1 = a == b;
            bool condition2 = c > (a + b - c);
            bool condition3 = (c - b) == a;

            Console.WriteLine("A is equal to B is " + condition1);
            Console.WriteLine("C is greater than A + B - C is " + condition2);
            Console.WriteLine("C - B is equal to A is " + condition3);
        }
    }
}
