public class NQueensII {
    private bool IsAllowed(int[] board, int size, int r, int c) 
    {
        for (int qRow = 0, qCol; qRow < size; ++qRow) 
        {
            qCol = board[qRow];
            
            if (r == qRow || c == qCol || Math.Abs(r-qRow) == Math.Abs(c-qCol))
                return false;
        }
        
        return true;
    }
    
    public int Helper(int[] board, int qIdx)
    {
        if (qIdx == board.Length)
            return 1;
        
        int solns = 0;
        for (int col = 0; col < board.Length; ++col) 
        {
            if (IsAllowed(board, qIdx, qIdx, col)) 
            {
                // place queen
                board[qIdx] = col;
                // recurse to place remaining
                solns += Helper(board, qIdx+1);
                // no need to replace, will be set in next iteration
            }
        }
        
        return solns;
    }
    
    public int TotalNQueens(int n)
    {
        int[] board = new int[n];
        
        return Helper(board, 0);
    }
}