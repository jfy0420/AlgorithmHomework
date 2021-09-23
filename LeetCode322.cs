using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
322. 零钱兑换
*/
    public class LeetCode322{
        public int CoinChange(int[] coins, int amount) {
            int max=int.MaxValue;
            int[] dp=new int[amount+1];
            Array.Fill(dp,max);//需要给这个dp array赋值先
            dp[0]=0;
            for(int i=1;i<=amount;i++)
                foreach(var c in coins){
                    if(c<=i && dp[i-c]!=max)
                        dp[i]=Math.Min(dp[i-c]+1, dp[i]);
                }
            return dp[amount]== max? -1:dp[amount];
        }

        //这个速度快些
        public int CoinChange2(int[] coins, int amount) {
            int max=int.MaxValue;
            int[] dp=new int[amount+1];
            Array.Fill(dp,max);//需要给这个dp array赋值先
            dp[0]=0;
            
            foreach(var c in coins)
                for(int i=c;i<=amount;i++){
                    if(dp[i-c]!=max)
                        dp[i]=Math.Min(dp[i-c]+1, dp[i]);
                }
            return dp[amount]== max? -1:dp[amount];
        }
    }
}