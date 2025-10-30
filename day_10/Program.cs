using System;
namespace app
{
    class program
    {
        static void Main(string[] args)
        {
            int c = 1;
            float avg=0;
            Console.WriteLine("Enter the student's 3 grades:");
            string decision = "o";
            while (decision != "n")
            {
                int i = 0;
                while (i<3)
                {                  
                    Console.Write($"Grade {c}:");
                   float g = float.Parse(Console.ReadLine());

                    if (g >= 0 && g <= 100)
                    {
                        i++;
                        c++;
                        avg = (avg + g) / 3;
                    }
                    else
                    {
                        Console.WriteLine("Enter Correct Grade!");
                    }
                    
                }
                c = 1;


                Console.WriteLine("\n\nAverage = {0:0.00}",avg);
                string message = avg >= 50 ? "Passed" : "Failed";
                Console.WriteLine($"Result : {message}");

                switch (avg)
                {
                    case >= 90:
                        Console.WriteLine("Grade: Excellent");
                        break;
                    case >= 80:
                        Console.WriteLine("Grade: Very Good");
                        break;
                    case >= 70:
                        Console.WriteLine("Grade: Good");
                        break;
                    case >= 60:
                        Console.WriteLine("Grade: Fair");
                        break;
                    default:
                        Console.WriteLine("Grade: Weak");
                        break;


                }
                Console.WriteLine("\n\nDo you want to calculate another student?   (y/n):");
                decision = Console.ReadLine();
                bool z = decision == "n";
                bool y = decision == "y";
                bool v = z || y;
                while (v!=true)
                {
                    Console.WriteLine("Enter y or n only!");
                    decision = Console.ReadLine();
                    z = decision == "n";
                    y = decision == "y";
                    v =z||y;

                }

            }
            Console.WriteLine("Program Ended");

        }
    }
}