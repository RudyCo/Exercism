using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return Enumerable.Range(1, max - 1).Where(val => multiples.Where(multiple => (multiple != 0) && (val % multiple) == 0).Any()).Sum();
    }
}