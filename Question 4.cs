using System;
namespace HomeWork9
{
    public class Solution4
    {
        private int SumOfSquares(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit * digit;
                num /= 10;
            }

            return sum;
        }
        public bool IsHappy(int n)
        {
            int first = SumOfSquares(n);
            int last = SumOfSquares(SumOfSquares(n));

            while (first != last)
            {
                if (last == 1)
                {
                    return true;
                }

                first = SumOfSquares(first);
                last = SumOfSquares(SumOfSquares(last));
            }

            return last == 1;
        }
    }


}

