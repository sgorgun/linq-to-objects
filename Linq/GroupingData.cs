using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Linq.DataSources;
using Linq.EqualityComparers;

namespace Linq
{
    /// <summary>
    /// Considers how to group elements of sequences into buckets ( `group by` and `into` keywords, methods GroupBy, GroupJoin ) in LINQ queries.
    /// Grouping definition: <see cref="IEnumerable{TSource}"/> → <see cref="IEnumerable{IGrouping{TKey,TElement}}"/>
    /// Grouping refers to the operation of putting data into groups so that the elements in each group share a common attribute.
    /// </summary>
    public static class GroupingData
    {
        /// <summary>
        /// Partitions a list of words by their first letter ans sorts by it.
        /// </summary>
        /// <returns>Sorted by key (first letter) sequence of words grouped by first letter.</returns>
        public static IEnumerable<IGrouping<char, string>> GroupByProperty()
        {
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            var query = words
                .GroupBy(x => x.First())
                .OrderBy(g => g.Key);
            return query;
        }

        /// <summary>
        /// Groups elements on the remainder of an integer when dividing it by 5.
        /// </summary>
        /// <returns>The sequence of pairs: the remainder of an integer when dividing it by 5 and the numbers with a given remainder.</returns>
        public static IEnumerable<(int remainder, IEnumerable<int> numbers)> Grouping()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var query = numbers
                .GroupBy(x => x % 5)
                .Select(g => (remainder: g.Key, numbers: g.AsEnumerable()));
            return query;
        }

        /// <summary>
        /// Partitions a list of products by category.
        /// </summary>
        /// <returns>The sequences of products grouped by categories in which the number of products is less than or equal to 7.</returns>
        public static IEnumerable<(string category, IEnumerable<string> productsName)> GroupByCategory()
        {
            List<Product> products = Products.ProductList;

            var query = products
                .GroupBy(g => g.Category)
                .Where(p => p.Count() <= 7)
                .Select(g => (category: g.Key, productsName: g.Select(x => x.ProductName)));
            return query;
        }

        /// <summary>
        /// Partitions a list of words by custom comparer <see cref="AnagramEqualityComparer"/>.
        /// </summary>
        /// <returns>The sequences of words grouped by anagram comparer.</returns>
        public static IEnumerable<IGrouping<string, string>> GroupByCustomComparer()
        {
            string[] anagrams = { "from   ", "  mane", " salt", " earn ", "name   ", "  last   ", " near ", " form  ", "mean" };

            var query = anagrams
                .GroupBy(x => x.Trim(), new AnagramEqualityComparer());
            return query;
        }

        /// <summary>
        /// Partitions a list of words by custom comparer <see cref="AnagramEqualityComparer"/>.
        /// </summary>
        /// <returns>The sequences of words in upper case grouped by anagram comparer.</returns>
        public static IEnumerable<IGrouping<string, string>> NestedGroupByCustom()
        {
            string[] anagrams = { "from   ", "  mane", " salt", " earn ", "name   ", "  last   ", " near ", " form  ", "mean" };

            var groupedAnagrams = anagrams
                .Select(word => new { Key = word.Trim(), Value = word.ToUpperInvariant() })
                .GroupBy(x => x.Key, x => x.Value, new AnagramEqualityComparer());
            return groupedAnagrams;
        }
    }
}
