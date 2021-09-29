using System;
using System.Collections.Generic;

namespace algorithmHomework{
    public class LeetCode363{

        public int MaxSumSubmatrix(int[][] matrix, int k) {

            int ans = int.MinValue;
            int m = matrix.Length, n = matrix[0].Length;
            for (int i = 0; i < m; ++i)// 枚举上边界
            {
                int[] sum = new int[n];
                for (int j = i; j < m; ++j) // 枚举下边界
                {
                    for (int c = 0; c < n; ++c)
                    {
                        sum[c] += matrix[j][c]; // 更新每列的元素和
                    }
                    SortedSet<int> sumSet = new SortedSet<int>();
                    sumSet.Add(0);
                    int s = 0;
                    foreach (var v in sum)
                    {
                        s += v;//通过前缀和计算 right
                        int another = s - k;
                        int ceil = FindCeilInSet(sumSet, another);
                        if (ceil != int.MinValue)
                        {
                            ans = Math.Max(ans, (int)(s - ceil));
                            //Console.WriteLine(ans);
                        }
                        sumSet.Add(s);
                    }
                }
            }
            return ans;
        }

        public int FindCeilInSet(SortedSet<int> set, int tar)
            {
                if (tar > set.Max)
                    return int.MinValue;

                foreach (var item in set)
                {
                    if (item >= tar)
                    {
                        return item;
                    }
                }

                return int.MinValue;
            }
    }
}