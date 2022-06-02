using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Test20220508
{
    internal class Solution
    {
        public static string solution(string S)
        {

            // write your code in C# 6.0 with .NET 4.5 (Mono)
            char[] vowles = "aeiou".ToCharArray();
            var vowel = S.ToLower().ToCharArray().Where(s => s == vowles[0] || s == vowles[1] || s == vowles[2] || s == vowles[3] || s == vowles[4]
            ).GroupBy(s => s).Select(group => new { Value = group.Key, Count = group.Count() }).OrderBy(group => group.Value);
            int highest = 0;
            foreach (var s in vowel)
            {
                if (s.Count > highest)
                { highest = s.Count; }
            }
            string resultString = string.Empty;
            string spacer = string.Empty;
            foreach (var s in vowel.Where(v => v.Count == highest).Take(1))
            {
                resultString += spacer + s.Value;
                spacer = ", ";
            }
            //string.Format("{0} appears {1} time{2}", resultString, vowel.Count, vowel.Count > 0 ? "s" : string.Empty);
            return resultString;
        }
        public static string solution2(string S)
        {
            char[] skipThem = { ' ', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '{', '}', '|', '`', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '=', ',', '.', '/', ';', '\'', '[', ']', '\\', ':', '"', '<', '>', '?' };
            var strings = S.ToLower().Split(skipThem, System.StringSplitOptions.RemoveEmptyEntries).GroupBy(s => s).Select(group => new { Value = group.Key, Count = group.Count() }).OrderBy(group => group.Value);
            string resultString = string.Empty;
            string spacer = string.Empty;
            foreach (var s in strings)
            {
                resultString += spacer + s.Count.ToString() + " " + s.Value;
                spacer = ", ";
            }
            return resultString;
        }
        public static string solution3(string S)
        {
            char[] skipThem = { ' ', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '{', '}', '|', '`', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '=', ',', '.', '/', ';', '\'', '[', ']', '\\', ':', '"', '<', '>', '?' };
            var strings = S.ToLower().Split(skipThem, System.StringSplitOptions.RemoveEmptyEntries).GroupBy(s => s).Select(group => new { Value = group.Key, Count = group.Count() }).OrderBy(group => group.Value);
            string resultString = string.Empty;
            string spacer = string.Empty;
            foreach (var s in strings)
            {
                resultString += spacer + s.Count.ToString() + " " + s.Value;
                spacer = ", ";
            }
            return resultString;
        }
        public static string solution4(string S)
        {
            List<char> skipThem = new();
            char c = char.MinValue;
            while (c++ < char.MaxValue)
            {
                if (char.IsAscii(c) && (char.IsSymbol(c) || char.IsDigit(c) || char.IsPunctuation(c) || char.IsWhiteSpace(c)))
                    skipThem.Add(c);
            }
            var strings = S.ToLower().Split(skipThem.ToArray(), StringSplitOptions.RemoveEmptyEntries).GroupBy(s => s).Select(group => new { Value = group.Key, Count = group.Count() }).OrderBy(group => group.Value);
            string resultString = string.Empty;
            string spacer = string.Empty;
            foreach (var s in strings)
            {
                resultString += spacer + s.Count.ToString() + " " + s.Value;
                spacer = ", ";
            }
            return resultString;
        }
        public static string solution5(string S)
        {
            Regex rx = new Regex(@"[,.;:/? !()\\-]+", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var strings = rx.Split(S.ToLower()).Where(s => s != string.Empty).GroupBy(s => s).Select(group => new { Value = group.Key, Count = group.Count() }).OrderBy(group => group.Value);
            string resultString = string.Empty;
            string spacer = string.Empty;
            foreach (var s in strings)
            {
                resultString += spacer + s.Count.ToString() + " " + s.Value;
                spacer = ", ";
            }
            return resultString;
        }

    }
}