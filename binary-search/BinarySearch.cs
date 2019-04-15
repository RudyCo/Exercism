using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        var res = Array.BinarySearch(input, value);
        return res < 0 ? -1 : res;
    }
}