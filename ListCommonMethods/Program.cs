namespace ListCommonMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var listNumbers = new List<int>()
            {
                1,2,4,3
            };

            Show(listNumbers);

            listNumbers.Insert(4, 5);

            Show(listNumbers);

            if (listNumbers.Contains(1))
            {
                Console.WriteLine("Existe");
            }
            else
            {
                Console.WriteLine("No Existe");
            }

            int pos = listNumbers.IndexOf(4);
            Console.WriteLine(pos);

            listNumbers.Sort();
            Show(listNumbers);


        }

        public static void Show(List<int> numbers)
        {
            Console.WriteLine("-- Numeros --");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
