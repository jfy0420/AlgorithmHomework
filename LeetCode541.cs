using System;
using System.Collections.Generic;

namespace algorithmHomework{
    public class LeetCode541{
        public string ReverseStr(string s, int k) {
            int strLen = s.Length;
            char[] arr = s.ToCharArray();
            for (int i = 0; i < strLen; i += 2 * k) {
                Reverse(arr, i, Math.Min(i + k, strLen) - 1);
            }
            return new string(arr);

        }
        public void Reverse(char[] arr, int left, int right) {
            while (left < right) {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
    }
}