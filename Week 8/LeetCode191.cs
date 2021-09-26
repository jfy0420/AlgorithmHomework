using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
191.位1的个数
*/
    public class LeetCode191{

        //1. for loop
        //2.%2
        //3. &1, n>>1
        //4. x&(x-1)
        public int HammingWeight(uint n) {
            int count=0;
            while(n>0){
                count++;
                n=n&(n-1);
            }
            return count;
        }   
    }
}