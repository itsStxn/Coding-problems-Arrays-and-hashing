namespace Length_of_Last_Word;


public class Solution {
    public int LengthOfLastWord(string s) {
        if (s.Length == 1) return 1;

        int charaCount = 0;
        for (int i = s.Length - 1; i >= 0; i--) {
            if (s[i] != ' ') charaCount++;
            else if (charaCount > 0) break;
        }

        return charaCount;
    }
}
