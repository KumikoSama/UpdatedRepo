using System;
using System.Collections.Generic;
namespace OddEven
{
    class OddEven
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a value: ");
            int value = int.Parse(Console.ReadLine());
            identify(value);

            static int identify(int num)
            {
                int[] numberArr = new int[num];

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine($"Enter number {i + 1}");
                    numberArr[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("The following numbers are:");

                foreach (var n in numberArr)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"{n} is an even number");
                    }
                    else
                    {
                        Console.WriteLine($"{n} is an odd number");
                    }

                }
                return num;
            }
        }
    }

}