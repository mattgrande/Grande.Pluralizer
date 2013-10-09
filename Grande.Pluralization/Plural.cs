using System;
using System.Text.RegularExpressions;

namespace Grande.Pluralization
{
    internal class Plural
    {
        public Regex FindPattern { get; set; }
        public String ReplacePattern { get; set; }

        public Plural(string findPattern, String replacePattern)
        {
            FindPattern = new Regex(findPattern, RegexOptions.IgnoreCase);
            ReplacePattern = replacePattern;
        }
    }
}