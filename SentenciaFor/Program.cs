namespace SentenciaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sentencia For: ");


            // arreglo 
            string[] fruits = { "Mango", "Apple", "PineApple" };

            // for loop

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}
