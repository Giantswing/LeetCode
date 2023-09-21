namespace LeetCodeProblems;

public class P125ValidPalindrome {
    public bool IsPalindrome(string s) {
        ReadOnlySpan<char> c = s.AsSpan();
        string result = "";

        for (int i = 0; i < c.Length; i++)
            if (char.IsLetterOrDigit(c[i]))
                result += c[i];

        result = result.ToLower();

        int start = 0, end = result.Length - 1;
        bool isPalindrome = true;

        while (start < end) {
            if (result[start] != result[end]) {
                isPalindrome = false;
                break;
            }

            start++;
            end--;
        }

        return isPalindrome;
    }
}