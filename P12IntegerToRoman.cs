namespace LeetCodeProblems;

public class P12IntegerToRoman
{
    // public static void Main(string[] args)
    // {
    //     P12IntegerToRoman p12 = new();
    //     Console.WriteLine(p12.IntToRoman(35)); // III
    //     Console.WriteLine(p12.IntToRoman(4)); // IV
    //     Console.WriteLine(p12.IntToRoman(9)); // IX
    //     Console.WriteLine(p12.IntToRoman(58)); // LVIII
    //     Console.WriteLine(p12.IntToRoman(1994)); // MCMXCIV
    // }

    public string IntToRoman(int num)
    {
        Dictionary<string, int> romanValues = new()
        {
            { "I", 1 }, { "IV", 4 }, { "V", 5 }, { "IX", 9 },
            { "X", 10 }, { "XL", 40 }, { "L", 50 },
            { "XC", 90 }, { "C", 100 }, { "CD", 400 }, { "D", 500 },
            { "CM", 900 }, { "M", 1000 }
        };

        string resultString = "";
        int remaining = num;


        foreach (KeyValuePair<string, int> item in romanValues.Reverse())
        {
            if (remaining <= 0) break;

            while (remaining >= item.Value)
            {
                remaining -= item.Value;
                resultString += item.Key;
            }
        }


        return resultString;
    }
}