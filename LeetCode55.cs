using System;
using System.Collections.Generic;

namespace algorithmHomework{

    /*
    跳跃服务
    */
    public class LeetCode55{
        public bool CanJump(int[] nums) {
            int rightMost=0;
            int length=nums.Length;

            for(int i=0;i<length;i++)
            {
                if(rightMost>=i){
                    rightMost=Math.Max(rightMost, i+nums[i]);
                
                    if(rightMost>=length-1)
                        return true;
                }
            }

            return false;
        }
    }
}