using System;
namespace LeetCode30DayChallenge
{
    public class SingleNumber
    {
        public static int SingleNumberDayOne(int[] nums)
        {
            int x = 0;
            foreach (int num in nums)
            {
                x ^= num;
            }

            return x;
        }
        //static void Main(string[] args)
        //{
        //    int[] dayOne = new int[] { 2, 2, 1 };
        //    Console.WriteLine(SingleNumberDayOne(dayOne));
        //}
    }
}
