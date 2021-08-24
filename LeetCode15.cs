using System;
using System.Collections.Generic;

namespace algorithmHomework{
    /*
        三数之和
    */
    public class LeetCode15{
        public IList<IList<int>> ThreeSum(int[] nums) {
            IList<IList<int>> ans=new List<IList<int>>();

            if(nums.Length<3)
                return ans;
            Array.Sort(nums);
            for(int i=0;i<nums.Length-1;i++)
            {
                if(nums[i] > 0) break;
                if(i>0 && nums[i]==nums[i-1]) continue; //去重

                int left=i+1;
                int right=nums.Length-1;
                while(left<right){
                    int count=nums[i]+nums[left]+nums[right];
                    if(count<0)
                    {
                        left++;
                    }
                    else if(count>0)
                    {
                        right--;
                    }
                    else
                    {
                        ans.Add(new List<int>{nums[i], nums[left],nums[right]});
                        while(left<right &&nums[left]==nums[left+1]) left++;//去重
                        while(left<right &&nums[right]==nums[right-1]) right--;//去重
                    }
                }
            }

            return ans;
        }
    }
}