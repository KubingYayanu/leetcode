namespace LeetCode.Library.Easy
{
    public class Implement_strStrSolution
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Length == 0)
            {
                return -1;
            }
            if (needle.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    // avoid out of range
                    if (haystack.Length == i + j)
                    {
                        return -1;
                    }
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                    if (needle.Length - 1 == j)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}