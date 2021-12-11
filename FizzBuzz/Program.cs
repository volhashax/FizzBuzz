using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m = ArrayGeneration(n);
            
            for(int i = 0; i < m.Length; i++)
            { 
            
                if (m[i]% 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (m[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (m[i] % 3 == 0 && m[i] % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
           }

        }

        private static int[] ArrayGeneration(int n)
        {
            int[] array = new int[n];

            for(int i = 1; i <= array.Length; i++)
            {
                array[i-1] = i;
            }

            return array;
        }
    }
}
