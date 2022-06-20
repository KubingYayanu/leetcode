using System.Collections.Generic;

namespace LeetCode.Library.Medium
{
    public class FindFirstAndLastPositionOfElementInSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var map = new HashSet<int>();
            var left = -1;
            var right = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (target == nums[i] && map.Add(nums[i]))
                {
                    left = i;
                    right = i;
                }
                else if (target == nums[i] && !map.Add(nums[i]))
                {
                    right = i;
                }
            }

            return new int[] { left, right };
        }
    }
}