using System;

namespace ppk_main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int silnia = 1;
            for (int i = 1; i <= 9; i++)
            {

                silnia *= i; 
                Console.WriteLine(silnia);

            }
        }
    }
}