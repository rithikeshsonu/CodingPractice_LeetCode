public class Solution {
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i] += 1;
            if (digits[i] != 10) return digits;
            digits[i] = 0;
        }
        int[] newArray = new int[digits.Length + 1];
        newArray[0] = 1;
        return newArray;
    }
}