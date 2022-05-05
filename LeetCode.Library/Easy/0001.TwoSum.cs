using System;
using System.Collections.Generic;

namespace LeetCode.Library.Easy
{
    public class TwoSum
    {
        public int[] Run(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }

            throw new Exception("No two sum solution");
        }
    }
}