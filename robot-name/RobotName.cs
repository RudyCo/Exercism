using System;
using System.Collections.Generic;
using System.Linq;

public class Robot
{
    private readonly Random random = new Random();

    private static readonly object _lock = new object();
    private static readonly IList<string> _names = new List<string>();

    public Robot()
    {
        Reset();
    }

    public string Name
    {
        get;
        private set;
    }

    public void Reset()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var s1 = new string(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray());

        const string digits = "0123456789";
        var s2 = new string(Enumerable.Repeat(digits, 3).Select(s => s[random.Next(s.Length)]).ToArray());

        var name = s1 + s2;

        lock (_lock)
        {
            if (_names.Contains(name))
            {
                Reset();
            }
            else
            {
                _names.Add(name);
                Name = name;
            }
        }
    }
}