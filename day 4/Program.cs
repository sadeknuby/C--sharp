using System;
namespace app
{
    class program
    {
        static void Main(string[] args)
        {
            //طريقة الاولي لتعريف المتغير string
            string name = "sadek mohammad";

            //الطريقة الاولي للطباعة الاسم
            Console.Write("hello my name is {0} ",name);

            //الطريقة الثانية للطباعة الاسم
            Console.WriteLine($"\nmy name is {name}");

            //الطريقة التانية لتعريف المتغير string
            string fullname1 = "sadek" + " " + "mohammad";

            //الطريقة التالتة لتعرف المتغير string بس منغير +
            string fullname2 = string.Concat("sadek", " ", "mohammad");
            Console.WriteLine("\n"+fullname1);
              Console.WriteLine("\n"+fullname2);

            //طريقة تبديل string
            Console.WriteLine(name.Replace("sadek mohammad", "sadek mohammed"));





                










    } }
}
