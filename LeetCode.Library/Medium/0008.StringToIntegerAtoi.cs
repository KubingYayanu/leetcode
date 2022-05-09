namespace LeetCode.Library.Medium
{
    public class StringToIntegerAtoi
    {
        public int MyAtoi(string s)
        {
            var source = s.Trim();
            if (source.Length == 0)
            {
                return 0;
            }

            var result = 0d;
            var sign = 1;
            for (int i = 0; i < source.Length; i++)
            {
                var digit = source[i];
                var isSingned = digit == '-' || digit == '+';
                if (i != 0 && isSingned)
                {
                    break;
                }

                if (digit == '-')
                {
                    sign = -1;
                }

                if (char.IsNumber(digit))
                {
                    result = result * 10 + (int)char.GetNumericValue(digit);
                }
                else if (i == 0 && isSingned)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            result *= sign;
            if (result > int.MaxValue)
            {
                return int.MaxValue;
            }
            else if (result < int.MinValue)
            {
                return int.MinValue;
            }

            return (int)result;
        }
    }
}