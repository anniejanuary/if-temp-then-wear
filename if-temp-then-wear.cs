using System;

namespace IntroToDecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the temperature and press enter");
            string input = Console.ReadLine();

            int inputTemperature = int.Parse(input);

     

            if (inputTemperature < 15)
            {
                Console.WriteLine("Wear a jacket");
            }

            else if (inputTemperature == 15)
            {
                Console.WriteLine("It's warm, don't wear a jacket");
            }

            else 
            {
                Console.WriteLine("Nice and cozy, wear a tshirt");
            }

            Console.Read();
        }
    }
}
