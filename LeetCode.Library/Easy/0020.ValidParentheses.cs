using System.Collections.Generic;

namespace LeetCode.Library.Easy
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length == 0)
            {
                return false;
            }

            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else if (stack.Count != 0)
                {
                    if ((s[i] == ')' && stack.Peek() == '(')
                        || (s[i] == '}' && stack.Peek() == '{')
                        || (s[i] == ']' && stack.Peek() == '['))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (stack.Count != 0)
            {
                return false;
            }

            return true;
        }
    }
}