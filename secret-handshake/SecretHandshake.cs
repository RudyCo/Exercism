using System.Collections.Generic;

public static class SecretHandshake
{
    private static readonly IDictionary<int, string> orders = new Dictionary<int, string>
    {
        { 0b1, "wink" },
        { 0b10, "double blink" },
        { 0b100, "close your eyes" },
        { 0b1000, "jump" }
    };

    public static string[] Commands(int commandValue)
    {
        var s = new List<string>();
        foreach (var order in orders)
        {
            if ((commandValue & order.Key) == order.Key) s.Add(order.Value);
        }
        if ((commandValue & 0b10000) == 0b10000) s.Reverse();
        return s.ToArray();
    }
}