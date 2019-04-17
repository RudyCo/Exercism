using System;
using System.Collections.Generic;
using System.Linq;

public class Tree
{
    internal readonly string value;
    internal Tree parent;
    internal readonly Tree[] children;

    public Tree(string value, params Tree[] children)
    {
        this.value = value;
        this.children = children;

        foreach (var child in children)
        {
            child.parent = this;
        }
    }
}

public static class Pov
{
    public static Tree FromPov(Tree tree, string from)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static IEnumerable<string> PathTo(string from, string to, Tree tree)
    {
        var pathFrom = PathTo(from, tree).ToList();
        if (pathFrom.Count < 1) throw new ArgumentException();
        var pathTo = PathTo(to, tree).ToList();
        if (pathTo.Count < 1) throw new ArgumentException();

        string common = pathTo[0];
        while (pathFrom.Count > 0 && pathTo.Count > 0 && pathFrom[0] == pathTo[0])
        {
            common = pathTo[0];
            pathFrom.Remove(pathFrom[0]);
            pathTo.Remove(pathTo[0]);
        }
        pathFrom.Reverse();
        return pathFrom.Concat(new[] { common }).Concat(pathTo);
    }

    public static IEnumerable<string> PathTo(string node, Tree tree)
    {
        if (tree.value == node) yield return node;

        foreach (var child in tree.children)
        {
            var path = PathTo(node, child);
            if (path.Any())
            {
                yield return tree.value;
                foreach (var p in path)
                {
                    yield return p;
                }
                yield break;
            }
        }
    }
}