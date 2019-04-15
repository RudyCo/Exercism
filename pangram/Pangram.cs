using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        return input.ToLower().ToCharArray().Where(x => x >= 'a' && x <= 'z').Distinct().Count() == 26;
    }
}