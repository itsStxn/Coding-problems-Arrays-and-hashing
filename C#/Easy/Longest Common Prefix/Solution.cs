using System.Text;

namespace Longest_Common_Prefix;


public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder prefix = new(strs[0], strs[0].Length);
        if (strs.Length == 1) return prefix.ToString();
        
        foreach (string s in strs) {
            int i = 0;
            int stop = Math.Min(prefix.Length, s.Length);
            while(i < stop && s[i] == prefix[i]) i++;
            if (i == 0) return string.Empty;
            else prefix.Length = i;
        }

        return prefix.ToString();
    }
}
