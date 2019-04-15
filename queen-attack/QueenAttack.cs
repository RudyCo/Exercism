using System;
using System.Linq;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        return (white.Row == black.Row) ||
         (white.Column == black.Column) ||
         (Math.Abs(white.Row - black.Row) == Math.Abs(white.Column - black.Column));
    }

    public static Queen Create(int row, int column)
    {
        var range = Enumerable.Range(0, 7);
        if (!range.Contains(row)) throw new ArgumentOutOfRangeException();
        if (!range.Contains(column)) throw new ArgumentOutOfRangeException();
        return new Queen(row, column);
    }
}