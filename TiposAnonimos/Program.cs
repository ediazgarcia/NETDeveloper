namespace TiposAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new
            {
                Name = "Eddy",
                Age = 28,
                fecha = DateTime.Now

            };

            Console.WriteLine($"{person.Name} , {person.Age}");


            var person1 = new[]
            {
               new{ Name = "Eddy", Age = 28, fecha = DateTime.Now },
             
            };

            foreach (var p in person1)
            {
                Console.WriteLine(person);
            }
        }
    }
}
