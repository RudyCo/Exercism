using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        int a = 0, c = 0, g = 0, t = 0;
        foreach (var ch in sequence)
        {
            switch (ch)
            {
                case 'A': a++; break;
                case 'C': c++; break;
                case 'G': g++; break;
                case 'T': t++; break;
                default: throw new ArgumentException($"Invalid char: {ch}");
            }
        }

        return new Dictionary<char, int> { ['A'] = a, ['C'] = c, ['G'] = g, ['T'] = t };
    }
}