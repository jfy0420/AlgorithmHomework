using System.Collections.Generic;
using System.Text;

namespace algorithmHomework{
    public static class LeetCode1021{
        //method 1: use stack
        public static string RemoveOuterParentheses(string s) {
            StringBuilder result=new StringBuilder();
            Stack<int> temp=new Stack<int>();
            //int i=0;
            //foreach(var c in s)
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]=='('){
                    temp.Push(i);
                }
                else
                {
                    int start = temp.Peek();
                    temp.Pop();
                    if(temp.Count==0)
                        result.Append(s.Substring(start+1, i-start-1));
                }
            }
            return result.ToString();
        }

        //method2: from leetcode
        public static string RemoveOuterParentheses2(string s) {
            StringBuilder result=new StringBuilder();
            int openCount=0;
            foreach(char c in s)
            {
                if(c =='(' && openCount++ > 0)
                    result.Append(c);
                if(c==')' && openCount-- > 1)    
                    result.Append(c);
            }
            return result.ToString();
        }
    }
}