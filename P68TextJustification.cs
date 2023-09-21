namespace LeetCodeProblems;

public class P68TextJustification {
    // public static void Main(string[] args) {
    //     P68TextJustification p68 = new();
    //
    //     // Console.WriteLine(p68.FullJustify(new[] { "This", "is", "an", "example", "of", "text", "justification." }, 16));
    //     // Console.WriteLine(p68.FullJustify(new[] { "What", "must", "be", "acknowledgment", "shall", "be" }, 16));
    //     // Console.WriteLine(p68.FullJustify(new[] { "What", "must", "be", "acknowledgment", "shall", "be" }, 16));
    //     Console.WriteLine(p68.FullJustify(new[] {
    //         "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain",
    //         "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do"
    //     }, 20));
    // }

    private IList<string> FullJustify(string[] words, int maxWidth) {
        int currentWordCount = 0;
        List<string[]> justifiedText = new();
        List<string> finalResult = new();
        string currentLineText = "";

        for (int i = 0; i < words.Length; i++)
            if (currentWordCount + words[i].Length <= maxWidth) {
                currentLineText += words[i];
                currentWordCount += words[i].Length;

                if (i + 1 < words.Length && currentWordCount + words[i + 1].Length <= maxWidth) {
                    currentLineText += "-";
                    currentWordCount += 1;
                }
            }
            else {
                justifiedText.Add(currentLineText.Split("-", StringSplitOptions.RemoveEmptyEntries));
                currentWordCount = 0;
                currentLineText = "";
                i--;
            }

        if (currentLineText != "") justifiedText.Add(currentLineText.Split("-", StringSplitOptions.RemoveEmptyEntries));


        /////////////////////////////////////////////////////////////

        // Clean up and adding proper amount of spaces in each line
        for (int j = 0; j < justifiedText.Count; j++) {
            string[] line = justifiedText[j];
            int lineLength = 0;

            for (int i = 0; i < line.Length; i++) lineLength += line[i].Length;

            if (j < justifiedText.Count - 1 && line.Length != 1) {
                int remainingSpaces = maxWidth - lineLength;

                while (remainingSpaces > 0)
                    for (int i = 0; i < line.Length - 1 && remainingSpaces > 0; i++) {
                        line[i] = line[i] + " ";
                        remainingSpaces--;
                    }
            }
            else {
                int lastLineLength = 0;

                for (int i = 0; i < line.Length - 1; i++) {
                    line[i] = line[i] + " ";
                    lastLineLength += line[i].Length;
                }

                lastLineLength += line[line.Length - 1].Length;

                for (int k = lastLineLength; k < maxWidth; k++) line[line.Length - 1] += " ";
            }
        }


        foreach (string[] line in justifiedText) finalResult.Add(string.Join("", line));
        // PrintList(finalResult);
        return finalResult;
    }

    public void PrintListTest(List<string[]> myString) {
        foreach (string[] line in myString) Console.WriteLine(string.Join("", line));
    }

    public void PrintList(IEnumerable<string> myString) {
        foreach (string line in myString) Console.WriteLine(line);
    }
}