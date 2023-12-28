using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    /// <summary>
    /// Considers how to create sequences of integers (methods 'Empty', 'Range', and 'Repeat') in LINQ queries.
    /// Generation Methods: void → <see cref="IEnumerable{TResult}"/>
    /// Generation refers to creating a new sequence of values.
    /// </summary>
    public static class GenerationOperations
    {
        /// <summary>
        /// Creates an empty sequence of integral numbers.
        /// </summary>
        /// <returns>Empty sequence of integral numbers.</returns>
        public static IEnumerable<int> EmptySequence()
        {
            IEnumerable<int> sequence = Enumerable.Empty<int>();
            return sequence;
        }

        /// <summary>
        /// Generates a sequence of integral numbers within a specified range with additional information about their parity-oddness.
        /// </summary>
        /// <returns> The sequence of integral numbers in the specified range with additional information about their parity-oddness.
        /// </returns>
        public static IEnumerable<(int number, string oddEven)> RangeOfIntegers()
        {
            int start = 100;
            int end = 119;
            var sequence = Enumerable
                .Range(start, end - start + 1)
                .Select(n => (n, n % 2 == 0 ? "even" : "odd"));
            return sequence;
        }

        /// <summary>
        /// Generates a sequence that contains one repeated value.
        /// </summary>
        /// <returns>The sequence that contains one repeated value. </returns>
        public static IEnumerable<int> RepeatNumber()
        {
            int number = 7;
            IEnumerable<int> sequence = Enumerable.Repeat(number, 10);
            return sequence;
        }
    }
}
