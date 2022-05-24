namespace LeetCode.Library.Easy
{
    public class Implement_strStrSolution
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                var same = true;
                var needlePointer = needle.Length - 1;
                for (int j = needlePointer; 0 <= j; j--)
                {
                    var haystackPointer = i + j;
                    if (haystackPointer > haystack.Length - 1)
                    {
                        return -1;
                    }

                    if (haystack[haystackPointer] != needle[j])
                    {
                        same = false;
                        break;
                    }
                }

                if (same)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}