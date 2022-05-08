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
            var result = 0d;
            while (source > 0)
            {
                var remainder = source % 10;
                result = result * 10 + remainder;
                if (result >= int.MaxValue)
                {
                    return 0;
                }

                source /= 10;
            }

            return (int)result * sign;
        }
    }
}