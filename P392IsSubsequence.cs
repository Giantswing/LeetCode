namespace LeetCodeProblems;

public class P392IsSubsequence {
    public bool IsSubsequence(string s, string t) {
        int lastPos = t.Length;

        for (int i = s.Length - 1; i >= 0; i--) {
            ReadOnlySpan<char> span = t.AsSpan(0, lastPos);
            int pos = span.LastIndexOf(s[i]);

            Console.WriteLine($"{s[i]} - {pos}");

            if (pos == -1 || lastPos <= pos) return false;
            lastPos = pos;
        }

        return true;
    }
}