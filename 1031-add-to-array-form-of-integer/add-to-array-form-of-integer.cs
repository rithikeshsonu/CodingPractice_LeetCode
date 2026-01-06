public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
            List<int> result = new List<int>();
    int i = num.Length - 1;
    int carry = 0;

    while (i >= 0 || k > 0 || carry > 0)
    {
        int digitFromNum = (i >= 0) ? num[i] : 0;
        int digitFromK = k % 10;

        int sum = digitFromNum + digitFromK + carry;
        result.Add(sum % 10);
        carry = sum / 10;

        if (i >= 0) i--;
        k /= 10;
    }

    result.Reverse();
    return result;
    }
}