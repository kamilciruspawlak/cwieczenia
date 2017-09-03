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
            Console.WriteLine("Witaj Drogi użytkowniku. Proszę przedstaw się.");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj swój wiek:");
            string age = Console.ReadLine();
            Console.WriteLine("Cześć " + name + ",fajnie że masz " + age + "lat");
            Console.ReadLine();            
        }
    }
}
