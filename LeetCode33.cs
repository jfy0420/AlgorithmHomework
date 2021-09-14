using System.Collections.Generic;

namespace algorithmHomework{
    /*33. 搜索旋转排序数组
    */
    public class LeetCode33{
        public int Search(int[] nums, int target) {
            int l=0, r=nums.Length-1, mid=0;
            while(l<=r){
                mid=l+(r-l)/2;
                if(nums[mid]==target)
                    return mid;
                
                //判断在左段还是右段
                if(nums[mid]>=nums[l]){
                    if(target>=nums[l]&&target<nums[mid]){
                        r=mid-1;
                    }
                    else{
                        l=mid+1;
                    }
                }else{
                    if(target>nums[mid]&&target<=nums[r])
                    {
                        l=mid+1;
                    }
                    else{
                        r=mid-1;
                    }
                    
                }
            }
            return -1;
        }

        //TODO: I can't understand        
        public int Search2(int[] nums, int target) {
            int lo = 0, hi = nums.Length;
            while (lo < hi) {
                int mid = (lo + hi) / 2;
                
                double num = (nums[mid] < nums[0]) == (target < nums[0])
                        ? nums[mid]
                        : target < nums[0] ? -int.MaxValue : int.MaxValue;
                        
                if (num < target)
                    lo = mid + 1;
                else if (num > target)
                    hi = mid;
                else
                    return mid;
            }
            return -1;
        }
        
    }
}
