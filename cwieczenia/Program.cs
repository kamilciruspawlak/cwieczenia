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
            int firstNumber = 0;
            int secondNumber = 0;
            do {
                Console.WriteLine("Podaj początek zakresu losowania liczb: ");
            }
            while(!int.TryParse(Console.ReadLine(), out firstNumber));
            do {
                Console.WriteLine("Podaj koniec zakresu losowania liczb: ");
            }
            while(!int.TryParse(Console.ReadLine(), out secondNumber));
            Console.WriteLine("Suma dwóch losowych liczb z zakresu: " + firstNumber +"-" 
                              + secondNumber + " to: " + addRandomNumbers.Randomize(firstNumber, secondNumber));
            Console.ReadLine();
        }
    }
}
// Metoda do sumowania dwóch losowych liczb.Zakres losowanie musi zostać określony przez użytkownika.  