using System;

namespace ppk_main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wpisz liczbe z ktorej mam policzyc silnie !(liczba)");
            int liczba = Convert.ToInt32(Console.ReadLine());
            int silnia = 1;
            for (int i = 1; i <= liczba; i++)
            {

                silnia *= i; 
                Console.WriteLine(silnia);

            }
        }
    }
}