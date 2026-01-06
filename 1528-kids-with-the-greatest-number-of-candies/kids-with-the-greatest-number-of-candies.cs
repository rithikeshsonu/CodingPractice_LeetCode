public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
            List<bool> result = new List<bool>();
    bool value = false;
    int max = candies[0];
    for(int i = 1; i < candies.Length; i++)
    {
        if (candies[i] > max) max = candies[i];
    }

    for (int i = 0; i < candies.Length; i++)
    {
        if (candies[i] + extraCandies >= max) value = true;
        else value = false;
        result.Add(value);
    }
    return result;
    }
}