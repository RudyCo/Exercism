using System;
using System.Linq;
using System.Collections.Generic;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1) { throw new ArgumentOutOfRangeException("Positive only!"); }

        var aliquotSum = GetDivisors(number).Sum();
        if (aliquotSum > number) { return Classification.Abundant; }
        if (aliquotSum < number) { return Classification.Deficient; }
        return Classification.Perfect;
    }

    public static IEnumerable<int> GetDivisors(int number)
    {
        var divisors = new List<int>();
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0) divisors.Add(i);
        }
        return divisors;
    }
}