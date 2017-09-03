using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwieczenia
{
    class Program
    {
        static int Randomize(int firstNumber, int secondNumber)
        {
            Random rnd = new Random();
            int firstRnd = rnd.Next(firstNumber, secondNumber);
            int secondRnd = rnd.Next(firstNumber, secondNumber);
            int sum = firstRnd + secondRnd;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj początek zakresu losowanie liczb: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj koniec zakresu losowania liczb: ");
            int secondNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Suma dwóch losowych liczb z zakresu: " + firstNumber +"-" 
                              + secondNumber + " to: " + Randomize(firstNumber, secondNumber));
            Console.ReadLine();
        }
    }
}
// Metoda do sumowania dwóch losowych liczb.Zakres losowanie musi zostać określony przez użytkownika.  