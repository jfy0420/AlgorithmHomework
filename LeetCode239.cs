using System.Collections.Generic;

public static class LeetCode239{
    //暴力求解法:在leetcode执行超时，程序是可以跑的。
    public static int[] maxSlidingWindow(int[] nums, int k) {
        int[] result=new int[nums.Length-k+1];
        for(int i=0;i<nums.Length-k+1;i++){
            int max=nums[i];
            for(int j=i;j<i+k;j++){
                if(max<nums[j])
                    max=nums[j];
            }
            result[i]=max;
        }
        

        return result;
    }

    //Method2: two array
    public static int[] MaxSlidingWindow2(int[] nums, int k) {
        int[] max_left = new int[nums.Length];
        int[] max_right = new int[nums.Length];

        max_left[0] = nums[0];
        max_right[nums.Length - 1] = nums[nums.Length - 1];

        for (int i = 1; i < nums.Length; i++) {
            max_left[i] = (i % k == 0) ? nums[i] : System.Math.Max(max_left[i - 1], nums[i]);

            int j = nums.Length - i - 1;
            max_right[j] = (j % k == 0) ? nums[j] : System.Math.Max(max_right[j + 1], nums[j]);
        }

        int[] result = new int[nums.Length - k + 1];
        for (int i = 0, j = 0; i + k <= nums.Length; i++) {
            result[j++] = System.Math.Max(max_right[i], max_left[i + k - 1]);
        }

        return result;
    }
}