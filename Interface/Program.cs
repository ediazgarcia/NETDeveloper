namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shark[] sharks = { new Shark("Tibu", 50), new Shark("Jaws", 60) };

            ShowFish(sharks);
            ShowAnimals(sharks);

        }


        public static void ShowAnimals(IAnaimal[] animals)
        {
            Console.WriteLine("-- Mostramos los animales --");
            int i = 0;
            while (i < animals.Length)
            {
                Console.WriteLine(animals[i].Name);
                i++;
            }
        }

        public static void ShowFish(IFish[] fish)
        {
            Console.WriteLine("-- Mostramos los peces --");
            int i = 0;
            while (i< fish.Length)
            {
                Console.WriteLine(fish[i].Swim());
                i++;
            }
        }

        public class Shark: IAnaimal, IFish
        {
            public string Name { get; set; }    
            public int Speed { get; set; }  

            public Shark(string Name, int Speed)
            {
                this.Name = Name;
                this.Speed = Speed;
            }

            public string Swim()
            {
                return $"{Name} Nada {Speed} km/h";
            }


        }

        public interface IAnaimal
        {
            public string Name { get; set;}
        }

        public interface IFish
        {
            public int Speed { get; set;}

            public string Swim();

        }


    }
}
