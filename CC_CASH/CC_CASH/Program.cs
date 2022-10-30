using System;

namespace CC_CASH
{
    class Program
    {
        static void Main(string[] args)
        {

            int tc = int.Parse(Console.ReadLine());

            while(tc-- > 0)
            {
                string inputLine = Console.ReadLine();

                long N = long.Parse(inputLine.Split()[0]);
                long K = long.Parse(inputLine.Split()[1]);

                var bags = Array.ConvertAll(Console.ReadLine().Split(), x => long.Parse(x));

                //Call my method :)

                Console.WriteLine(calculate(bags, K));
                //Console.ReadLine();

            }

            ////Console.WriteLine("Hello World!");
        }

        static long calculate(long[] bags, long k)
        {
            long minR = long.MaxValue;
            long TotalCoins = 0;

            bool negVal = false;
            
              //Using Loop to get C
              
            for(long c = 0; c < bags.Length; c++)
            {

                TotalCoins = 0;

                long[] currentBags = new long[bags.Length];
                Array.Copy(bags, currentBags, bags.Length);
                negVal = false;


                //else
                {
                    //Take some coins
                    for (int i = 0; i <= c; i++) //1 to C bags?
                    {
                        //Take coins Out?
                        long money = TakeMoney(currentBags[i], k);
                        
                        TotalCoins += money;
                        currentBags[i] -= money;
                        //BAG i
                    }

                    //Put coins in N - C bags
                    for(long i = currentBags.Length - (currentBags.Length - c) + 1; i < currentBags.Length; i++)
                    {
                        //Put coins if possible

                        if(currentBags[i] % k != 0)
                        {
                            ////Get Q value
                            //long q = bags[i] / k;

                            long q = k - (currentBags[i] % k);
                            currentBags[i] += q;
                            if (TotalCoins - q >= 0)
                                TotalCoins -= q;
                            else
                            { negVal = true; 
                                break;
                            }
                        }
                    }
                }

                if (TotalCoins < minR && !negVal)
                    minR = TotalCoins;

            }

            return minR;
        }

        static long TakeMoney(long currentBags, long k)
        {
            return currentBags % k;
        }
           
    }
}
