using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCpacity = int.Parse(Console.ReadLine());

            double neededCources = Math.Ceiling((double)peopleCount / elevatorCpacity);
            Console.WriteLine(neededCources);
        }
    }
}
