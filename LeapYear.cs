using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    public class LeapYear
    {

        public static void Leapyear()

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
