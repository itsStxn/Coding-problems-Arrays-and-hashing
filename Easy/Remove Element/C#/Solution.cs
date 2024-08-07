namespace Remove_Element;


public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        foreach (int n in nums) {
            if (n != val) nums[k++] = n;
        }

        return k;
    }
}
