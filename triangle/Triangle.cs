using System;
using System.Linq;

public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        var sides = new[] { side1, side2, side3 };
        if (sides.OrderBy(x => x).Take(2).Sum() < sides.Max()) return false;
        return sides.Distinct().Count() == 3;
    }

    public static bool IsIsosceles(double side1, double side2, double side3)
    {
        var sides = new[] { side1, side2, side3 };
        if (sides.OrderBy(x => x).Take(2).Sum() < sides.Max()) return false;
        return sides.Distinct().Count() == 2 || sides.Distinct().Count() == 1;
    }

    public static bool IsEquilateral(double side1, double side2, double side3)
    {
        var sides = new[] { side1, side2, side3 };
        return sides.Distinct().Count() == 1 && side1 > 0;
    }
}