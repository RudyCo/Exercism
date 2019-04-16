using System;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2) throw new ArgumentOutOfRangeException();

        var list = Enumerable.Range(1, limit).Skip(1).ToDictionary(x => x, x => true);

        for (int i = 2; i <= Math.Sqrt(limit); i++)
            if (list[i] == true)
                for (int j = Convert.ToInt32(Math.Pow(i, 2)); j <= limit; j = j + i)
                    list[j] = false;

        return list.Where(x => x.Value == true).Select(x => x.Key).ToArray();
    }
}