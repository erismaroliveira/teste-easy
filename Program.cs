using EasyTeste;

int[] nums1 = [23, 2, 4, 6, 7];
int k1 = 6;
Console.WriteLine(SubarraySumChecker.CheckSubarraySum(nums1, k1));

int[] nums2 = [23, 2, 6, 4, 7];
int k2 = 6;
Console.WriteLine(SubarraySumChecker.CheckSubarraySum(nums2, k2));

int[] nums3 = [23, 2, 6, 4, 7];
int k3 = 13;
Console.WriteLine(SubarraySumChecker.CheckSubarraySum(nums3, k3));