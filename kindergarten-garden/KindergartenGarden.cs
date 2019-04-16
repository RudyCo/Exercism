using System;
using System.Collections.Generic;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{
    private readonly string row1;
    private readonly string row2;

    public KindergartenGarden(string diagram)
    {
        this.row1 = diagram.Split('\n')[0];
        this.row2 = diagram.Split('\n')[1];
    }

    public IEnumerable<Plant> Plants(string student)
    {
        yield return GetPlant(student[0], row1, 0);
        yield return GetPlant(student[0], row1, 1);
        yield return GetPlant(student[0], row2, 0);
        yield return GetPlant(student[0], row2, 1);
    }

    private Plant GetPlant(char student, string row, int position)
    {
        var offset = (student - 'A') * 2;
        return GetPlant(row[offset + position]);
    }

    private Plant GetPlant(char plant)
    {
        switch (plant)
        {
            case 'V': return Plant.Violets;
            case 'R': return Plant.Radishes;
            case 'C': return Plant.Clover;
            case 'G': return Plant.Grass;
            default: throw new ArgumentException();
        }
    }
}