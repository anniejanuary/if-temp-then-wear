using System;

namespace IntroToDecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = 15;

            if (temperature < 15)
            {
                Console.WriteLine("Wear a jacket");
            }

            if (temperature == 15)
            {
                Console.WriteLine("It's warm, don't wear a jacket");
            }

            if(temperature > 15)
            {
                Console.WriteLine("Nice and cozy, wear a tshirt");
            }

            Console.Read();
        }
    }
}
