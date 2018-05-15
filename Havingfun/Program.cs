using System;

namespace Havingfun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, what is your name? ");
            var input = Console.ReadLine();

            while(true)
            {
                Console.Write(input + ", did you know that Steve Loves you very much? ");
                var question = Console.ReadLine();

                if (question == "yes")
                    break;

                else
                    Console.WriteLine("Youre wrong, please try again!");
                
            }
                
                



        }
    }
}
