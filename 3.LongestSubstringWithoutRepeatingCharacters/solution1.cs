public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int ans = 0;
        
        for(int i = 0;i < n;i++)
        {
            for(int j = i + 1;j <= n;j++)
            {
                if(allUnique(s,i,j))
                    ans = Math.Max(ans,j-i);
            }
        }
        
        return ans;
    }
    
    public bool allUnique(string s,int start,int end)
    {
        char[] ch = s.ToCharArray();
        HashSet<char> set = new HashSet<char>();
        for(int i = start;i < end; i++)
        {
            if(set.Contains(ch[i]))
                return false;
            set.Add(ch[i]);
        }
        
        return true;
    }

}