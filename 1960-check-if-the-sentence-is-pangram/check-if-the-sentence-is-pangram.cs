public class Solution {
    public bool CheckIfPangram(string sentence) {
        HashSet<char> letters = new HashSet<char>();
        foreach(char ch in sentence){
            letters.Add(ch);
        }
        return letters.Count == 26;
    }
}