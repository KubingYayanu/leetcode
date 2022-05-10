namespace LeetCode.Library.Hard
{
    public class RegularExpressionMatching
    {
        public bool IsMatch(string s, string p)
        {
            return IsMatch(s, 0, p, 0);
        }

        private bool IsMatch(string s, int si, string p, int pi)
        {
            // base case
            //// 1. success if full match
            if (pi >= p.Length && si >= s.Length)
            {
                return true;
            }

            //// 2. running out of pattern but still has strings means failure
            if (pi >= p.Length && si < s.Length)
            {
                return false;
            }

            // case A
            // running out of strings but still has patterns
            if (pi < p.Length && si >= s.Length)
            {
                // only possible case is to match a STAR pattern
                return pi < p.Length - 1 && p[pi + 1] == '*'
                                         && IsMatch(s, si, p, pi + 2);
            }

            // case B
            var thisMatch = p[pi] == '.' || s[si] == p[pi];

            //// 1. want to match STAR pattern
            if (pi < p.Length - 1 && p[pi + 1] == '*')
            {
                if (!thisMatch)
                {
                    // the STAR has to go
                    return IsMatch(s, si, p, pi + 2);
                }
                else
                {
                    ////// (a) choose to consume and remove STAR
                    ////// (b) choose to consume and keep the STAR
                    ////// (c) choose to ignore the STAR
                    ////// any success is success
                    return IsMatch(s, si + 1, p, pi + 2) ||
                           IsMatch(s, si + 1, p, pi) ||
                           IsMatch(s, si, p, pi + 2);
                }
            }

            //// 2. just match a single char
            return thisMatch && IsMatch(s, si + 1, p, pi + 1);
        }
    }
}