using System;

public class DndCharacter
{
    public int Strength { get; private set; }
    public int Dexterity { get; private set; }
    public int Constitution { get; private set; }
    public int Intelligence { get; private set; }
    public int Wisdom { get; private set; }
    public int Charisma { get; private set; }

    public int Hitpoints
    {
        get
        {
            return 10 + Modifier(Constitution);
        }
    }

    public static int Modifier(int score)
    {
        var modifier = ((score - 10) / 2.0);
        return (int)Math.Floor(modifier);
    }

    public static int Ability()
    {
        return new Random().Next(3, 18);
    }

    public static DndCharacter Generate()
    {
        return new DndCharacter
        {
            Strength = Ability(),
            Dexterity = Ability(),
            Constitution = Ability(),
            Intelligence = Ability(),
            Wisdom = Ability(),
            Charisma = Ability()
        };
    }
}