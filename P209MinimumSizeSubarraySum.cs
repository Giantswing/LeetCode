namespace LeetCode;

public class P209MinimumSizeSubarraySum {
    // public static void Main(string[] args) {
    //     P209MinimumSizeSubarraySum p209 = new();
    //     // Console.WriteLine(p209.MinSubArrayLen(7, new[] { 2, 3, 1, 2, 4, 3 })); //2
    //     // Console.WriteLine(p209.MinSubArrayLen(4, new[] { 1, 4, 4 })); //1
    //     // Console.WriteLine(p209.MinSubArrayLen(11, new[] { 1, 2, 3, 4, 5 })); //1
    //     Console.WriteLine(p209.MinSubArrayLen(213, new[] { 12,28,83,4,25,26,25,2,25,25,25,12 })); //1
    // }

    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0, right = 0, sum = 0;

        int minLength = int.MaxValue;

        while (right < nums.Length) {
            sum += nums[right];

            if (sum < target) {
                right++;
            }
            else if (sum >= target) {
                if (right - left < minLength) minLength = right - left + 1;
                sum -= nums[left] + nums[right];
                left++;
            }
        }


        return minLength == int.MaxValue ? 0 : minLength;
    }
}