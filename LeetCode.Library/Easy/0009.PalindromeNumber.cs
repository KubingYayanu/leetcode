namespace LeetCode.Library.Easy
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            var num = x.ToString();
            var median = num.Length / 2;
            for (int i = 0; i < median; i++)
            {
                if (num[i] != num[num.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}