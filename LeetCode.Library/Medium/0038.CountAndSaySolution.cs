namespace LeetCode.Library.Medium
{
    public class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            if (n == 1)
            {
                return "1";
            }

            var result = "";
            var count = 0;
            var charactor = char.MinValue;
            var array = CountAndSay(n - 1).ToCharArray();
            foreach (var c in array)
            {
                if (charactor == char.MinValue)
                {
                    charactor = c;
                    count = 1;
                }
                else if (charactor != c)
                {
                    result += $"{count}{charactor}";
                    charactor = c;
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            result += $"{count}{charactor}";

            return result;
        }
    }
}