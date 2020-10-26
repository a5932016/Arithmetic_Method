public class PascalIsTriangleII {
    public IList<int> GetRow(int rowIndex) {
        IList<IList<int>> list = new List<IList<int>>();
        IList<int> row = new List<int>();
        IList<int> prev = new List<int>();
        int numRows = rowIndex + 1;
        
        if (numRows <= 0)
            return row;

        list.Add(new List<int>() { 1 });

        for (int i = 1; i < numRows; i++)
        {
            row = new List<int>();
            prev = list[i - 1];

            row.Add(1);

            for (int j = 1; j < i; j++)
                row.Add(prev[j - 1] + prev[j]);

            row.Add(1);

            list.Add(row);
        }

        return list[rowIndex];
    }
}