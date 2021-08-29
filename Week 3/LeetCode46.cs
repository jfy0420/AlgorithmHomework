using System.Collections.Generic;
using System.Linq;

namespace algorithmHomework{
    /*
        全排列：给定一个不含重复数字的数组 nums ，返回其 所有可能的全排列 。你可以 按任意顺序 返回答案。
    */
    public class LeetCode46{
         public IList<IList<int>> Permute(int[] nums) {
             IList<IList<int>> ans = new List<IList<int>>();
            PermuteHelper(nums.ToList(), new List<int>(), ans);
            return ans;
        }

        public void PermuteHelper(List<int> nums, List<int> choose, IList<IList<int>> result){
            if(nums.Count == 0){
                result.Add(choose.ToArray());
            }
            else{
                for(int index = 0; index < nums.Count; index++){
                    //Choose
                    int num = nums[index];
                    nums.RemoveAt(index);
                    choose.Add(num);

                    //Explore
                    PermuteHelper(nums, choose, result);

                    //Unchoose
                    choose.Remove(num);
                    nums.Insert(index, num);
                }
            }
        }
    }
}