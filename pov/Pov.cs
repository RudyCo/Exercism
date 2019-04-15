using System;
using System.Diagnostics;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Tree
{
    public string Value { get; private set; }
    public Tree[] Children { get; private set; }

    public Tree(string value, params Tree[] children)
    {
        this.Value = value;
        this.Children = children;
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
        var fromPath = Path(from, tree);
        if (fromPath == null) throw new ArgumentException("Source does not exist!");

        var toPath = Path(to, tree);
        if (toPath == null) throw new ArgumentException("Source does not exist!");

        int min = Math.Min(fromPath.Count(), toPath.Count());

        int i = 0;

        while (i < min && fromPath.ToList()[i] == toPath.ToList()[i]) { i++; }
        var path = new List<string>();
        i--;

        path = fromPath.Skip(i).Reverse().Concat(toPath.Skip(i+1)).ToList();

        Debug.WriteLine("From:{0}", string.Join("-", fromPath));
        Debug.WriteLine("To  :{0}", string.Join("-", toPath));
        Debug.WriteLine("Path:{0}", string.Join("-", path));


        return path;
    }


    public static IEnumerable<string> Path(string node, Tree tree)
    {

       

        bool found = false;
        foreach (var child in tree.Children)
        {
            foreach (var subnode in Path(node, child))
            {
               // yield return tree.Value;
                yield return subnode;
                found = true;
            }                
        }
        if (node == tree.Value)
            yield return tree.Value;
        if (found)  yield return tree.Value;
    }

    //public static IEnumerable<string> PathTo(string from, string to, Tree tree)
    //{
    //    if (tree.Value == from)
    //    {
    //        yield return tree.Value;
    //    }

    //    foreach (var child in tree.Children)
    //    {
    //        var fromList = PathTo(from, tree.Value, child).ToList();
    //        var toList = PathTo(tree.Value, to, child).ToList();

    //        foreach (var x in fromList)
    //        {
    //            yield return x;
    //        }

    //        if (fromList.Any() || toList.Any())
    //        {
    //            if (fromList.Any() && toList.Any())
    //            {
    //                if (fromList.Last() != toList.First())
    //                {
    //                    yield return tree.Value;
    //                }
    //            }
    //            else
    //            {
    //                if (fromList.Any())
    //                {
    //                    yield return tree.Value;
    //                }
    //                else if (toList.Any())
    //                {
    //                    yield return tree.Value;
    //                }
    //            }
    //        }

    //        foreach (var x in toList)
    //        {
    //            yield return x;
    //        }
    //    }

    //    if (tree.Value == to)
    //    {
    //        yield return tree.Value;
    //    }
    //}


}