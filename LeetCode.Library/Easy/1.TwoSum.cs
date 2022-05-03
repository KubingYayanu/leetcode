using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Library.Easy
{
    public class TwoSum
    {
        public int[] Run(int[] nums, int target)
        {
            var map = new Dictionary<int, int[]>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    var current = nums[i];
                    var next = nums[j];
                    var sum = current + next;
                    if (i == j)
                    {
                        continue;
                    }

                    if (map.ContainsKey(sum))
                    {
                        continue;
                    }

                    map.Add(sum, new int[2] { i, j });
                }
            }

            var result = map.First(x => x.Key == target).Value;
            return result;
        }
    }
}