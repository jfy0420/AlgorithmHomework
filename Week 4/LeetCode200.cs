using System;
using System.Collections.Generic;

namespace algorithmHomework{
    /*
    岛屿数量
    */

    public class LeetCode200{
        public int NumIslands(char[][] grid) {
            int result=0;

            int row=grid.Length;
            int col=grid[0].Length;
            
            for(int i=0; i<row;i++)
                for(int j=0;j<col;j++){
                    if(grid[i][j]=='1'){
                        result++;
                        dfs(grid,i,j);//找附近相连的1，并mark成2
                    }
                }
            
            return result;
        }

        private void dfs(char[][] grid, int i, int j)
        {
            int c=grid[0].Length;
            int r=grid.Length;
            if(i>=r||j>=c||i<0||j<0||grid[i][j]!='1')
                return;
            
            grid[i][j]='2';

            dfs(grid,i-1,j);
            dfs(grid,i+1,j);
            dfs(grid,i,j-1);
            dfs(grid,i,j+1);
        }
    }
}