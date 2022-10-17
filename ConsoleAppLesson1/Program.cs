using System;
namespace ConsoleAppLesson1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Digit");
            int var1;

            while (true)
            {
                try
                {
                    var1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Siz ancaq integer daxil ede bielrsiniz");
                }

            }





            Console.WriteLine("Enter Second Digit");
            int var2 = int.Parse(Console.ReadLine());

            int sum = var1 + var2;
            Console.WriteLine("Sum is:" + sum);

        }
        public static int Sum(int var1, int var2)
        {
            return var1 + var2;
        }



    }
}

