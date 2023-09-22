namespace LeetCode;

public class P3LongestSubstringWithoutRepeatingCharacters {
    // public static void Main(string[] args) {
    //     P3LongestSubstringWithoutRepeatingCharacters p3 = new();
    //     // Console.WriteLine(p3.LengthOfLongestSubstring("abcabcbb")); // 3
    //     // Console.WriteLine(p3.LengthOfLongestSubstring("bbbbb")); // 1
    //     Console.WriteLine(p3.LengthOfLongestSubstring("pwwkew")); // 3
    // }

    public int LengthOfLongestSubstring(string s) {
        int left = 0, right = 0;
        int longest = Int32.MinValue;
        HashSet<char> containedCharacters = new HashSet<char>();

        while (right < s.Length) {
            char currentChar = s[right];

            if (!containedCharacters.Contains(currentChar)) {
                containedCharacters.Add(currentChar);
                right++;
                if (containedCharacters.Count > longest) longest = containedCharacters.Count;
            }
            else {
                containedCharacters.Remove(s[left]);
                left++;
            }
        }

        return longest == Int32.MinValue ? 0 : longest;
    }
}