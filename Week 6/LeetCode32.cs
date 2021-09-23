using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
32. 最长有效括号
*/
    public class LeetCode32{
        //用stack
        public int LongestValidParentheses(string s) {
            Stack<int> stack=new Stack<int>();
            int max=0;
            stack.Push(-1);
            for(int i=0;i<s.Length;i++){
                if(s[i]=='('){
                    stack.Push(i);
                }
                else{
                    stack.Pop();
                    if(stack.Count==0){
                        stack.Push(i);
                    }
                    else{
                        max=Math.Max(max, i- stack.Peek());
                    }
                }
            }
            return max;

        }
    }
}