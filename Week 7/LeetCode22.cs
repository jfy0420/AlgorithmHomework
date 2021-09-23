using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
22. 括号生成
*/
    public class LeetCode22{
        private IList<string> result;
        public IList<string> GenerateParenthesis(int n) {
            result=new List<string>();
            Generate(0,0,n,"");
            return result;
        }

        private void Generate(int left, int right, int n, string s)
        {
            //terminator
            if(left==n&&right==n){
                result.Add(s);
                return;
            }
            //process

            //drill down
            if(left<n)
                Generate(left+1,right,n,s+"(");
            if(right<n&&right<left){
                Generate(left,right+1, n, s+")");
            }
            //restore
        }
    }
}