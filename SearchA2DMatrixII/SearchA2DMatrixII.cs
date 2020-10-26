public class SearchA2DMatrixII {
    public bool SearchMatrix(int[,] matrix, int target) 
    {
        if(matrix.GetLength(0)==0) return false;
        int row = 0;
        int col = matrix.GetLength(1)-1;
        
        while(row < matrix.GetLength(0) && col >=0)
        {
            if(matrix[row,col] < target)
                row++;
            else if(matrix[row,col] > target)
                col--;
            else
                return matrix[row,col] == target;
        }
        
        return false;
    }
}