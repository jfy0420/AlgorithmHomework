using System;
using System.Collections.Generic;

namespace algorithmHomework{
    /*
    718:最长重复子数组
    */
    public class LeetCode718{
        //sliding window: this performance better
        public int FindLength(int[] nums1, int[] nums2) {
            return nums1.Length < nums2.Length ? findMax(nums1, nums2) : findMax(nums2, nums1);
        }

        int findMax(int[] A, int[] B) {
            int max = 0;
            int an = A.Length, bn = B.Length;
            for(int len=1; len <= an; len++) {
                max = Math.Max(max, maxLen(A, 0, B, bn - len, len));
            }
            for(int j=bn-an; j >= 0;j--) {
                max = Math.Max(max, maxLen(A, 0, B, j, an));
            }
            for(int i=1;i<an;i++) {
                max = Math.Max(max, maxLen(A, i, B, 0, an - i));
            }
            return max;
        }

        int maxLen(int[] a, int i, int[] b, int j, int len) {
            int count = 0, max = 0;
            for(int k = 0; k < len; k++) {
                if(a[i+k] == b[j+k]) {
                    count++;
                } else if(count > 0) {
                    max = Math.Max(max, count);
                    count = 0;
                }
            }
            return count > 0 ? Math.Max(max, count) : max;
        }

        //dynamic planning
        public int FindLength2(int[] nums1, int[] nums2) {
            int len1=nums1.Length;
            int len2=nums2.Length;
            int[,] dp=new int[len1+1,len2+1];
            int result=0;
            for(int i=1;i<=len1;i++)
            {
                for(int j=1;j<=len2;j++){
                    if(nums1[i-1]==nums2[j-1]){
                        dp[i,j]=dp[i-1,j-1]+1;
                        result=Math.Max(result,dp[i,j]);
                    }
                    else{
                        dp[i,j]=0;
                    }
                    
                }
            }
            return result;
        }

    }
}