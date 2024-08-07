# String Encode and Decode

## Description
Design an algorithm to encode a list of strings to a single string. The encoded string is then decoded back to the original list of strings.

Please implement encode and decode

### Example 1:
***Input:*** ["neet","code","love","you"]
***Output:*** ["neet","code","love","you"]

### Example 2:
***Input:*** ["we","say",":","yes"]
***Output:*** ["we","say",":","yes"]

Constraints:
- 0 <= `strs.length` < 100
- 0 <= `strs[i].length` < 200
- `strs[i]` contains only *UTF-8 characters*.

## Strategy
Encode the input list with the length of each string along with a special character and then the string itself. Decode by reading each character of the encoded string. Each time that a special character is encountered, the string is read with a loop for the length of the specified string.

## Time Complexity - O(n)

### Encode
It loops through the list of strings with no time complex operations. 

### Decode
It loops through the encoded string and has a nested loop. The nested loop actually keeps shifting the iterator forward, so it does not pause the outer iteration. Hence, the time complexity is still linear.

## Space Complexity - O(n)
Both the functions have to add space to store n characters, where n is the concatenated length of all the strings.
