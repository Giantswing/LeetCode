namespace LeetCodeProblems;

public class P58LengthOfLastWord
{
    // public static void Main(string[] args)
    // {
    // }

    public int LengthOfLastWord(string s)
    {
        string[] splitString = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int lastWordLength = splitString[splitString.Length - 1].Length;

        return lastWordLength;
    }
}