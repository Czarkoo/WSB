using System;

namespace ppk_main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("liczba 1");
            int liczba_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("liczba  2");
            int liczba_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wprowadz '+' dla dodawania lub '-' dla odejmowani");
            char znak = Console.ReadLine()[0];


            if (znak == '-')
            {

                Console.WriteLine(liczba_1 - liczba_2);

            }
            else if (znak == '+')
            {
                Console.WriteLine(liczba_1 + liczba_2);
            }
            else
            {
                Console.WriteLine("nie obsługuję tego znaku");
            }
        }
    }
}