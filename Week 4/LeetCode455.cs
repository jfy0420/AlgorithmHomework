using System;
using System.Collections.Generic;

namespace algorithmHomework{
    /*
    发饼干:总是满足最小的胃口
    */
    public class LeetCode455{
        public int FindContentChildren(int[] g, int[] s) {
            Array.Sort(g);
            Array.Sort(s);
            int gi=0,si=0;

            while(gi<g.Length&&si<s.Length){
                if(g[gi]<=s[si])
                {
                    gi++;
                }
                si++;
            }

            return gi;
        }   
    }
}