using NUnit.Framework;
using static Linq.GroupingData;

namespace Linq.Tests
{
    [TestFixture]
    public class GroupingDataTests
    {
        [Test]
        public void GroupByPropertyTest()
        {
            var expectedKeys = new[] { 'a', 'b', 'c' };

            var expected = new[]
            {
                new[] { "abacus", "apple" },
                new[] { "blueberry", "banana" },
                new[] { "chimpanzee", "cheese" },
            };

            CollectionAssert.AreEqual(expectedKeys, GroupByProperty().Select(g => g.Key));
            CollectionAssert.AreEqual(expected, GroupByProperty());
        }

        [Test]
        public void GroupingTest()
        {
            var expected = new[]
            {
                (0, new[] { 5, 0 }),
                (4, new[] { 4, 9 }),
                (1, new[] { 1, 6 }),
                (3, new[] { 3, 8 }),
                (2, new[] { 7, 2 }),
            };
            CollectionAssert.AreEqual(expected, Grouping());
        }

        [Test]
        public void GroupByCategoryTest()
        {
            var expected = new[]
            {
                ("Produce", new[]
                {
                    "Uncle Bob's Organic Dried Pears",
                    "Tofu",
                    "Rössle Sauerkraut",
                    "Manjimup Dried Apples",
                    "Longlife Tofu",
                }),
                ("Meat/Poultry", new[]
                {
                    "Mishi Kobe Niku",
                    "Alice Mutton",
                    "Thüringer Rostbratwurst",
                    "Perth Pasties",
                    "Tourtière",
                    "Pâté chinois",
                }),
                ("Grains/Cereals", new[]
                {
                    "Gustaf's Knäckebröd",
                    "Tunnbröd",
                    "Singaporean Hokkien Fried Mee",
                    "Filo Mix",
                    "Gnocchi di nonna Alice",
                    "Ravioli Angelo",
                    "Wimmers gute Semmelknödel",
                }),
            };

            CollectionAssert.AreEqual(expected, GroupByCategory());
        }

        [Test]
        public void GroupByCustomComparerTest()
        {
            var expectedKeys = new[] { "from", "mane", "salt", "earn" };

            var expected = new[]
            {
                new[] { "from   ", " form  " },
                new[] { "  mane", "name   ",  "mean" },
                new[] { " salt", "  last   " },
                new[] { " earn ", " near " },
            };
            CollectionAssert.AreEqual(expectedKeys, GroupByCustomComparer().Select(g => g.Key));
            CollectionAssert.AreEqual(expected, GroupByCustomComparer());
        }

        [Test]
        public void NestedGroupByCustomTest()
        {
            var expectedKeys = new[] { "from", "mane", "salt", "earn" };

            var expected = new[]
            {
                new[] { "FROM   ", " FORM  " },
                new[] { "  MANE", "NAME   ",  "MEAN" },
                new[] { " SALT", "  LAST   " },
                new[] { " EARN ", " NEAR " },
            };
            CollectionAssert.AreEqual(expectedKeys, NestedGroupByCustom().Select(g => g.Key));
            CollectionAssert.AreEqual(expected, NestedGroupByCustom());
        }
    }
}
