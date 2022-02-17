using System;

namespace Power_2
{
    public class Power2
    {
        public static void power()
        {
            int NUM;
            Console.WriteLine("Enter Year");
            NUM = Convert.ToInt32(Console.ReadLine());





            if ((NUM % 4 == 0 && NUM % 100 != 0) || (NUM % 400 == 0))
            {
                Console.WriteLine("It is a leap year");
            }

            else
            {
                Console.WriteLine("{0} is not a Leap Year");
            }

        }
    }
}
