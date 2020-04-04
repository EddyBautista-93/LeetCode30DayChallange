using System;
using System.Diagnostics;

namespace LeetCode30DayChallenge
{

//Write an algorithm to determine if a number is "happy".

//A happy number is a number defined by the following process:
//Starting with any positive integer, replace the number by the
//sum of the squares of its digits, and repeat the process until
//the number equals 1 (where it will stay), or it loops endlessly
//in a cycle which does not include 1. Those numbers for which this
//process ends in 1 are happy numbers.

//Example: 

//Input: 19
//Output: true
//Explanation: 
//12 + 92 = 82
//82 + 22 = 68
//62 + 82 = 100
//12 + 02 + 02 = 1



    //Create a method tool for handling sqauring the numbers in use of the is happy method

    public class HappyNum
    {
        public HappyNum()
        {
        }

        public static int NumSquareSum(int n)
        {
            int squareSum = 0;
            while (n != 0)
            {
                squareSum += (n % 10) * (n % 10);
                n /= 10;
            }
            return squareSum;
        }




        public static bool IsHappy(int n)
        {

            if (n == 1 || n == 7)
                return true;
            int sum = n, x = n;

            // this loop executes till the sum of square of 
            // digits obtained is not a single digit number 
            while (sum > 9)
            {
                sum = 0;

                // this loop finds the sum of square of digits 
                while (x > 0)
                {
                    int d = x % 10;
                    sum += d * d;
                    x /= 10;
                }
                if (sum == 1)
                    return true;
                x = sum;
            }
            if (sum == 7)
                return true;
            return false;
        }




        static void Main(string[] args)
        {
            Console.WriteLine(NumSquareSum(19)); // makes 82
            int n = 13;
            if (IsHappy(n))
                Console.WriteLine(n +
              " is a Happy number");
       else
                Console.WriteLine(n +
              " is not a Happy number");
        }

    }
}
