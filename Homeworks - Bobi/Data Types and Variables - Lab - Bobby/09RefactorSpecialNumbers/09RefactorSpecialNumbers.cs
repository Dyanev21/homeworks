using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int num = 1; num <= number; num++)
            {
                int sum = 0;
                int digit = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                bool magicNumbers = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{digit} -> {magicNumbers}");
                num = digit;
            }

        }
    }
}
