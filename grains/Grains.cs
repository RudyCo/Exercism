using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (!(1 <= n && n <= 64)) { throw new ArgumentOutOfRangeException($"{n} must be between 1 and 64!"); }

        return Convert.ToUInt64(Math.Pow(2, n - 1));
    }

    public static ulong Total() => Total(64);

    public static ulong Total(int n) => n == 1 ? Square(1) : Square(n) + Total(n - 1);
}