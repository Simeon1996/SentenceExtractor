using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Problem_4_Sentence_Extractor
{
    static void Main()
    {
        Console.WriteLine("Please, enter the wanted keyword: ");
        string keyword = Console.ReadLine();

        List<string> lister = new List<string>();

        Console.WriteLine("Enter your text: ");
        string text = Console.ReadLine();

        string sentencePattern = @"(\S.+?[.!?])(?=\s+|$)";

        Regex sentenceRgx = new Regex(sentencePattern);
        string keyWordPattern = string.Format(@"\b{0}\b", Regex.Escape(keyword));

        MatchCollection matchs = sentenceRgx.Matches(text);

        Console.WriteLine();

        foreach (var match in matchs)
        {
            string word = match.ToString();

            if (Regex.IsMatch(word, keyWordPattern))
            {
                Console.WriteLine(match);
            }
        }
    }

       
}