using System.Collections.Generic;
using System;

namespace algorithmHomework{
    /*
    169. 多数元素
    */
    public class LeetCode169{
        public int MajorityElement(int[] nums) {
            Array.Sort(nums);
            return nums[nums.Length / 2];
            
        }

    }
}