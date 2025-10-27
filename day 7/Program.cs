using System;
using System.Diagnostics.Contracts;
namespace app
{
    class program
    {
        static void Main(string[]args)
        {
            Console.Write("Enter A Number Please: ");
            float num = float.Parse(Console.ReadLine());
            if (num%2== 0) 
            {
                Console.WriteLine("The Number is even");
            }
            else
            {
                Console.WriteLine("The Number is odd");
            }
           
            Console.Write("Enter Your Grade:");
            
            char grade = char.Parse(Console.ReadLine());
              grade = char.ToUpper(grade);
        
        switch(grade)
            {
                case 'A': Console.WriteLine("Excellent");
                    break;
                case 'B': Console.WriteLine("Very Good");
                    break;
                case 'C':Console.WriteLine("Good");
                    break;
                case 'D':Console.WriteLine("pass");
                    break;
                case 'F':Console.WriteLine("Fail");
                    break;
                default:Console.WriteLine("Answer Not Correct");
                    break;
            }

        }
    }
}