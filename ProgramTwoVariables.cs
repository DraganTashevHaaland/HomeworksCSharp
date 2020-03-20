using System;

namespace Homework_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter first nubmer: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the secound umber: ");
            b = Convert.ToInt32(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("A is the larger");
            }
            else if(b > a)
            {
                Console.WriteLine("B is the larger");
            }
            if(a % 2 == 0)
            {
                Console.WriteLine("A is even");
            }
            else
            {
                Console.WriteLine("A is odd");
            }
            if(b % 2 == 0)
            {
                Console.WriteLine("B is even");
            }
            else
            {
                Console.WriteLine("B is odd");
            }
            Console.ReadLine();
        }
    }
}
