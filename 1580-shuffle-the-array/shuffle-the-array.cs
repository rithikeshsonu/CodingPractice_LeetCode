public class Solution {
    public int[] Shuffle(int[] nums, int n) {
            int[] res = new int[nums.Length];
    // int i = 0, j = n;
    int p1 = 0, p2 = n;
    for (int i = 0; i < 2 * n; i += 2)
    {
        res[i] = nums[p1++];
        res[i + 1] = nums[p2++];
    }
    return res;
    }
}