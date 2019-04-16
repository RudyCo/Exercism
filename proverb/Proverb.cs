using System;
using System.Linq;
using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        var list = new List<string>();
        for (int i = 0; i < subjects.Length; i++)
        {
            if (i <= subjects.Length - 2)
            {
                list.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
            }
            else
            {
                list.Add($"And all for the want of a {subjects[0]}.");
            }
        }
        return list.ToArray();
    }
}