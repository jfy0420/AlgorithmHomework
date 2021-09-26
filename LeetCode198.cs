using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
198. 打家劫舍
*/
    public class LeetCode198{
        public int Rob(int[] nums) {
            int pre=0, curr=0;
            for(int i=0;i<nums.Length;i++)
            {
                int temp=Math.Max(curr, pre+nums[i]);
                pre=curr;
                curr=temp;

            }
            return curr;
        }
    }
}