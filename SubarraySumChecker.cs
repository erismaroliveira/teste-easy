namespace EasyTeste;

public static class SubarraySumChecker
{
    public static bool CheckSubarraySum(int[] nums, int k)
    {
        var prefixSumMap = new Dictionary<int, int>
        {
            [0] = -1
        };
        int prefixSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];

            if (k != 0)
                prefixSum %= k;

            if (prefixSumMap.TryGetValue(prefixSum, out int value))
                if (i - value > 1)
                    return true;
            else
                prefixSumMap[prefixSum] = i;
        }

        return false;
    }
}
