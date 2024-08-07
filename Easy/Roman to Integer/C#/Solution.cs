namespace Roman_to_Integer;


public class Solution {
    public int RomanToInt(string s) {
        int prev = int.MaxValue;
        int num = 0;

        for (int i = 0; i < s.Length ; i++) {
            int curr = Intify(s[i]);
            if (curr > prev) num -= 2*prev;
            num += curr;
            prev = curr;
        }

        return num;
    }
    private static int Intify(char c) {
        return c switch {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0,
        };
    }
}
