namespace Valid_Anagram;


public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        else if (s == t) return true;

        int[] charCount = new int[26];
        for (int i = 0; i < s.Length; i++) {
            charCount[s[i] - 'a']++;
            charCount[t[i] - 'a']--;
        }
        foreach (int count in charCount) {
            if (count != 0) return false;
        }

        return true;
    }
    public bool IsAnagram_Unicode(string s, string t) {
        if (s.Length != t.Length) return false;
        else if (s == t) return true;

        Dictionary<char, int> charCount = [];
        foreach (char c in s) {
            if (charCount.TryGetValue(c, out int val)) {
                charCount[c] = ++val;
            } else charCount.Add(c, 1);
        }
        foreach (char c in t) {
            if (charCount.TryGetValue(c, out int val) && val > 0) {
                charCount[c] = --val;
            } else return false;
        }

        return true;
    }
}
