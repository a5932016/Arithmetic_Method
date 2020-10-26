public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int ans = 0;
        int[] index = new int[128];
        char[] ch = s.ToCharArray();
        
        for(int i = 0,j = 0; j < n; j++)
        {
            i = Math.Max(index[ch[j]],i);
            ans = Math.Max(ans,j - i + 1);
            index[ch[j]] = j +1;
        }
        
        return ans;
    }
}