namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Funciones

            int a = 2;
            int b = 2;

            int c =  a + b;
            int d = c;
            // Console.WriteLine(d);
            Show(d);
            Sum(a, b);
            int m = Mul(a, b);
            Console.WriteLine($"La multiplicacion es: {m}");
        }


        static void Show(int num1)
        {
            Console.WriteLine(num1);
        }

        static void Sum(int x, int y)
        {
            int z = x + y;
            Console.WriteLine($"La suma es: {z}");
        }

        static int Mul(int a, int b)
        {
            return a * b;
        }


    }
}
