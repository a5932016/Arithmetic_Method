public class FibonacciNumber {
    public int Fib(int N) {
        if (N < 2)
                return N;

        int[] Fibs = new int[N + 1];
        Fibs[0] = 0;
        Fibs[1] = 1;
        Fibs[2] = 1;

        if(Fibs[N] == null)
            for (int i = 3; i <= N; i++)
                Fibs[i] = Fibs[i - 1] + Fibs[i - 2];

        return Fibs[N];
    }
}