namespace LeetCode.Library.Medium
{
    public class SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            var low = 0;
            var high = nums.Length - 1;
            while (low <= high)
            {
                var mid = (low + high) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < nums[high])
                {
                    if (target > nums[mid] && target <= nums[high])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
                else
                {
                    if (target >= nums[low] && target < nums[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
            }

            return -1;
        }
    }
}