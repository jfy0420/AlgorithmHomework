using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
64. 最小路径和
*/
    public class LeetCode64{
        //2次二分查找
        public bool SearchMatrix(int[][] matrix, int target) {
            int rows=matrix.Length;
            int columns=matrix[0].Length;

            if(target<matrix[0][0] || target>matrix[rows-1][columns-1])
                return false;
            
            int l = 0;
            int r = rows - 1;
            while (l <= r) {
                int m = l + ((r - l) >> 1);
                if (target < matrix[m][0]) {
                    r = m - 1;
                } else if (target > matrix[m][0]) {
                    l = m + 1;
                } else if (target == matrix[m][0]) {
                    return true;
                }
		    }
            int row = l - 1;
            l = 0;
            r = columns - 1;
            while (l <= r) {
                int m = l + ((r - l) >> 1);
                if (target < matrix[row][m]) {
                    r = m - 1;
                } else if (target > matrix[row][m]) {
                    l = m + 1;
                } else if (target == matrix[row][m]) {
                    return true;
                }
		    }
		    return false;

        }

        //一次二分查找: 这个性能更好
        public bool SearchMatrix2(int[][] matrix, int target) {
            int rows=matrix.Length;
            int columns=matrix[0].Length;

            if(target<matrix[0][0] || target>matrix[rows-1][columns-1])
                return false;
            
            int l = 0;
            int r = rows*columns-1;
            int curRow, curCol;
            while (l <=r) {
                int m = (l + r - 1 )>> 1;
                curRow= m/columns;
                curCol=m-curRow*columns;
                if (target < matrix[curRow][curCol]) {
                    r = m - 1;
                } else if (target > matrix[curRow][curCol]) {
                    l = m + 1;
                } else if (target == matrix[curRow][curCol]) {
                    return true;
                }
		    }
            
		    return false;

        }
    }
}