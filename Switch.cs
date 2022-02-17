using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    public class Switch
    {

        public static void Si()
        {
            Console.WriteLine("Enter month");

            Random random = new Random();
            int num = random.Next(13);

            switch(num)

            {
                case 0:
                    Console.WriteLine("Jan");
                    break;

                case 1:
                    Console.WriteLine("feb");
                    break;

                case 2:

                    Console.WriteLine("march");
                    break;

                case 3:

                    Console.WriteLine("April");

                    break;


                case 4:

                    Console.WriteLine("May");

                    break;


                case 5:

                    Console.WriteLine("Jun");

                    break;



                case 6:

                    Console.WriteLine("Jul");
                    break;


                case 7:

                    Console.WriteLine("Aug");

                    break;


                case 8:

                    Console.WriteLine("Sp");

                    break;






                case 9:
                    Console.WriteLine("Oct");

                    break;


                case 10:

                    Console.WriteLine("Nov");

                    break;


                case 11:

                    Console.WriteLine("Dec");

                    break;

                default:

                    Console.WriteLine("not here");
                    break;






            }
            Console.WriteLine("Month Display");
        }
    }
}
