using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
231. 2的幂
*/
    public class LeetCode231{

        //只有一个1
        public bool IsPowerOfTwo(int n) {
            return n>0 && (n&(n-1))==0;
        } 
    }
}