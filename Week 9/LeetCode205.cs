using System.Collections.Generic;
using System;

namespace algorithmHomework{

    public class LeetCode205{
        public bool IsIsomorphic(string s, string t) {
            for(int i=0;i<s.Length;i++)
            {
                if(s.LastIndexOf(s[i])!=t.LastIndexOf(t[i]))
                    return false;
            }
            return true;
        }
    }
}