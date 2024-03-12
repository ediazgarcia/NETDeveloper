namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var beers = new List<Beer>()
            {
                new Beer(){
                    Name = "Corona", Country="Mexico"
                },
                new Beer(){
                    Name = "Presidente", Country="RepublicaDominicana"
                },
                new Beer(){
                    Name = "Republica", Country="RepublicaDominicana"
                }
            };

            foreach (var beer in beers)
            {
                Console.WriteLine(beer);
            }

            Console.WriteLine("----------------------------");

            // select

            var beersName = from b in beers
                            select new
                            {
                                Name = b.Name,
                                Letters = b.Name.Length,
                                Fixed = 1
                            };

            foreach (var beer in beersName)
            {
                Console.WriteLine($"{beer.Name} {beer.Letters} {beer.Fixed}");
            }

            Console.WriteLine("-------------------------------");

            var beerFilter = from b in beers
                             where b.Country == "Mexico"
                             select b;

            foreach (var filters in beers)
            {
                Console.WriteLine(filters);
            }

            Console.WriteLine("--------------------------");

            var orderedBeers = from b in beers
                               orderby b.Country descending
                               select b;

            foreach (var orderBeers in orderedBeers)
            {
                Console.WriteLine(orderBeers);
            }
        }
    }


    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name}, País: {Country}";


        }
    }

}
