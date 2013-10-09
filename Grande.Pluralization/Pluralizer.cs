using System.Collections.Generic;
using System.Linq;

namespace Grande.Pluralization
{
    public static class Pluralizer
    {
        #region Fields
        private static readonly HashSet<string> Unpluralizables = new HashSet<string>
                                                                      {
                                                                          "equipment",
                                                                          "information",
                                                                          "rice",
                                                                          "money",
                                                                          "species",
                                                                          "series",
                                                                          "fish",
                                                                          "sheep",
                                                                          "deer",
                                                                          "aircraft",
                                                                          "trout",
                                                                          "swine"
                                                                      };
        private static readonly IList<Plural> Pluralizations = new List<Plural>
        {
            // Start with the rarest cases, and move to the most common
            new Plural("person", "people"),
            new Plural("^ox$", "oxen"),
            new Plural("^criterion$", "criteria"),
            new Plural("child$", "children"),
            new Plural("foot$", "feet"),
            new Plural("tooth$", "teeth"),
            new Plural("^goose$", "geese"),
            // And now the more standard rules.
            new Plural("(.*[^af])fe?$", "$1ves"),         // ie, wolf, wife, but not giraffe, gaffe, safe
            new Plural("(hu|talis|otto|Ger|Ro|brah)man$", "$1mans"), // Exceptions for man -> men
            new Plural("(.*)man$", "$1men"),
            new Plural("(.+[^aeiou])y$", "$1ies"),
            new Plural("(.+zz)$", "$1es"),        // Buzz -> Buzzes
            new Plural("(.+z)$", "$1zes"),        // Quiz -> Quizzes
            new Plural("([m|l])ouse$", "$1ice"),
            new Plural("(append|matr|ind)(e|i)x$", @"$1ices"),    // ie, Matrix, Index
            new Plural("(octop|vir|radi|fung)us$", "$1i"),
            new Plural("(phyl|milleni|spectr)um$", "$1a"),
            new Plural("(cris|ax)is$", @"$1es"),
            new Plural("(.+(s|x|sh|ch))$", @"$1es"),
            new Plural("(.+)ies$", @"$1ies"),
            new Plural("(.+)", @"$1s")
        }; 
        #endregion

        /// <summary>
        /// Pluralize a word based on standard English Pluralization Rules (ha ha).
        /// </summary>
        /// <param name="count"></param>
        /// <param name="singular"></param>
        /// <returns></returns>
        public static string Pluralize(int count, string singular)
        {
            if (count == 1 || singular.Trim().Length == 0)
                return singular;

            if (Unpluralizables.Contains(singular))
                return singular;

            var pluralization = Pluralizations.FirstOrDefault(p => p.FindPattern.IsMatch(singular));

            if (pluralization == null)  // No pluralization found; just use an s at the end.
                return singular + "s";
            return pluralization.FindPattern.Replace(singular, pluralization.ReplacePattern);
        }

        /// <summary>
        /// Pluralizes a word with an override.
        /// 
        /// Pluralizer.Pluralize(2, "box");         // returns "boxes".
        /// Pluralizer.Pluralize(2, "box", "boxen); // returns "boxen".
        /// </summary>
        /// <param name="count"></param>
        /// <param name="singular"></param>
        /// <param name="defaultPluralizationOverride"></param>
        /// <returns></returns>
        public static string Pluralize(int count, string singular, string defaultPluralizationOverride)
        {
            if (count == 1 || singular.Trim().Length == 0)
                return singular;
            return defaultPluralizationOverride;
        }
    }
}
