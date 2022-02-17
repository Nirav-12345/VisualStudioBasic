using System;
namespace FlipsCoin
{
    class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Please enter the flips");


            int flips1 = Convert.ToInt32(Console.ReadLine());
           double val= CoinFlepes.coin1(flips1,2);
            Console.WriteLine("head percentage " + val);

        }
    }

}