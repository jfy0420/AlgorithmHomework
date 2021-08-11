using System.Collections.Generic;
using System.Text;

namespace algorithmHomework{
    public static class LeetCode283{

        //如果遇到0，就和右边的交换
        public static void MoveZeroes(int[] nums) {
            
            int left=0;
            int temp=0;
            for(int right=0; right<nums.Length;right++)
            {
                if(nums[right]!=0)
                {
                    temp=nums[left];
                    nums[left]=nums[right];
                    nums[right]=temp;
                    left++;
                }
            }
        }

        //填充0：性能没有上一个方法好。
        public static void MoveZeroes1(int[] nums) {
            
            int insertPos=0;
            
            //for(int right=0; right<nums.Length;right++)
            foreach(int num in nums)//foreach的性能没有for loop好
            {
                if(num!=0)
                {
                    nums[insertPos++]=num;
                    //insertPos++;
                }
            }

            while(insertPos<nums.Length)
            {
                nums[insertPos++]=0;
            }
        }
    }
}