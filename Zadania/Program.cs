using System;

namespace ppk_main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("liczba 1");
            int liczba_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("liczba 2");
            int liczba_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" + dla dodawania, - dla odejmowani,* dla mnożenia, / dla dzielenia");
            char liczba = Console.ReadLine()[0];
            switch (liczba)
            {
                case '+':                  
                    Console.WriteLine(liczba_1 + liczba_2);
                    break;

                case '-':
                    Console.WriteLine(liczba_1 - liczba_2);                   
                    break;
                case '*':
                    Console.WriteLine(liczba_1 * liczba_2);
                    break;
                case '/':

                    if (liczba_1 == 0 || liczba_2 == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez 0");
                    }
                    else
                        Console.WriteLine(liczba_1 * liczba_2);
                    break;

                default:                    
                    Console.WriteLine("Nie obsługuję takiego znaku!");
                    break;
            }
        }
    }
}