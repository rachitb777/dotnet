using System;

namespace searchInsertPos
{
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            int []nums = {1, 3};
            Console.WriteLine(sol.SearchInsert(nums, 0));
        }
    }

    public class Solution {
        public int SearchInsert(int[] nums, int target) 
        {
            int start = 0;
            int end = nums.Length - 1;
            var pos = -1;
            while(start < end)
            {
                int mid = (end + start) / 2;
                if (nums[mid] == target)
                {
                    pos = mid;
                    break;
                }
                else if (nums[mid] < target) 
                {
                    start = mid + 1;
                }
                else 
                {
                    end = mid - 1;
                }
            }
            if (start >= end)
            {
                if (target <= nums[start])
                {
                    pos = start;
                }
                else
                {
                    pos = start + 1;
                }
            }

            return pos;
        }
    }
}
