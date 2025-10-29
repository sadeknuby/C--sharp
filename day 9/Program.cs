using System;
namespace app
{
    class program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("enter your age");
              int age = int.Parse(Console.ReadLine());
              string message;
              message = age > 18 ? "you are adult" : "you are teenager or child";
              Console.WriteLine(message);
            ////////////////////////////////////////////
            Console.WriteLine("enter num1");
             float num1 = float.Parse(Console.ReadLine());
             Console.WriteLine("enter num2");
             float num2 = float.Parse(Console.ReadLine());
             float num3 = num1 / num2;
             Console.WriteLine("the divided answer is");
             Console.WriteLine(string.Format("{0:0.00}", num3));
             Console.WriteLine(string.Format("{0:0.000}", num3));
            ///////////////////////
            Console.WriteLine("enter your mark in digits");
            string mark = Console.ReadLine();
            if (int.TryParse(mark, out int num))
            {
                if (num > 50)
                {
                    Console.WriteLine("you pass");
                }
                else
                {
                    Console.WriteLine("you fail");
                }
            }
            else
            {
                Console.WriteLine("please enter it in digits");
            }
        }
    }
} 

