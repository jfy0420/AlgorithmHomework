using System.Collections.Generic;

namespace algorithmHomework{
    /*
    写一个程序，输出从 1 到 n 数字的字符串表示。

    1. 如果 n 是3的倍数，输出“Fizz”；

    2. 如果 n 是5的倍数，输出“Buzz”；

    3.如果 n 同时是3和5的倍数，输出 “FizzBuzz”。

    */
    public class LeetCode412{
        
        public IList<string> FizzBuzz(int n) {
            List<string> result=new List<string>();
            for(int i=0;i<n;i++)
            {
                string item="";
                if(i%3==0)
                    item="Fizz";
                
                if(i%5==0)
                    item+="Buzz";
               
                if(item=="")
                    item=i.ToString();
                result.Add(item);
            }
            return result;
        }
    }
}