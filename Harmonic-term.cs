using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic_term
{
    public class Harmonic_term


    {
        public static void Harmonic()
            {


            double n = Convert.ToInt32(Console.ReadLine());

            double harmonic = 1;

            for (float i = 2; i <= n; i++)

            {
                harmonic = harmonic + 1 / i;

                Console.WriteLine(harmonic);


            }

        }
}
}
