using System;
using System.Collections.Generic;


namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // List

            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);

            Console.WriteLine(numbers.Count);

            numbers.Clear();
            Console.WriteLine(numbers);


            List<string> stringsName = new List<string>()
            {
                "Juan", "Pedro", "Ezequiel"
            };

            Console.WriteLine(stringsName.Count);


        }
    }
}
