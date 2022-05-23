namespace LeetCode.Library.Easy
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            var leftPointer = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[leftPointer] = nums[i];
                    leftPointer++;
                }
            }

            return leftPointer;
        }
    }
}