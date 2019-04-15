using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var count1 = word.ToLower().Count(x => char.IsLetter(x));
        var count2 = word.ToLower().Where(x => char.IsLetter(x)).Distinct().Count();
        return count1 == count2;
    }
}