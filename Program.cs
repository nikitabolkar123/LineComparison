using System;

namespace UC2_CheckEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Line Comparsion Problems");

            int x1, x2, y1, y2;
            Console.WriteLine("Please Enter X1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter X2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            double LineLength1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Length of Line 1 is : {LineLength1}");

            int l1, l2, m1, m2;

            Console.WriteLine("Please Enter l1:");
            l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter l2:");
            l2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter m1:");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter m2:");
            m2 = Convert.ToInt32(Console.ReadLine());

            double LineLength2 = Math.Sqrt(Math.Pow(l2 - l1, 2) + Math.Pow(m2 - m1, 2));
            Console.WriteLine($"Length of the Line 2 is : {LineLength2}");

            if (int.Equals(LineLength1, LineLength2))
            {
                Console.WriteLine("Length Of the Two Lines are Equal");
            }
            else
            {
                Console.WriteLine("Length Of the Two Lines are Not Equal");
            }

        }
    }
}