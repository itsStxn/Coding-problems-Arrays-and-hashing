namespace Find_Index_of_the_First_Occurance_in_a_String;


public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length > haystack.Length) return -1;
        if (haystack == needle) return 0;

        int hLen = haystack.Length;
        int nLen = needle.Length;

        for (int hayIndex = 0; hayIndex <= hLen - nLen; hayIndex++) {
            int ndlIndex = 0;
            while (haystack[hayIndex + ndlIndex] == needle[ndlIndex]) {
                if (++ndlIndex == nLen) return hayIndex;
            }
        }

        return -1;
    }
}
