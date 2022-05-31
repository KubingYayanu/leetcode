namespace LeetCode.Library.Medium
{
    public class FindFirstAndLastPositionOfElementInSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var result = new int[] { -1, -1 };
            if (nums.Length == 0)
            {
                return result;
            }

            var left = 0;
            var right = nums.Length - 1;
            while (left < right)
            {
                var mid = (left + right) / 2;
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            if (nums[left] != target)
            {
                return result;
            }
            result[0] = left;

            right = nums.Length - 1;
            while (left < right)
            {
                // Make mid biased to the right
                // So that this won't make the search range stuck.
                var mid = (left + right) / 2 + 1;
                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid;
                }
            }

            result[1] = right;
            return result;
        }
    }
}