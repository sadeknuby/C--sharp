using System;
using System.Transactions;
namespace app 
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter your Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Where Are You From?");
            string country = Console.ReadLine();
            Console.WriteLine($"Hello '{name}',How Are You Doing \\ \"\"\"Your Age Is \"{age}\"\" + And Your Country Is: {country} ");
            Console.WriteLine($"\n\nHello '{name}' How Are You Doing \\\"\n\"\"\"Your Age Is\"{age}\" + \nAnd Your Country Is: {country}");
            Console.ReadKey();
        }
    }
}