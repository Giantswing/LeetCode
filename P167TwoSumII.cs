namespace LeetCodeProblems;

public class P167TwoSumII {
    // public static void Main(string[] args) {
    //     P167TwoSumII p167 = new();
    //     // Console.WriteLine(string.Join(",", p167.TwoSum(new[] { 2, 7, 11, 15 }, 9))); // 1,2
    //     // Console.WriteLine(string.Join(",", p167.TwoSum(new[] { 2, 3, 4 }, 6) ?? Array.Empty<int>())); // 1,3
    //     // Console.WriteLine(string.Join(",", p167.TwoSum(new[] { -1, 0 }, -1))); // 1,2
    //     // Console.WriteLine(string.Join(",", p167.TwoSum(new[] { 0, 0, 3, 4 }, 0))); // 1,2
    // }

    public int[] TwoSum(int[] numbers, int target) {
        int left = 0, right = numbers.Length - 1;

        while (left < right) {
            int result = numbers[left] + numbers[right];

            if (result == target) return new[] { left + 1, right + 1 };
            if (result > target) right--;
            else if (result < target) left++;
        }

        return Array.Empty<int>();
    }
}