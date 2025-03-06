using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0
{
    internal class FizzBuzz
    {
        int upperLimit;
        public FizzBuzz()
        {
            Console.Write("Wpisz gorny limit: ");
            int upperLimit = int.Parse(Console.ReadLine());
            this.upperLimit = upperLimit;
        }

        public void Metoda()
        {
            for (int i = 1; i <= upperLimit; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}

