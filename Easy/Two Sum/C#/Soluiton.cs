namespace Two_Sum;


public class Solution {
    public int[] TwoSum(int[] nums, int target) {        
        Dictionary<int, int> tb = [];
        for (int i = 0; i < nums.Length; i++) {
            if (tb.TryGetValue(nums[i], out int val)) {
                return [val, i];
            }
            tb[target - nums[i]] = i;
        }
        
        return default;
    }
}
