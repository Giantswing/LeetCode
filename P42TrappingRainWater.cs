namespace LeetCodeProblems;

public class P42TrappingRainWater
{
    // public static void Main(string[] args)
    // {
    //     int[] height = new int[] {0,1,0,2,1,0,1,3,2,1,2,1};
    //
    //     P42TrappingRainWater p42 = new P42TrappingRainWater();
    //     Console.WriteLine(p42.Trap(height));
    // }

    public int Trap(int[] height)
    {
        int water = 0;

        for (int i = 0; i < height.Length - 1; i++)
            if (height[i] > height[i + 1]) //going down
            {
                int j, h;

                for (h = height[i]; h > 0; h--)
                for (j = i + 1; j < height.Length - 1; j++)
                    if (height[j + 1] >= h)
                    {
                        water += CalculateWaterAmount(height, i, j + 1);
                        i = j;

                        h = -1;
                        break;
                    }
            }

        return water;
    }

    public int CalculateWaterAmount(int[] height, int startPos, int endPos)
    {
        int containedWater = 0;
        int baseHeight = height[startPos] <= height[endPos] ? height[startPos] : height[endPos];

        for (int k = startPos + 1; k < endPos; k++)
            if (baseHeight - height[k] > 0)
                containedWater += baseHeight - height[k];

        return containedWater;
    }
}