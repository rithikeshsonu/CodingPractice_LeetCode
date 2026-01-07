public class Solution {
    public int MissingNumber(int[] nums) {
        int sumOfNInts = nums.Length * (nums.Length + 1) / 2;
        int sum = 0;
        foreach(int num in nums)
        {
            sum += num;
        }
        return sumOfNInts - sum;
    }
}