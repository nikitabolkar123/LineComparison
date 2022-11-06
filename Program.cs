using System;

namespace UC4_CompareMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparison Computation Program");

            int x1, x2, y1, y2;

            Console.WriteLine("Please Enter the  X1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the  X2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            double LineLength1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Length of Line 1 is : {LineLength1}");

            int l1, l2, m1, m2;

            Console.WriteLine("Please Enter the l1:");
            l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter  the l2:");
            l2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the m1:");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the m2:");
            m2 = Convert.ToInt32(Console.ReadLine());

            double LineLength2 = Math.Sqrt(Math.Pow(l2 - l1, 2) + Math.Pow(m2 - m1, 2));
            Console.WriteLine($"Length of the Line 2 is : {LineLength2}");

            if (LineLength1 > LineLength2)
            {
                Console.WriteLine("Length Of the  1st Line is Greater");
            }
            else if (LineLength1 < LineLength2)
            {
                Console.WriteLine("Length Of the  2nd is Greater");
            }
            else
            {
                Console.WriteLine("Two Lines are the Equals");
            }

        }
    }

}