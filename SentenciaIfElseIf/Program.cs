namespace SentenciaIfElseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sentencia If:");

            bool areYouHungry = true;
            bool youHaveMoney = true;

            if (areYouHungry && youHaveMoney && IsOpenRestaurant("Restaurant Eddy", 11))
            {
                Console.WriteLine("Puede entrar a comer!");
            }
            else
            {
                Console.WriteLine("No puedes entrar a comer!");
            }


            static bool IsOpenRestaurant(string name, int hour = 0)
            {
                if (name == "Restaurant Eddy!" && hour > 8 && hour < 23)
                {
                    return true;
                }
                else if (name == "Restaurant 24 horas!")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
