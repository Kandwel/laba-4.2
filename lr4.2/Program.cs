using System;

namespace lr4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Student!");

            double a, b;

            void A()
            {
                a = Convert.ToDouble(Console.ReadLine());
            }

            void B()
            {
                b = Convert.ToDouble(Console.ReadLine());
            }


            Console.WriteLine("Hello Student!");

            int n;

            void Menu()
            {
                Console.WriteLine("Меню: \n1) Ввести A \n2) Ввести B \n3) Сложить A и B " +
                "\n4) Вычесть B из A \n5) Умножить A на B \n6) Разделить A на B \n7) Куда я попал? Я хочу выйти отсюда.");
            }

            while (true)
            {
                Menu();
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 1)
                {

                }

                if (n == 2)
                {

                }

                if (n == 3)
                {

                }

                if (n == 4)
                {

                }

                if (n == 5)
                {

                }

                if (n == 6)
                {

                }

                if (n == 7)
                    break;
            }


        }
    }
}
