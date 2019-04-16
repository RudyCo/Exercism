using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        var numberAsString = number.ToString();
        var sum = numberAsString.Select(x => Math.Pow(char.GetNumericValue(x), numberAsString.Length)).Sum();
        return number == sum;
    }
}