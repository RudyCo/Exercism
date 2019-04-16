using System;
using System.Linq;
using System.Collections.Generic;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        var proteins = new List<string>();
        bool stopFound = false;
        for (int i = 0; i <= strand.Length - 3 && !stopFound; i = i + 3)
        {
            var test = strand.Substring(i, 3);
            switch (test)
            {
                case "AUG":
                    proteins.Add("Methionine"); break;
                case "UUU":
                case "UUC":
                    proteins.Add("Phenylalanine"); break;
                case "UUA":
                case "UUG":
                    proteins.Add("Leucine"); break;
                case "UCU":
                case "UCC":
                case "UCA":
                case "UCG":
                    proteins.Add("Serine"); break;
                case "UAU":
                case "UAC":
                    proteins.Add("Tyrosine"); break;
                case "UGU":
                case "UGC":
                    proteins.Add("Cysteine"); break;
                case "UGG":
                    proteins.Add("Tryptophan"); break;
                case "UAA":
                case "UAG":
                case "UGA":
                    stopFound = true; break;
            }
        }
        return proteins.ToArray();
    }
}