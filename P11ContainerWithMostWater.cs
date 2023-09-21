namespace LeetCodeProblems;

public class P11ContainerWithMostWater {
    // public static void Main(string[] args) {
    //     P11ContainerWithMostWater p11 = new();
    //     // Console.WriteLine(p11.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 })); //49
    //     Console.WriteLine(p11.MaxArea(new[] { 1, 2, 4, 3 })); //4
    //     // Console.WriteLine(p11.MaxArea(new int[]{1,1})); //1
    // }

    public int MaxArea(int[] height) {
        if (height.Length <= 1) return 0;

        int left = 0, right = height.Length - 1, maxWater = 0;
        int bestLeft = left, bestRight = right;

        while (left < right) {
            int water = CalculateArea(height, left, right);

            if (water > maxWater) {
                bestLeft = left;
                bestRight = right;
                maxWater = water;
            }

            if (height[left] < height[right]) left++;
            else right--;
        }

        return CalculateArea(height, bestLeft, bestRight);
    }

    public int CalculateArea(int[] height, int a, int b) {
        int minHeight = Math.Min(height[a], height[b]);

        Console.WriteLine($"Area between {a} and {b} is {minHeight * (b - a)}");
        return minHeight * (b - a);
    }
}