using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    /// <summary>
    /// Considers the differences between eager or lazy query execution.
    /// </summary>
    public static class QueryExecution
    {
        /// <summary>
        /// Finds all elements of an array more than 5. Implement as deferred query execution.
        /// </summary>
        /// <returns>All elements of an array more than 5.</returns>
        public static IEnumerable<int> DeferredExecution()
        {
            var numbers = new List<int> { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numberMore5 = numbers.Where(n => n > 5);

            numbers.Add(10);

            var result = new List<int>();

            foreach (var item in numberMore5)
            {
                result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// Finds all elements of an array more than 5. Implement as immediate query execution.
        /// </summary>
        /// <returns>All elements of an array more than 5.</returns>
        public static IEnumerable<int> ImmediateExecution()
        {
            var numbers = new List<int> { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numberMore5 = numbers.Where(n => n > 5).ToArray();

            numbers.Add(10);

            var result = new List<int>();

            foreach (var item in numberMore5)
            {
                result.Add(item);
            }

            return result;
        }
    }
}
