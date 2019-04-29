using System.Linq;

public class Matrix
{
    private readonly int[,] matrix;

    public Matrix(string input)
    {
        var values = input.Split(' ', '\n');
        Rows = input.Count(x => x == '\n') + 1;
        Cols = values.Length / Rows;
        matrix = new int[Rows, Cols];

        int pos = 0;
        for (int i = 0; i < Rows; i++)
            for (int j = 0; j < Cols; j++)
                matrix[i, j] = int.Parse(values[pos++]);
    }

    public int Rows { get; private set; }

    public int Cols { get; private set; }

    public int[] Row(int row)
    {
        int[] vals = new int[Cols];
        for (int i = 0; i < Cols; i++) vals[i] = matrix[row - 1, i];
        return vals;
    }

    public int[] Column(int col)
    {
        int[] vals = new int[Rows];
        for (int i = 0; i < Rows; i++) vals[i] = matrix[i, col - 1];
        return vals;
    }
}