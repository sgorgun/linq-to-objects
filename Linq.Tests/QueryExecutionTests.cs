using NUnit.Framework;
using static Linq.QueryExecution;

namespace Linq.Tests
{
    [TestFixture]
    public class QueryExecutionTests
    {
        [Test]
        public void DeferredExecutionTest()
        {
            var expected = new List<int> { 9, 8, 6, 7, 10 };

            CollectionAssert.AreEqual(expected, DeferredExecution());
        }

        [Test]
        public void ImmediateExecutionTest()
        {
            var expected = new List<int> { 9, 8, 6, 7 };

            CollectionAssert.AreEqual(expected, ImmediateExecution());
        }
    }
}
