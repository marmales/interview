namespace interview;

public static class MaxAndNextMax
{
    public static IEnumerable<int> Calculate(int[] array)
    {
        var max = int.MinValue;
        var nextMax = int.MinValue;

        foreach (var item in array)
        {
            if (item >= max)
            {
                nextMax = max;
                max = item;
            }
            else if (item > nextMax)
            {
                nextMax = item;
            }
        }

        yield return nextMax;
        yield return max;
    }
}