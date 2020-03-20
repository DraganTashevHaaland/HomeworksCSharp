using System;

namespace LoopsArraysHomework
{
    class Program
    {
        static void Main(string[] args)
        {
			int i, even = 0;
			int[] arr = new int[5];

			Console.Write("Enter Five Numbers :");

			for (i = 0; i < arr.Length; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			for (i = 0; i < 5; i++)
			{
				if (arr[i] % 2 == 0)
				{
					even = even + arr[i];
				}
				
				
			}
			Console.WriteLine("Sum of even numbers is :" + even);
			
		}
    }
}
