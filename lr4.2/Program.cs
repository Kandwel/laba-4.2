using System;

namespace lr4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Student!");

            double a, b, c;

            void A()
            {
                a = Convert.ToDouble(Console.ReadLine());
            }

            void B()
            {
                b = Convert.ToDouble(Console.ReadLine());
            }

            A();
            B();
            c = a / b;
            Console.WriteLine("\n{0} / {1} = {2}\n", a, b, c);

        }
    }
}
