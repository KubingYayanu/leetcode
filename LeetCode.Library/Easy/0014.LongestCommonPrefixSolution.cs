using System.Collections.Generic;

namespace LeetCode.Library.Easy
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var index = 0;
            char currentChar = char.MinValue;
            var stop = false;
            var array = new List<char>();
            while (!stop)
            {
                for (int i = 0; i < strs.Length; i++)
                {
                    var str = strs[i];
                    if (index < str.Length)
                    {
                        if (currentChar == char.MinValue)
                        {
                            currentChar = str[index];
                        }
                        else if (currentChar == str[index])
                        {
                            continue;
                        }
                        else
                        {
                            stop = true;
                            break;
                        }
                    }
                    else
                    {
                        stop = true;
                        break;
                    }
                }

                if (!stop)
                {
                    array.Add(currentChar);
                    currentChar = char.MinValue;
                    index++;
                }
            }

            var strArray = array.ToArray();
            return new string(strArray);
        }
    }
}