namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>(10);
            mylist.Add(10);

            MyList<string> mylist1 = new MyList<string>(10);
            mylist1.Add("Eddy");

            Console.WriteLine(mylist.GetElement(11));
            Console.WriteLine(mylist1.GetElement(0));

        }



        public class MyList<T>
        {
            private T[] _elements;
            private int _index = 0;


            public MyList(int n)
            {
                _elements = new T[n];
            }

            public void Add(T x)
            {
                if (_index < _elements.Length)
                {
                    _elements[_index] = x;
                    _index++;
                }
            }

            public T GetElement(int i)
            {
                while (i <= _index && i >= 0)
                {
                    return _elements[i];
                }
                return default(T);
            }
        }
    }
}
