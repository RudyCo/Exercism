using System.Collections.Generic;
using System.Linq;

public static class ScrabbleScore
{
    private static IDictionary<string, int> VALUES = new Dictionary<string, int> {
        { "AEIOULNRST", 1  },
        { "DG",         2  },
        { "BCMP",       3  },
        { "FHVWY",      4  },
        { "K",          5  },
        { "JX" ,        8  },
        { "QZ",         10 }
    };

    public static int Score(string input)
    {
        return input.ToUpper().Select(l => VALUES.First(v => v.Key.Contains(l)).Value).Sum();
    }
}