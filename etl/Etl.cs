using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        return old.SelectMany(x => x.Value, (x, y) => new { y, x.Key })
            .ToDictionary(x => x.y.ToLower(), x => x.Key);
    }
}