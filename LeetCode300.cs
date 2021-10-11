using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
300. 最长递增子序列
*/
    public class LeetCode300{
        //1. 动态规划
        public int LengthOfLIS(int[] nums) {
            int len=nums.Length;
            int[] dp=new int[nums.Length];
            int result=0;
            Array.Fill(dp,1);
            for(int i=0;i<len;i++){
                for(int j=0;j<i;j++){
                    if(nums[i]>nums[j]){
                        dp[i]=Math.Max(dp[i],dp[j]+1);
                    }
                }
                result=Math.Max(result,dp[i]);
            }
            return result;
        }

        //2.用辅助array
        public int LengthOfLIS1(int[] nums){
            int n = nums.Length;
            if (n <= 1) {
                return n;
            }

            // 表示arr数组实际的大小
            int size = 1;
            // 一个数组
            int[] arr = new int[n];
            // 初始化第0个元素
            arr[0] = nums[0];

            // 遍历nums中所有元素
            for (int i = 1; i < n; i++) {
                // 如果比arr最后一个元素大，直接在后面累加
                if (nums[i] > arr[size - 1]) {
                    arr[size++] = nums[i];
                } else {
                    // 否则的话，在arr中寻找它应该在的位置
                    // 即在arr中寻找大于等于它的元素的位置
                    int right = size - 1;
                    // 从后向前遍历找到这个位置
                    while (right >= 0 && arr[right] >= nums[i]) {
                        right--;
                    }
        
                    // 上面多减了一次，要补回来
                    arr[right + 1] = nums[i];
                }
            }	

            return size;
        }
    }
}