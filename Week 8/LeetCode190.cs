using System;

namespace algorithmHomework{
/*
190.颠倒二进制位
*/
    public class LeetCode190{
            public uint ReverseBits(uint n) {
                uint result=0;

                for(int i=0;i<32;i++){
                    result += ((1&(n>>i))<<(31-i));
                }
                return result;
        }
        //这个性能更好
        public uint reverseBits2(uint n){
            if (n == 0) return 0;
    
            uint result = 0;
            for (int i = 0; i < 32; i++) {
                result <<= 1;
                if ((n & 1) == 1) result++;
                n >>= 1;
            }
            return result;
        }
    }
}