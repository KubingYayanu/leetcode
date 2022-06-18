namespace LeetCode.Library.Medium
{
    public class StringToIntegerAtoi
    {
        public int MyAtoi(string s)
        {
            var temp = s.Trim();
            if (temp.Length == 0)
            {
                return 0;
            }

            var hasSign = temp[0] == '+' || temp[0] == '-';
            var sign = 1;
            if (temp[0] == '-')
            {
                sign = -1;
            }

            var result = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                var digit = temp[i];
                if (i == 0 && hasSign)
                {
                    continue;
                }

                if (char.IsNumber(digit))
                {
                    var value = (int)char.GetNumericValue(digit);
                    if (result * sign > (int.MaxValue - value) / 10)
                    {
                        return int.MaxValue;
                    }
                    else if (result * sign < (int.MinValue + value) / 10)
                    {
                        return int.MinValue;
                    }

                    result = result * 10 + value;
                }
                else
                {
                    break;
                }
            }

            return result * sign;
        }
    }
}