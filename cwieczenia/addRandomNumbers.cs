using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwieczenia
{
    class addRandomNumbers
    {
        public static int Randomize(int firstNumber, int secondNumber)
        {
            Random rnd = new Random();
            int firstRnd = rnd.Next(firstNumber, secondNumber);
            int secondRnd = rnd.Next(firstNumber, secondNumber);
            int sum = firstRnd + secondRnd;
            return sum;
        }
        public static float Randomize(float firstNumber, float secondNumber)
        {
            Random rnd = new Random();
            float firstRnd = rnd.Next(firstNumber, secondNumber);
            float secondRnd = rnd.Next(firstNumber, secondNumber);
            float sum = firstRnd + secondRnd;
            return sum;
        }
        public static decimal Randomize(decimal firstNumber, decimal secondNumber)
        {
            Random rnd = new Random();
            decimal firstRnd = rnd.Next(firstNumber, secondNumber);
            decimal secondRnd = rnd.Next(firstNumber, secondNumber);
            decimal sum = firstRnd + secondRnd;
            return sum;
        }

    }
}
