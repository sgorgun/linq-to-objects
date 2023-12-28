#pragma warning disable S6603, S6605, CA1307
using System;
using System.Collections.Generic;
using System.Linq;
using Linq.DataSources;

namespace Linq
{
    /// <summary>
    /// Considers the use quantifier operators (methods 'All', 'Any', 'SequenceEqual' and `Contains`) in LINQ queries.
    /// Quantifier operation definition:
    /// <see cref="IEnumerable{T}"/> → bool
    /// Quantifier operations return a Boolean value that indicates whether some or all of the elements
    /// in a sequence satisfy a condition.
    /// </summary>
    public static class QuantifierOperations
    {
        /// <summary>
        /// Checks if two sequences match on all elements in the same order.
        /// </summary>
        /// <returns>true.</returns>
        public static bool EqualSequence()
        {
            var wordsA = new[] { "cherry", "apple", "blueberry" };
            var wordsB = new[] { "cherry", "apple", "blueberry" };

            var match = wordsA.All(a => wordsB.Contains(a));
            return match;
        }

        /// <summary>
        /// Checks if two sequences match on all elements in the same order.
        /// </summary>
        /// <returns>false.</returns>
        public static bool NotEqualSequence()
        {
            var wordsA = new[] { "cherry", "apple", "blueberry" };
            var wordsB = new[] { "apple", "blueberry", "cherry" };

            var match = wordsA.SequenceEqual(wordsB);
            return match;
        }

        /// <summary>
        /// Determines if there is at least one word in the list containing “ei”.
        /// </summary>
        /// <returns>true.</returns>
        public static bool AnyMatchingElements()
        {
            string[] words = { "believe", "relief", "receipt", "field" };

            var contains = words.Any(x => x.Contains("ei"));
            return contains;
        }

        /// <summary>
        /// Creates product categories with zero units in stock.
        /// </summary>
        /// <returns>Grouped product categories with zero units in stock.</returns>
        public static IEnumerable<(string category, IEnumerable<Product> products)> GroupedAnyMatchedElements()
        {
            List<Product> products = Products.ProductList;

            var query = products
                .GroupBy(g => g.Category)
                .Where(p => p.Any(x => x.UnitsInStock == 0))
                .Select(g => (category: g.Key, products: g.Select(x => x)));
            return query;
        }

        /// <summary>
        /// Determines whether all elements are odd.
        /// </summary>
        /// <returns>true.</returns>
        public static bool AllMatchedElements()
        {
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };

            var isOdd = numbers.All(x => x % 2 != 0);
            return isOdd;
        }

        /// <summary>
        /// Creates product categories with more than zero units in stock.
        /// </summary>
        /// <returns>Grouped product categories with more than zero units in stock.</returns>
        public static IEnumerable<(string category, IEnumerable<Product> products)> GroupedAllMatchedElements()
        {
            List<Product> products = Products.ProductList;

            var moreThanZero = products
                .GroupBy(g => g.Category)
                .Where(p => p.All(x => x.UnitsInStock > 0))
                .Select(g => (category: g.Key, products: g.Select(x => x)));

            return moreThanZero;
        }

        /// <summary>
        /// Determines whether the sequence contains the given element.
        /// </summary>
        /// <returns>true.</returns>
        public static bool HasAThree()
        {
            int[] numbers = { 2, 3, 4 };

            var contains = numbers.Contains(3);
            return contains;
        }
    }
}
