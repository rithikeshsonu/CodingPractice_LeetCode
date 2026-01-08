public class Solution {
    public int ThirdMax(int[] nums) {
        HashSet<int> topThree = new HashSet<int>();
        foreach(int num in nums){
            topThree.Add(num);
            if(topThree.Count > 3){
                topThree.Remove(topThree.Min());
            }
        }
        if(topThree.Count < 3) return topThree.Max();
        else return topThree.Min();
    }
}