using System;

namespace LeetCode.Library.Medium
{
    public class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 1)
            {
                return dividend;
            }
            else if (divisor == -1 && dividend == int.MinValue)
            {
                return int.MaxValue;
            }
            else if (dividend == divisor)
            {
                return 1;
            }
            else if (dividend == 0 || divisor == int.MinValue)
            {
                return 0;
            }

            var result = 0;
            // 避免取 abs 之後 overflow
            if (dividend == int.MinValue)
            {
                if (divisor < 0)
                {
                    dividend -= divisor;
                }
                else
                {
                    dividend += divisor;
                }
                result++;
            }

            var isNegative = (dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0);
            var absDividend = Math.Abs(dividend);
            var absDivisor = Math.Abs(divisor);
            while (absDividend >= absDivisor)
            {
                var temp = absDivisor;
                var count = 1;
                // temp << 1 > 0, 避免 temp << 1 overflow
                while (temp << 1 <= absDividend && temp << 1 > 0)
                {
                    temp <<= 1;
                    count <<= 1;
                }

                // dividend - (divisor * 2^count) > 0
                result += count;
                absDividend -= temp;
            }

            // ~-result + 1 取代 -1 * result
            return isNegative ? ~result + 1 : result;
        }
    }
}