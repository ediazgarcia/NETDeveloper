﻿namespace Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Math math = new Math();
            Console.WriteLine(math.Sum(1,2));
            Console.WriteLine(math.Sum("1", "2"));

            int[] numbers = { 1, 2, };
            Console.WriteLine(math.Sum(numbers));
        }

        class Math
        {

            // Sobrecarga
            public int Sum(int a, int b)
            {
                return a + b;
            }

            public int Sum(string a, string b)
            {
                return int.Parse(a) + int.Parse(b);
            }

            public int Sum(int[] numbers)
            {
                int result = 0;
                int i = 0;

                while (i < numbers.Length)
                {

                    result += numbers[i];
                    i++;
                }

                return result;

            }
        }
    }
}