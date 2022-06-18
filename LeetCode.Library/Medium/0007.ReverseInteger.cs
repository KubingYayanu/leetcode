namespace LeetCode.Library.Medium
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            var sign = 1;
            if (x < 0)
            {
                sign = -1;
            }

            var source = x * sign;
            var result = 0;
            while (source > 0)
            {
                if (result * sign > int.MaxValue / 10 || result * sign < int.MinValue / 10)
                {
                    return 0;
                }

                var remainder = source % 10;
                result = result * 10 + remainder;
                source /= 10;
            }

            return result * sign;
        }
    }
}