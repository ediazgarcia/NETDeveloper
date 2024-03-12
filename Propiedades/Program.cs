namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sale sale2 = new Sale(100, DateTime.Now);
            // sale2.Date = DateTime.Now;
            Console.WriteLine(sale2.Total);
            Console.WriteLine(sale2.Date);
        }

        class Sale
        {
            private int total;
            private DateTime date;

            public int Total
            {
                get
                {
                    return total;
                }
                set
                {
                    if (value < 0)
                    {
                        value = 0;
                        total = value;
                    }
                }
            }

            public string Date
            {
                get
                {
                    return date.ToLongDateString();
                }

            }

            public Sale(int total, DateTime date)
            {
                this.total = total;
                this.date = date;
            }

            public string GetInfo()
            {
                return total + " " + date.ToLongDateString();

            }

            public void Show()
            {
                Console.WriteLine("Hola soy una venta...");
            }
        }
    }
}
