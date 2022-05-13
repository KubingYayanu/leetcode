using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Library.Medium
{
    public class ThreeSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            // origin: -3, 3, 4, -3, 1, 2
            // sorted: -3, -3, 1, 2, 3, 4
            var source = nums.OrderBy(x => x).ToList();
            for (int i = 0; i < source.Count; i++)
            {
                var target = source[i];
                // 如果跟前一個數字一樣, 表示有重複的組合
                if (i > 0 && target == source[i - 1])
                {
                    continue;
                }

                var leftPointer = i + 1;
                var rightPointer = source.Count - 1;
                while (leftPointer < rightPointer)
                {
                    var threeSum = target + source[leftPointer] + source[rightPointer];
                    if (threeSum > 0)
                    {
                        rightPointer--;
                    }
                    else if (threeSum < 0)
                    {
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(new List<int> { target, source[leftPointer], source[rightPointer] });
                        leftPointer++;
                        while (source[leftPointer] == source[leftPointer - 1] && leftPointer < rightPointer)
                        {
                            leftPointer++;
                        }
                    }
                }
            }
            return result;
        }
    }
}