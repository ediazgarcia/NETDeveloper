namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var list = new List<int>()
            {
                25,36,85,69
            };

            var list2 = new List<string>()
            {
                "Pepe", "Pichu"
            };

            foreach (var number in list)
            {
                Console.WriteLine(number);
            }

            foreach (var strings in list2)
            {
                Console.WriteLine(strings);
            }

            var person = new List<People>()
            {
                new People() {Name = "Kiso", Country = "Republica Dominicana"},
                new People() {Name = "Quik", Country = "Republica Dominicana"}
            };

            Show(person);

        }

        static void Show(List<People> person)
        {
            Console.WriteLine("-- Personas -- ");
            foreach (var people in person)
            {
                Console.WriteLine($"Nombre: {people.Name}, Pais: {people.Country}");
            }
        }

    }

    class People
    {
        public string Name { get; set; }
        public string Country { get; set; }

    }


}
