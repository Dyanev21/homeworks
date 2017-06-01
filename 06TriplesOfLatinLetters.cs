using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int ch1 = 0; ch1 < n; ch1++)
            {
                for (int ch2 = 0; ch2 < n; ch2++)
                {
                    for (int ch3 = 0; ch3 < n; ch3++)
                    {
                        char first = (char)('a' + ch1);
                        char second = (char)('a' + ch2);
                        char third = (char)('a' + ch3);
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
