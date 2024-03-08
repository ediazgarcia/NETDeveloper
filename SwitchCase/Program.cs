namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch Case: ");

            int op = 1;

            switch (op)
            {
                case 1:
                    Console.WriteLine("Selecioneste el 1");
                    break;
                case 2:
                    Console.WriteLine("Selecioneste el 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Selecionaste el 3 y 4");
                    break;
                case < 0:
                case > 100:
                    Console.WriteLine("Fuera de rango");
                    break;
                case > 4 and < 10:
                    Console.WriteLine("Selecionaste una opcion entre 4 y 10");
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
        }
    }
}
