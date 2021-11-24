using System;

namespace AT_HOMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imię:");
            string imie = Console.ReadLine();

            Console.WriteLine("\n\r");

            Console.WriteLine($"{imie}, wprowadź pierwszą liczbę:");
            double wprowadzona_liczba = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\r");

            Console.WriteLine($"{imie} wprowadź następną liczbę:");
            double wprowadzona_liczba2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\r");

            Console.WriteLine($"{imie}, suma Twoich liczb to: {wprowadzona_liczba + wprowadzona_liczba2}");

            Console.WriteLine("\n\r");

            Console.WriteLine($"{imie}, różnica Twoich liczb to: {wprowadzona_liczba - wprowadzona_liczba2}");

            Console.WriteLine("\n\r");

            Console.WriteLine($"{imie}, iloczyn Twoich liczb to: {wprowadzona_liczba * wprowadzona_liczba2}");

            Console.WriteLine("\n\r");

            Console.WriteLine($"{imie}, iloraz Twoich liczb to: {wprowadzona_liczba / wprowadzona_liczba2}");

            Console.WriteLine("\n\r");

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakońćzyć. \n\r" +
                "Do zobaczenia!");

        }
    }
}
