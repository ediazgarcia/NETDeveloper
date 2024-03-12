namespace Sobreescritura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            B b = new B();
            Console.WriteLine(b.Hi());


        }


        public class A
        {
            public virtual string Hi()
            {
                return "Hola soy A";
            }
        }


        public class B : A
        {
            public override string Hi()
            {
                return base.Hi() + " " + "Hola soy B";
            }
        }

        public class Sale
        {
            private decimal[] _amounts;
            private int _n;
            public Sale(int n)
            {
                _amounts = new decimal[n];
                _n = n;
            }
        }

    }
}
