namespace Contains_Duplicate;


public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = [];
        foreach (int num in nums)
            if (!set.Add(num)) return true;

        return false;
    }
}
