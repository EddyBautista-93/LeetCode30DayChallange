using System;
namespace LeetCode30DayChallenge
{
    public class HappyNum
    {
        public HappyNum()
        {
        }
        public static bool IsHappy(int n)
        {
            int firstDigit = n / 10;
            int secondDigit = n % 10;
            Console.WriteLine("{0} -- {1}", firstDigit, secondDigit);

            return true;
        }
        static void Main(string[] args)
        {
            IsHappy(10);
            
        }

    }
}
