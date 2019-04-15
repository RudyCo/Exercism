using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var from = "x";
        var to = "sibling-1";
        var tree = new Tree("grandparent",
                        new Tree("parent",
                            new Tree("x"),
                            new Tree("sibling-0"),
                            new Tree("sibling-1")
                        )
                    );
        var expected = new[] { "x", "parent", "sibling-1" };
        //var path = Pov.PathTo(from, to, tree);

        var path = Pov.Path("x", tree);

        Console.WriteLine(String.Join("->", path));
        Console.ReadKey(false);
    }
}