public class GenerateParentheses {
    public IList<string> GenerateParenthesis2(int n) {
        List<string> lists = new List<string>();
        if(n <= 0)
            lists.Add("");
        else
        {
            for(int i = 0;i < n;i++)
            {
                foreach(string left in GenerateParenthesis(i))
                {
                    foreach(string right in GenerateParenthesis(n-i-1))
                    {
                        lists.Add("(" + left + ")" + right);
                    }
                }
            }
        }
        
        return lists;
    }
    
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> list = new List<string>();
        Generate(new char[n*2],0,list);
        return list;
    }
    
    public void Generate(char[] text,int pos,List<string> list)
    {
        if(pos == text.Length)
        {
            if(isResult(text))
            {
                list.Add(new string(text));
            }
        }
        else
        {
            text[pos] = '(';
            Generate(text,pos+1,list);
            text[pos] = ')';
            Generate(text,pos+1,list);
        }  
    }
    
    public bool isResult(char[] text)
    {
        int balance = 0;
        foreach (char c in text) {
            if (c == '(') 
                balance++;
            else 
                balance--;
            if (balance < 0) 
                return false;
        }
        return (balance == 0);
    }
}