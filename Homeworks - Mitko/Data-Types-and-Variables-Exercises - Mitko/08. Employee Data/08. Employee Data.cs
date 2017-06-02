using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            Console.WriteLine($"First name: {firstName}");
            string LastName = Console.ReadLine();
            Console.WriteLine($"Last name: {LastName}");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Age: {age}");
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine($"Gender: {gender}");
            decimal personalID = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Personal ID: {personalID}");
            int employeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Unique Employee number: {employeeNumber}");

        }
    }
}
