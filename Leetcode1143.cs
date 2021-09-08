using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
最长公共子序列: Dynamic Planning
*/
    public class LeetCode1143{
        public int LongestCommonSubsequence(string text1, string text2) {
            int t1=text1.Length;
            int t2=text2.Length;
            int[,] dp = new int[t1 + 1, t2 + 1];

            for(int i=1;i<t1;i++)
                for(int j=1;j<t2;j++){
                    if(text1[i]==text2[j]){
                        dp[i,j]=dp[i-1,j-1]+1;
                    }
                    else{
                        dp[i,j]=Math.Max(dp[i-1,j],dp[i,j-1]);
                    }
                }

            return dp[t1,t2];
        }
    }
}