using System.Collections.Generic;

namespace algorithmHomework{
    /*
    组合：给定两个整数 n 和 k，返回范围 [1, n] 中所有可能的 k 个数的组合。
    */
    public class LeetCode77{
        public IList<IList<int>> Combine(int n, int k) 
            {
                IList<IList<int>> ans = new List<IList<int>>();
                Backtrack(k,n,1,new List<int>(),ans);
                return ans;
            }
    
        private void Backtrack(int k,int n, int st, List<int> li, IList<IList<int>> ans)
        {
            if(li.Count==k)
            {
                ans.Add(new List<int>(li));
                return;
            }
            
            for(int i=st;i<=n;i++)
            {
                li.Add(i);
                Backtrack(k,n,i+1,li,ans);
                li.RemoveAt(li.Count-1);
            }
        }
    }
}