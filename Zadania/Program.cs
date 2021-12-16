using System;

namespace ppk_main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("liczba  nr 1");
            int liczba_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("liczba nr 2");
            int liczba_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(liczba_1 * liczba_2);
        }
    }
}