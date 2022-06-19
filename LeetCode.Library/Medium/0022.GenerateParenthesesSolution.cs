using System.Collections.Generic;

namespace LeetCode.Library.Medium
{
    public class GenerateParenthesesSolution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            GenerateAndCheck(result, "", 0, 0, n);
            return result;
        }

        private void GenerateAndCheck(List<string> result, string str, int opened, int closed, int max)
        {
            if (opened == closed && opened == max)
            {
                result.Add(str);
                return;
            }

            if (opened < max)
                GenerateAndCheck(result, str + "(", opened + 1, closed, max);
            if (closed < opened)
                GenerateAndCheck(result, str + ")", opened, closed + 1, max);
        }
    }
}