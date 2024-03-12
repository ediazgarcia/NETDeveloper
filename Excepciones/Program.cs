namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                string content = File.ReadAllText(@"C:\\Users\\eddym\\Desktop\\workspace\\args.txt");
                Console.WriteLine(content);

                throw new Exception("Ocurrio algo");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Se ejecuta pase lo que pase en la app");
            }
            Console.WriteLine("Aqui se sigue ejecutando");


        }
    }
}
