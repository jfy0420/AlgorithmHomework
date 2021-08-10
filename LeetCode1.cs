using System.Collections.Generic;

namespace algorithmHomework{
    public static class LeetCode1{
        //key point: a=target-b
        public static int[] TwoSum(int[] nums, int target) {
            int[] result=new int[2];
            Dictionary<int, int> dicNums=new Dictionary<int, int>();
            for(int i= 0;i<nums.Length;i++)
            {
                if(dicNums.ContainsKey(nums[i]))
                {
                    result[1]=i;
                    result[0]=dicNums[nums[i]];
                    return result;
                    
                }
                dicNums.Add(target-nums[i],i);
            }
            return result;
        }
    }
}