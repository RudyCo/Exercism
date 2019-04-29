using System;

public static class Wordy
{
    public static int Answer(string question)
    {
        if (!question.StartsWith("What is ")) throw new ArgumentException();
        if (!question.EndsWith("?")) throw new ArgumentException();

        question = question.Replace("What is ", "").Replace("?", "");
        question = question.Replace("multiplied by", "multiplied_by");
        question = question.Replace("divided by", "divided_by");

        var words = question.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        if (words.Length % 2 != 1) throw new ArgumentException();

        int value = Parse(words[0]);
        for (int pos = 1; pos <= words.Length - 2; pos += 2)
        {
            var op = words[pos];
            switch (op)
            {
                case "plus": value += Parse(words[pos + 1]); break;
                case "minus": value -= Parse(words[pos + 1]); break;
                case "multiplied_by": value *= Parse(words[pos + 1]); break;
                case "divided_by": value /= Parse(words[pos + 1]); break;
                default: throw new ArgumentException();
            }
        }

        return value;
    }

    private static int Parse(string txt)
    {
        if (!int.TryParse(txt, out int value)) throw new ArgumentException();
        return value;
    }
}