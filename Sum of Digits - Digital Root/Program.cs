using System;

namespace Sum_of_Digits___Digital_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            #region InputNumbers
            Console.WriteLine(DigitalRoot(4));
            Console.WriteLine(DigitalRoot(15));
            Console.WriteLine(DigitalRoot(9989));
            Console.WriteLine(DigitalRoot(37));
            Console.WriteLine(DigitalRoot(687));
            Console.WriteLine(DigitalRoot(99));
            #endregion


            int DigitalRoot(long n)
            {
                long sum = 0;
                long fin = 0;
                long temp;
                while (n>0)
                {
                    temp = n % 10;
                    sum += temp;
                    n /= 10;
                }
                while (sum > 9)
                {
                    fin = DigitalRoot(sum);
                    return (int)fin;
                }
                return (int)sum;
            }
        }
    }
}
