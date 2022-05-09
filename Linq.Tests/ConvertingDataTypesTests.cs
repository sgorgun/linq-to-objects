using NUnit.Framework;
using static Linq.ConvertingDataTypes;

namespace Linq.Tests
{
    [TestFixture]
    public class ConvertingDataTypesTests
    {
        [Test]
        public void ConvertToArrayTest()
        {
            var expected = new[] { 4.1, 2.9, 2.3, 1.9, 1.7 };

            CollectionAssert.AreEqual(expected, ConvertToArray());
        }

        [Test]
        public void ConvertToListTest()
        {
            var expected = new List<string> { "apple", "blueberry", "cherry" };

            CollectionAssert.AreEqual(expected, ConvertToList());
        }

        [Test]
        public void ConvertToDictionaryTest()
        {
            var expected = new Dictionary<string, (string name, int score)>
            {
                ["Alice"] = ("Alice", 50),
                ["Bob"] = ("Bob", 40),
                ["Cathy"] = ("Cathy", 45),
            };

            CollectionAssert.AreEqual(expected, ConvertToDictionary());
        }

        [Test]
        public void OfTypeDoublesTest()
        {
            var expected = new double[] { 1, 7 };

            CollectionAssert.AreEqual(expected, OfTypeDoubles());
        }
    }
}
