# Check Dom

## Description
Have the function `HTMLElements(str)` read the `str` parameter being passed which will be a string of **HTML DOM elements** and **plain text**.
The elements that will be used are: `b`, `i`, `em`, `div`, `p`. 

For example: if `str` is "`<div><b><p>hello world</p></b></div>`" then this string of
DOM elements is nested correctly so your program should return the string `true`.

- If a string is not nested correctly, return the **first element** encountered where, *if changed into a different element, would result in a
properly formatted string.*   
- If the string is not formatted properly, then it will only be one element that needs to be changed.   

**For example:**  
  - if `str` is "`<div><i>hello</i>world</b>`" then your program should return the string `div` because if the first `<div>` element were changed into
a `<b>`, the string would be properly formatted.

### Example 1:  
***Input:*** "`<div><div><b></b></div></p>`"  
***Output:*** div

### Example 2:  
***Input:*** "`<div>abc</div><p><em><i>test test test</b></em></p>`"   
***Outupt:*** i

## Strategy
Retrieve the tags from the input string with regex. Verify the each tag's format. A stack keeps track of currently open elements. The stack count detects the nesting validity. Track the number of dismatching tags with a list. Allow only one dismatch. 

## Time Complexity - O(n)
The code is a distinct iteration of tags found in the input string with a regex function. The latter also depends on the n length of the input string. The auxiliary functions are all quick lookup operations.

## Space Complexity - O(n)
The error list never exceeds the length of 2. The iteration uses a stack that can hold at most n elements.
