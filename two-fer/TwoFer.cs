public static class TwoFer
{
    public static string Speak(string name = null)
    {
        if (name == null)
        {
            name = "you";
        }
        return $"One for {name}, one for me.";
    }
}