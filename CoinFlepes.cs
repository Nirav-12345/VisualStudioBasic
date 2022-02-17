using System;


namespace FlipsCoin

{

    public class CoinFlepes
    {
        public static double coin1(int flips,int num1)
        {
            // Console.WriteLine("Please enter the flips");

            int Head = 0;

            int Tail = 0;

            int HeadCount = 0;

            int TailCount = 0;

            double HeadPercentage=0;

            double TailPercentage;

            // int flips = Convert.ToInt32(Console.ReadLine());

            if (flips > 0)

            {

                for (int i = 0; i < flips; i++)

                {
                    Random random = new Random();
                    int num = random.Next(2);

                    if (num == 1)
                    {

                        Head = 1;

                        HeadCount = HeadCount+Head;
                    }

                    else if (num == 0)

                    {
                        Tail = 1;

                        TailCount = TailCount+Tail;
                    }

                }

                HeadPercentage = HeadCount * 100 / flips;

                TailPercentage = TailCount * 100 / flips;

                //Console.WriteLine("head percentage" + HeadPercentage);

                Console.WriteLine("Tail percentage" + TailPercentage);
            }

            else
            {
                Console.WriteLine("Enter a postive integer");
            }


            return HeadPercentage;



        }

    }
}

