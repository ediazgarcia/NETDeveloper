namespace Json
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

            string json = "{\"Name\": \"Cerveza Republica\", \"Brand\": \"Alofoke\"}";


        }

        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }
        }
    }
}
