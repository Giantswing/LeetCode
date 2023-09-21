namespace LeetCodeProblems;

public class P151ReverseWordsInAString
{
    // public static void Main(string[] args)
    // {
    //
    // }

    public string ReverseWords(string s)
    {
        string[] words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}