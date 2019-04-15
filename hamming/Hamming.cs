using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand == null || secondStrand == null) throw new ArgumentException("Cannot be null!");
        if (firstStrand.Length != secondStrand.Length) throw new ArgumentException("Same length!");

        int distance = 0;
        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i]) distance++;
        }

        return distance;
    }
}