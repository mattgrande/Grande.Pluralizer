namespace Grande.Pluralization
{
    public static class PluralizerExtensions
    {
        /// <summary>
        /// Pluralizes a word if count > 1
        /// </summary>
        public static string Pluralize(this string singular, int count)
        {
            return Pluralizer.Pluralize(count, singular);
        }

        /// <summary>
        /// Pluralizes a word
        /// </summary>
        public static string Pluralize(this string singular)
        {
            return Pluralizer.Pluralize(2, singular);
        }
    }
}
