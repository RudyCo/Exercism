using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        var verses = new List<string>();
        for (int i = startBottles; i >= 0 && takeDown > 0; i--)
        {
            verses.Add(Recite(i));
            takeDown--;
        }
        return string.Join("\n\n", verses);
    }

    public static string Recite(int bottle) =>
        $"{GetBottleText(bottle, true)} of beer on the wall, {GetBottleText(bottle, false)} of beer.\n" +
            ((bottle > 0) ?
                $"Take {GetItOrOneText(bottle)} down and pass it around, {GetBottleText(bottle - 1, false)} of beer on the wall."
                : "Go to the store and buy some more, 99 bottles of beer on the wall."
        );

    private static string GetItOrOneText(int bottle) => bottle == 1 ? "it" : "one";

    private static string GetBottleText(int bottle, bool firstLetterIsUpper)
    {
        if (bottle > 1) return $"{bottle} bottles";
        if (bottle == 1) return $"{bottle} bottle";
        return $"{(firstLetterIsUpper ? "No" : "no")} more bottles";
    }
}