using System;
using System.Collections.Generic;
using System.Linq;

public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        for (int x = 0; x < matrix.Rank; x++)
        {
            var cols = GetCols(matrix, x);
            for (int y = 0; y < matrix.Rank; y++)
            {
            }
        }
    }

    private static IEnumerable<int> GetCols(int[,] matrix, int x)
    {
        for (int y = 0; y < matrix.Rank; y++)
        {
            yield return matrix[x, y];
        }
    }
}