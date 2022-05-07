using System;

namespace LeetCode.Library.Hard
{
    /// <summary>
    /// https://www.youtube.com/watch?v=q6IEA26hvXc
    /// </summary>
    public class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var totalSize = nums1.Length + nums2.Length;
            var halfSize = totalSize / 2;
            int[] aArray, bArray;
            if (nums1.Length > nums2.Length)
            {
                aArray = nums2;
                bArray = nums1;
            }
            else
            {
                aArray = nums1;
                bArray = nums2;
            }

            var leftPointer = 0;
            var rightPointer = aArray.Length - 1;
            while (true)
            {
                var aPartitionIndex = (int)Math.Floor((double)(leftPointer + rightPointer) / 2);
                var bPartitionIndex = halfSize - aPartitionIndex - 2;

                var aLeftValue = aPartitionIndex >= 0
                    ? aArray[aPartitionIndex] : double.NegativeInfinity;
                var aRightValue = aPartitionIndex + 1 < aArray.Length
                    ? aArray[aPartitionIndex + 1] : double.PositiveInfinity;
                var bLeftValue = bPartitionIndex >= 0
                    ? bArray[bPartitionIndex] : double.NegativeInfinity;
                var bRightValue = bPartitionIndex + 1 < bArray.Length
                    ? bArray[bPartitionIndex + 1] : double.PositiveInfinity;

                var isMedian = aLeftValue <= bRightValue
                    && bLeftValue <= aRightValue;
                if (isMedian)
                {
                    if (totalSize % 2 == 0)
                    {
                        return (Math.Max(aLeftValue, bLeftValue) + Math.Min(aRightValue, bRightValue)) / 2;
                    }
                    else
                    {
                        return Math.Min(aRightValue, bRightValue);
                    }
                }
                else if (aLeftValue > bRightValue)
                {
                    rightPointer = aPartitionIndex - 1;
                }
                else
                {
                    leftPointer = aPartitionIndex + 1;
                }
            }
        }
    }
}