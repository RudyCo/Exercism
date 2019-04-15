using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly SortedList<string, int> students = new SortedList<string, int>();

    public void Add(string student, int grade)
    {
        if (students.ContainsKey(student)) { throw new ArgumentException($"{student} already in the list!"); }

        students.Add(student, grade);
    }

    public IEnumerable<string> Roster()
    {
        return students.OrderBy(x => x.Value).Select(x => x.Key);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return students.Where(x => x.Value == grade).Select(x => x.Key);
    }
}