namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (int id, string name) product = (1, "Cerveza Republica");

            Console.WriteLine($"{product.id}, {product.name}");

            product.name = "Cerveza Presidente";
            Console.WriteLine($"{product.id}, {product.name}");

            var person = (1, "Eddy");
            Console.WriteLine(person);

            var cityInfo = getLocationRD();
            Console.WriteLine($"lat: {cityInfo.lat}, lng: {cityInfo.lng}, name: {cityInfo.name}");
        }

        public static (float lat, float lng, string name) getLocationRD()
        {
            float lat = 18.65656323f;
            float lng = 99.635656565f;
            string name = "RD";

            return (lat, lng, name);
        }
    }
}
