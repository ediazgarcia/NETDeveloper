namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Eddy", 28, "cardiologo");
            Console.WriteLine(doctor1.GetInfo());
            Console.WriteLine(doctor1.GetData());

            Dev dev1 = new Dev("Juan", 28, "C#");
            Console.WriteLine(dev1.GetData());


        }

        class Persona
        {
            private string _name;
            private int _age;

            public Persona(string name, int age) 
            {
                _name = name;
                _age = age;
            }

            public string GetInfo()
            {
                return $"{_name} -  {_age}";
            }

        }

        class Doctor : Persona
        {
            private string _speciality;
            public Doctor(string name, int age, string speciality) : base(name, age)
            {
                _speciality = speciality;

            }

            public string GetData()
            {
                return GetInfo() + " " + _speciality;
            }
        }

        class Dev : Persona
        {
            private string _lenguage;

            public Dev(string name, int age, string lenguage) : base (name, age) 
            {
                _lenguage = lenguage;
            }

            public string GetData()
            {
                return GetData() + " " + _lenguage;
            }
        }
    }
}
