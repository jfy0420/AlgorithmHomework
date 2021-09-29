using System;
using System.Collections.Generic;

namespace algorithmHomework{
    /*
    剑指 Offer 59 - I. 滑动窗口的最大值
    */
    public class LeetCode59{
        public int[] MaxSlidingWindow(int[] nums, int k) {
            // 窗口个数
        int[] res = new int[nums.Length - k + 1];
        LinkedList<int> queue = new LinkedList<int>();

        // 遍历数组中元素，right表示滑动窗口右边界
        for(int right = 0; right < nums.Length; right++) {
            // 如果队列不为空且当前考察元素大于等于队尾元素，则将队尾元素移除。
            // 直到，队列为空或当前考察元素小于新的队尾元素
            while (queue.Count!=0 && nums[right] >= nums[queue.Last.Value]) {
                queue.RemoveLast();
            }

            // 存储元素下标
            queue.AddLast(right);

            // 计算窗口左侧边界
            int left = right - k +1;
            // 当队首元素的下标小于滑动窗口左侧边界left时
            // 表示队首元素已经不再滑动窗口内，因此将其从队首移除
            if (queue.First.Value< left) {
                queue.RemoveFirst();
            }

            // 由于数组下标从0开始，因此当窗口右边界right+1大于等于窗口大小k时
            // 意味着窗口形成。此时，队首元素就是该窗口内的最大值
            if (right +1 >= k) {
                res[left] = nums[queue.First.Value];
            }
        }
        return res;
        }
    }
}