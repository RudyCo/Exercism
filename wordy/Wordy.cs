using System.Collections.Generic;

public static class Wordy
{
    private enum Operation
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        None
    };

    private static readonly IDictionary<string, Operation> operations = new Dictionary<string, Operation>
    {
        {"plus", Operation.Addition},
        {"minus", Operation.Subtraction},
        {"multiplied", Operation.Multiplication},
        {"divided", Operation.Division}
    };

    public static int Answer(string question)
    {
        // TODO Use Sprache

        var operation = Operation.Addition;
        var words = question.Split(' ');
        int res = 0;
        foreach (var word in words)
        {
            if (int.TryParse(word, out int cur))
            {
                switch (operation)
                {
                    case Operation.Addition: res += cur; break;
                    case Operation.Subtraction: res -= cur; break;
                    case Operation.Multiplication: res *= cur; break;
                    case Operation.Division: res /= cur; break;
                    case Operation.None: break;
                }
            }
        }
        return res;
    }
}