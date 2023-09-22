namespace LeetCode;

public class P15ThreeSum {
    // public static void Main(string[] args) {
    //     P15ThreeSum p15 = new();
    //     Console.WriteLine(p15.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 })); //[[-1,-1,2],[-1,0,1]]
    //     // Console.WriteLine(p15.ThreeSum(new int[]{0,1,1})); //[]
    //     // Console.WriteLine(p15.ThreeSum(new int[]{0,0,0})); //[[0,0,0]]
    //     // Console.WriteLine(p15.ThreeSum(new int[]{0,0,0,0})); //[[0,0,0]]
    //     // Console.WriteLine(p15.ThreeSum(new int[]{-2,0,1,1,2})); //[[0,0,0]]
    // }

    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++) {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum == 0) {
                    bool shouldAdd = true;
                    List<int> newInput = new() { nums[i], nums[left], nums[right] };

                    if (result.Count > 0)
                        foreach (IList<int> r in result)
                            if (newInput[0] == r[0] && newInput[1] == r[1] && newInput[2] == r[2])
                                shouldAdd = false;

                    if (shouldAdd) result.Add(newInput);

                    left++;
                }
                else if (sum > 0) {
                    right--;
                }
                else if (sum < 0) {
                    left++;
                }
            }
        }

        return result;
    }
}