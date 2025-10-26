using System;
namespace app
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Radius:");
            float radius = Single.Parse(Console.ReadLine());
            const float pi = 3.14f;
            float ball_area = 4 * radius * radius * pi;
            Console.WriteLine($"The Ball Area Is:{ball_area}");






        }
    }
}