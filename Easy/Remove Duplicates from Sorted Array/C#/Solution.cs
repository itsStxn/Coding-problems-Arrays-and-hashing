namespace Remove_Duplicates_from_Sorted_Array;


public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 1) return 1;
        
        int uniqueIndex = 1;
        for (int current = 1; current < nums.Length; current++) {
            if (nums[current] != nums[current - 1]) {
                nums[uniqueIndex] = nums[current];
                if (nums[uniqueIndex++] == nums[^1]) break;
            }
        }

        return uniqueIndex;
    }
}
