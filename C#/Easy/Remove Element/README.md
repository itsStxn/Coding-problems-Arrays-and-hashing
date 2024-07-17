# Remove Element

## Description
Given an integer array `nums` and an integer `val`, remove all occurrences of `val` in `nums` **in-place**. *The order of the elements may be changed*. Then return the number of elements in `nums` which are **not equal** to `val`.

Consider the number of elements in `nums` which are not equal to `val` be `k`, to get accepted, you need to do the following things:

1. Change the array `nums` such that the first `k` elements of `nums` contain the elements which are not equal to `val`. 
2. The remaining elements of `nums` are not important as well as the size of `nums`.
Return `k`.

### Custom Judge:
**The judge will test your solution with the following code:**

int[] `nums` = [...]; *// Input array*  
int `val` = ...; *// value to remove*  
int[] expected`nums` = [...]; *// The expected answer with correct length.*  
&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;*// It is sorted with no values equaling* `val`.

int `k` = removeElement(`nums`, `val`); *// Calls your implementation*

assert `k` == expected`nums.length`;
sort(`nums`, 0, `k`); *// Sort the first* `k` *elements of* `nums`
for (int i = 0; i < actualLength; i++) {
    assert `nums`[i] == expected`nums`[i];
}
**If all assertions pass, then your solution will be accepted.**

### Example 1:
***Input:*** `nums` = [3,2,2,3], `val` = 3  
***Output:*** 2, `nums` = [2,2,_,_]  
***Explanation:*** 
- Your function should return `k` = 2, with the first two elements of `nums` being 2.
- It does not matter what you leave beyond the returned `k` (hence they are underscores).

### Example 2:
***Input:*** `nums` = [0,1,2,2,3,0,4,2], `val` = 2  
***Output:*** 5, `nums` = [0,1,4,0,3,_,_,_]  
***Explanation:*** 
- Your function should return `k` = 5, with the first five elements of `nums` containing 0, 0, 1, 3, and 4.  
*Note that the five elements can be returned in any order.*
- It does not matter what you leave beyond the returned `k` (hence they are underscores).

### Constraints:
- 0 <= `nums.length` <= 100
- 0 <= `nums[i]` <= 50
- 0 <= `val` <= 100

## Strategy
Iterate through the array and increment `k` if the element is not equal to `val`. Use `k` as an index to do in-place updates to the array.

## Time Complexity - O(n)
The code involves a simple loop with no complexed operations.

## Space Complexity - O(1)
All variables have costant size.
