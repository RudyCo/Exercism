using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var words = phrase
            .ToUpper()
            .Replace("_", "")
            .Replace("-", " ")
            .Split(" ")
            .Where(x => x.Length > 0);

        string acronym = "";
        foreach (var word in words)
        {
            acronym += word[0];
        }
        return acronym;
    }
}