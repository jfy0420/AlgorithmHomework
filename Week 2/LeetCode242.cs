using System.Collections.Generic;

namespace algorithmHomework{
    /*
    有效的字母异位词：给定两个字符串 s 和 t ，编写一个函数来判断 t 是否是 s 的字母异位词。
    */
    public static class LeetCode242{
        //方法一：字母排序: c#没有实现Array.equal()的方法:这个效率低
        public bool IsAnagram(string s, string t) {
            if(s.Length!=t.Length)
                return false;

            char[] tempS=s.ToCharArray();
            char[] tempT=t.ToCharArray();
            Array.Sort(tempS);
            Array.Sort(tempT);
            //return Array.// override object.Equals
            for(int i=0;i<tempS.Length;i++)
            {
                if(tempS[i]!=tempT[i])
                {
                    return false;
                }
            }
            return true;
        }

        //方法二：使用hash表，将26个字母作为hash key，S的字母+1，t的字母-1，如果数字出现负数，则return false
        public bool IsAnagram2(string s, string t) {
            if(s.Length!=t.Length)
                return false;
        
            char[] hsS=new char[26]();
            for(int i=0;i<s.Length;i++)
            {
                hsS[s[i]-'a']++;
            }
            for(int i=0;i<t.Length;i++)
            {
                if(--hsS[t[i]-'a']<0)
                    return false;
            }
            return true;
        }
    }
}