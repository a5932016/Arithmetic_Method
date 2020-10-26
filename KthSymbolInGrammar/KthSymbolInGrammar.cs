public class KthSymbolInGrammar {
    public int KthGrammar_E02(int N, int K) {
        int ans = 0;
        --K;
        while(K > 0)
        {
            ans = ans + (K & 1);
            K = K >> 1;
        }
        
        return ans & 1;
    }

    public int KthGrammar(int N,int K)
    {
        if (N == 1) 
            return 0;
        else if ((K % 2) == 0) 
            return (KthGrammar(N - 1, K / 2) == 0) ? 1 : 0;
        else 
            return (KthGrammar(N - 1, (K + 1) / 2) == 0) ? 0 : 1;
    }
}