using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var regexp = @"^\+?1?[-. ]*\(?([2-9][0-9]{2})\)?[-. ]*?([2-9][0-9]{2})[-. ]*([0-9]{4})[-. ]*$";
        var phoneRegex = new Regex(regexp);
        if (phoneRegex.IsMatch(phoneNumber)) return phoneRegex.Replace(phoneNumber, "$1$2$3");
        else throw new ArgumentException("");
    }
}