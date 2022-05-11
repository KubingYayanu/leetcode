using System;

namespace LeetCode.Library.Medium
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var l = 0;
            var r = height.Length - 1;
            var maxArea = 0;
            while (l < r)
            {
                var area = Math.Min(height[l], height[r]) * (r - l);
                maxArea = Math.Max(maxArea, area);
                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return maxArea;
        }
    }
}