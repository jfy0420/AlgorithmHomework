using System;
using System.Collections.Generic;

namespace algorithmHomework{
    public class LeetCode387{
        public int FirstUniqChar(string s) {
            for(int i=0;i<s.Length;i++){
                if(s.IndexOf(s[i])==s.LastIndexOf(s[i]))
                    return i;
            }
            return -1;

        }

         public int FirstUniqChar2(string s) {
            int[] coll=new int[26];
            for(int i=0;i<s.Length;i++){
                coll[s[i]-'a']++;
            }

            for(int i=0;i<s.Length;i++)
            {
                if(coll[s[i]-'a']==1)
                    return i;
            }
            return -1;

        }
    }
}