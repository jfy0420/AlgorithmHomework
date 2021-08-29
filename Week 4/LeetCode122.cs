using System.Collections.Generic;
using System;

namespace algorithmHomework{
    /*
    122. 买卖股票的最佳时机 II
    */

    public class LeetCode122{
        public int MaxProfit(int[] prices) {
            int result=0;
            if(prices.Length<0) return result;
            for(int i=1;i<prices.Length;i++)
            {
                result+=Math.Max(prices[i]-prices[i-1],0);
            }
            return result;
        }
    }
}