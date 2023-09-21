namespace LeetCodeProblems;

public class P13RomanToInteger
{
    // public static void Main(string[] args)
    // {
    //     P13RomanToInteger p13 = new();
    //     Console.WriteLine(p13.RomanToInt("III")); // 3
    //     Console.WriteLine(p13.RomanToInt("IV")); // 4
    //     Console.WriteLine(p13.RomanToInt("IX")); // 9
    //     Console.WriteLine(p13.RomanToInt("LVIII")); // 58
    //     Console.WriteLine(p13.RomanToInt("MCMXCIV")); // 1994
    //     Console.WriteLine(p13.RomanToInt("CXXV")); // 1994
    // }

    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanValues = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        Dictionary<char, int> romanPosition = new()
        {
            { 'I', 0 },
            { 'V', 1 },
            { 'X', 2 },
            { 'L', 3 },
            { 'C', 4 },
            { 'D', 5 },
            { 'M', 6 }
        };

        int resultValue = 0;
        ReadOnlySpan<char> span = s.AsSpan();

        for (int i = span.Length - 1; i >= 0; i--)
        {
            int currentCharPos = romanPosition[span[i]];
            if (i > 0)
                if (currentCharPos - romanPosition[span[i - 1]] > 0)
                {
                    resultValue -= romanValues[span[i - 1]];
                    resultValue += romanValues[span[i]];
                    i--;
                    continue;
                }

            resultValue += romanValues[span[i]];
        }

        return resultValue;
    }
}