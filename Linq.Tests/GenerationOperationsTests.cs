using NUnit.Framework;
using static Linq.GenerationOperations;

namespace Linq.Tests
{
    public class GenerationOperationsTests
    {
        [Test]
        public void EmptySequenceTest()
        {
            Assert.IsTrue(!EmptySequence().Any());
        }

        [Test]
        public void RangeOfIntegersTests()
        {
            var expected = new[]
            {
                (100, "even"),
                (101, "odd"),
                (102, "even"),
                (103, "odd"),
                (104, "even"),
                (105, "odd"),
                (106, "even"),
                (107, "odd"),
                (108, "even"),
                (109, "odd"),
                (110, "even"),
                (111, "odd"),
                (112, "even"),
                (113, "odd"),
                (114, "even"),
                (115, "odd"),
                (116, "even"),
                (117, "odd"),
                (118, "even"),
                (119, "odd"),
            };
            CollectionAssert.AreEqual(expected, RangeOfIntegers());
        }

        [Test]
        public void RepeatNumberTests()
        {
            var expected = new[]
            {
                7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
            };

            CollectionAssert.AreEqual(expected, RepeatNumber());
        }
    }
}
