using System.Collections.Generic;

namespace algorithmHomework{
    //题目：各位相加
    //这思路真是太厉害了，O（1）的复杂度，没有循环和递归
    public class LeetCode258{
        public int AddDigits(int num) {
            return (num-1) % 9 + 1;
        }

    }
}