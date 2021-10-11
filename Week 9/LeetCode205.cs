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

        //效率更差
        public bool IsIsomorphic2(string s, string t) {
            return IsIsomorphicHelper(s,t)&&IsIsomorphicHelper(t,s);
        }
        private bool IsIsomorphicHelper(string s, string t){
        Dictionary<char,char> dic=new Dictionary<char, char>();
            int count=s.Length;
            for(int i=0;i<count;i++)
            {
                if(dic.ContainsKey(s[i]))
                {
                    if(dic[s[i]]!=t[i])
                        return false;
                }
                else
                {
                    dic.Add(s[i],t[i]);
                }
            }
        return true;
    }
    }
}