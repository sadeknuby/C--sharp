using System;
using System.Diagnostics.Contracts;
namespace app
{
    class program
    {
        static void Main(string[]args)
        {

            string r = "*";
            while(r !="*****")
            {
                Console.WriteLine(r);
                r = r +"*";



            }



            char a = '@';
            for (int i = 0; i <26 ; i++)
            {
                a += '';
                Console.Write(a+" ");
            }

        }
    }
}