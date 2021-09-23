using System;
using System.Collections.Generic;

namespace algorithmHomework{
    /*有效平方数：
    给定一个 正整数 num ，编写一个函数，如果 num 是一个完全平方数，则返回 true ，否则返回 false 。

    进阶：不要 使用任何内置的库函数，如  sqrt 。
    */
    public class LeetCode367 {

        //Binary search
        public bool IsPerfectSquare(int num) {
            if (num == 1) {
                return true;
            }

        long left=2, right=num/2, guess, x;
        while(left<=right){
            x=left+(right-left)/2;
            guess=x*x;
            if(guess==num)
                return true;
            
                if(guess>num)
                    right=x-1;
                else
                    left=left+1;
        }

        return false;
        }

        //牛顿法f(x)=x*x−num=0 的根
        public bool IsPerfectSquare2(int num) {
            if (num == 1) return true;

            long x = num / 2;
            while (x * x > num) {
                x = (x + num / x) / 2;
            }
            return (x * x == num);

        }

        public bool IsPerfectSquare3(int num) {
            int num1 = 1;
            while(num > 0) 
            {
                num -= num1;
                num1 += 2;
            }
            return num == 0;
    }
    }
}