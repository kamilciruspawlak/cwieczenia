using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwieczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj początek zakresu losowanie liczb: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj koniec zakresu losowania liczb: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int firstRnd = rnd.Next(firstNumber, secondNumber);
            int secondRnd = rnd.Next(firstNumber, secondNumber);
            int sum = firstRnd + secondRnd;
            Console.WriteLine("Pierwsza wylosowana liczba to: " + firstRnd + ", druga wylosowana liczba: " 
                + secondRnd + ". Suma tych liczb to: " + sum);
            Console.ReadLine();

        }
    }
}
// Metoda do sumowania dwóch losowych liczb.Zakres losowanie musi zostać określony przez użytkownika.  