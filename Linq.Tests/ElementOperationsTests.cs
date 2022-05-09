using Linq.DataSources;
using NUnit.Framework;
using static Linq.ElementOperations;

namespace Linq.Tests
{
    [TestFixture]
    public class ElementOperationsTests
    {
        [Test]
        public void ElementOperationsTest()
        {
            var expected = new Product
            {
                ProductId = 11,
                ProductName = "Queso Cabrales",
                Category = "Dairy Products",
                UnitPrice = 21.0000M,
                UnitsInStock = 22,
            };

            Assert.AreEqual(expected, FirstElement());
        }

        [Test]
        public void FirstMatchingElementTest()
        {
            Assert.AreEqual("one", FirstMatchingElement());
        }

        [Test]
        public void MaybeFirstElementTest()
        {
            Assert.AreEqual(0, MaybeFirstElement());
        }

        [Test]
        public void MaybeFirstMatchingElementTest()
        {
            Assert.AreEqual(null, MaybeFirstMatchingElement());
        }

        [Test]
        public void ElementAtPositionTest()
        {
            Assert.AreEqual(8, ElementAtPosition());
        }

        [Test]
        public void LastMatchingElementTest()
        {
            Assert.AreEqual("four", LastMatchingElement());
        }

        [Test]
        public void MaybeLastElementTest()
        {
            Assert.AreEqual(0, MaybeLastElement());
        }

        [Test]
        public void SingleMoreThanOneMatchingElementTest()
        {
            Assert.Throws<InvalidOperationException>(() => SingleMoreThanOneMatchingElement());
        }

        [Test]
        public void SingleNoMatchingElementTest()
        {
            Assert.Throws<InvalidOperationException>(() => SingleNoMatchingElement());
        }

        [Test]
        public void MaybeSingleMatchingElementTest()
        {
            Assert.AreEqual(null, MaybeSingleMatchingElement());
        }
    }
}
