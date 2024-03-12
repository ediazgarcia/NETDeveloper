using System.Text.Json;

namespace SerializacionDeObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Beer myBeer = new Beer()
            {
                Name = "Cerveza Republica",
                Brand = "Alofoke"
            };


            string json = JsonSerializer.Serialize(myBeer);
            Console.WriteLine(json);

            Beer beer = JsonSerializer.Deserialize<Beer>(json);
            Console.WriteLine(beer);

            Console.WriteLine("hhh");
        }

        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }
        }
    }
}
