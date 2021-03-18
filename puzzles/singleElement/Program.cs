using System;

namespace singleElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution obj = new Solution();
            int []nums1 = {3,3,7,7,10,11,11};
            int []nums2 = {1,1,2,3,3,4,4,8,8};
            int []nums3 = {1,1,2,2,3};
            Console.WriteLine(obj.SingleNonDuplicate2(nums3));
        }
    }

    public class Solution 
    {
        // O(n) solution
        public int SingleNonDuplicate(int[] nums) 
        {
            int returnVal = -1;
            for (int i = 0; i < nums.Length - 1; i+=2)
            {
                if (nums[i] != nums[i+1])
                {
                    returnVal = nums[i];
                    break;
                }
            }
            return returnVal;
        }


        // O(log(n)) solution
        public int SingleNonDuplicate2(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start < end)
            {
                int mid = (start + end) / 2;
                bool isOdd = ((mid - start) % 2) == 1;
                if (nums[mid - 1] == nums[mid])
                {
                    if (isOdd)
                        start = mid + 1;
                    else
                        end = mid;
                }
                else if (nums[mid + 1] == nums[mid])
                {
                    if (isOdd)
                        end = mid - 1;
                    else
                        start = mid;                        
                }
                else 
                {
                    return(nums[mid]);
                }
            }
            return nums[start];
        }
    }
}
