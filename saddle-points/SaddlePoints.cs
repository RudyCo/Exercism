using System.Collections.Generic;
using System.Linq;

public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            var rows = GetRows(matrix, x);
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                var cols = GetCols(matrix, y);

                if (matrix[x, y] >= rows.Max() && (matrix[x, y] <= cols.Min())) yield return (x + 1, y + 1);
            }
        }
    }

    private static IEnumerable<int> GetRows(int[,] matrix, int x)
    {
        for (int y = 0; y < matrix.GetLength(1); y++) yield return matrix[x, y];
    }

    private static IEnumerable<int> GetCols(int[,] matrix, int y)
    {
        for (int x = 0; x < matrix.GetLength(0); x++) yield return matrix[x, y];
    }
}