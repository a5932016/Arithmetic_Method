public class ReverseString {
    public void ReverseString(char[] s) {
        if(s.Length < 2)
            return;
        
        int start = 0,end = s.Length-1;
        char tmp;
        while(start<end)
        {
            tmp = s[start];
            s[start] = s[end];
            s[end] = tmp;
            start++;
            end--;
        }
    }
}