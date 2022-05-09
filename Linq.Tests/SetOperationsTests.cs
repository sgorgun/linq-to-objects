using NUnit.Framework;
using static Linq.SetOperations;

namespace Linq.Tests
{
    [TestFixture]
    public class SetOperationsTests
    {
        [Test]
        public void DistinctTest()
        {
            var expected = new[] { 2, 3, 5 };

            CollectionAssert.AreEqual(expected, Distinct());
        }

        [Test]
        public void DistinctPropertyValuesTest()
        {
            var expected = new[]
            {
                "Beverages",
                "Condiments",
                "Produce",
                "Meat/Poultry",
                "Seafood",
                "Dairy Products",
                "Confections",
                "Grains/Cereals",
            };

            CollectionAssert.AreEqual(expected, DistinctPropertyValues());
        }

        [Test]
        public void UnionTest()
        {
            var expected = new[]
            {
                0, 2, 4, 5, 6, 8, 9, 1, 3, 7,
            };

            CollectionAssert.AreEqual(expected, Union());
        }

        [Test]
        public void UnionOfQueryResultsTest()
        {
            var expected = new[]
            {
                'C', 'A', 'G', 'U', 'N', 'M', 'I', 'Q', 'K', 'T', 'P', 'S', 'R', 'B', 'J', 'Z', 'V', 'F', 'E', 'W', 'L',
                'O', 'D', 'H',
            };

            CollectionAssert.AreEqual(expected, UnionOfQueryResults());
        }

        [Test]
        public void IntersectTest()
        {
            var expected = new[] { 5, 8 };

            CollectionAssert.AreEqual(expected, Intersect());
        }

        [Test]
        public void IntersectQueryResultsTest()
        {
            var expected = new[] { 'C', 'A', 'G', 'N', 'M', 'I', 'Q', 'K', 'T', 'P', 'S', 'R', 'B', 'V', 'F', 'E', 'W', 'L', 'O' };

            CollectionAssert.AreEqual(expected, IntersectQueryResults());
        }

        [Test]
        public void DifferenceOfSetsTest()
        {
            var expected = new[] { 0, 2, 4, 6, 9 };

            CollectionAssert.AreEqual(expected, DifferenceOfSets());
        }

        [Test]
        public void DifferenceOfQueriesTest()
        {
            var expected = new[] { 'U', 'J', 'Z' };

            CollectionAssert.AreEqual(expected, DifferenceOfQueries());
        }
    }
}
