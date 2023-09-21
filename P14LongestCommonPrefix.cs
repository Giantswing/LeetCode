namespace LeetCodeProblems;

public class P14LongestCommonPrefix
{
    // public static void Main(string[] args)
    // {
    //     P14LongestCommonPrefix p14 = new();
    //     Console.WriteLine(p14.LongestCommonPrefix(new[] { "flower", "flow", "flight" })); // fl
    //     Console.WriteLine(p14.LongestCommonPrefix(new[] { "dog", "racecar", "car" })); // ""
    //     Console.WriteLine(p14.LongestCommonPrefix(new[] { "ab", "a" })); // a
    //     Console.WriteLine(p14.LongestCommonPrefix(new[] { "a" })); // a
    // }

    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        string baseWord = strs[0];
        int length = 0;
        if (strs.Length == 1) length = baseWord.Length - 1;
        bool exit = false;

        for (int i = 0; i < baseWord.Length; i++)
        {
            foreach (string word in strs)
            {
                if (word.Equals(baseWord)) continue;

                if (i >= word.Length || word[i] != baseWord[i])
                {
                    exit = true;
                    break;
                }
            }

            if (exit) break;
            length++;
        }


        return length > 0 ? strs[0].Substring(0, length) : "";
    }
}