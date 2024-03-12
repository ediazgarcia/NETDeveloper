namespace SentenciaWhileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sentencia While y Do While : ");

            // While


            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Iteracion de i" + i);
                // i = i + 1;
                i++;
            }

            int j = 0;

            while (j < 100)
            {

                if (j > 10)
                {
                    break;
                }
                Console.WriteLine("Iteracion de j" + j);
                // i = i + 1;
                j++;
            }


            // recorrer arreglo con while
            string[] fruits = { "Mango", "Apple", "PineApple" };

            int index = 0;
            while (index < fruits.Length)
            {
                Console.WriteLine(fruits[index]);
                index++;
            }


            // do while
            bool run = false;

            do
            {
                Console.WriteLine("Entro una vez!");

            } while (run);


        }
    }
}
