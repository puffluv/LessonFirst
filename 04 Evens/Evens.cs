using System;

namespace _04_Evens
{
    internal class Evens
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            //int temp = a % 2;
            //bool result = temp == 0;
            //if (result)
            
            //if (result)
            //    Console.WriteLine("even");
            //else
            //    Console.WriteLine("not even")

            Console.WriteLine(a % 2 == 0 ? "even" : "not even");
        }
    }
}
