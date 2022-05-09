namespace Linq.EqualityComparers
{
    /// <summary>
    /// Compares two strings to see if they are anagrams.
    /// Anagrams are pairs of words formed from the same letters.
    /// </summary>
    public class AnagramEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return GetCanonicalString(x) == GetCanonicalString(y);
        }

        public int GetHashCode(string obj)
        {
            return GetCanonicalString(obj).GetHashCode(StringComparison.InvariantCulture);
        }

        private static string GetCanonicalString(string word)
        {
            char[] wordChars = word.ToCharArray();
            Array.Sort<char>(wordChars);
            return new string(wordChars);
        }
    }
}
