public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (freq.ContainsKey(nums[i])) {
                freq[nums[i]]++;
            } else {
                freq[nums[i]] = 1;
            }
        }

        return freq
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}