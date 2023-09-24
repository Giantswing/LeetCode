using System.Collections.Immutable;

namespace LeetCode;

public class p30SubstringWithConcatenationOfAllWords {
    public static void Main(string[] args) {
        p30SubstringWithConcatenationOfAllWords p30 = new();
        // Console.WriteLine(p30.FindSubstring("barfoothefoobarman", new string[] { "foo", "bar" })); //[0,9]
        // Console.WriteLine(p30.FindSubstring("wordgoodgoodgoodbestword", new string[] { "word","good","best","word" })); //[]
        // Console.WriteLine(p30.FindSubstring("barfoofoobarthefoobarman", new string[] { "bar","foo","the" })); //[6,9,12]

        List<string> result =
            p30.FindPossiblePermutations(new List<string> { "a", "b", "c" });
        foreach (string permutation in result) Console.Write($"{permutation},");
    }

    public IList<int> FindSubstring(string s, string[] words) {
        List<int> result = new();
        List<string> permutations = FindPossiblePermutations(words.ToList());
        
        //Find instances of those permutations in the original string
        foreach (string permutation in permutations) {
            int pos = s.IndexOf(permutation);
            if (pos != -1) result.Add(pos);
        }

        return result;
    }
    
   public List<string> FindPossiblePermutations(List<string> words) {
        List<string> result = new();
        if (words.Count == 1) return new List<string> { words[0] };
        if (words.Count == 0) return new List<string>();
    
        for (int i = 0; i < words.Count; i++) {
            (words[^1], words[0]) = (words[0], words[^1]);
            List<string> remainingWords = new(words);
            remainingWords.Remove(words[0]);
            List<string> permutations = FindPossiblePermutations(remainingWords);
            foreach (string permutation in permutations) result.Add(words[0] + permutation);
        }
    
        return result;
    }
}