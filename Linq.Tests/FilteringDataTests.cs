using Linq.DataSources;
using NUnit.Framework;
using static Linq.FilteringData;

namespace Linq.Tests
{
    [TestFixture]
    public class FilteringDataTests
    {
        [Test]
        public void LowNumbersTest()
        {
            var expected = new[] { 4, 1, 3, 2, 0 };
            CollectionAssert.AreEqual(expected, LowNumbers());
        }

        [Test]
        public void ProductsOutOfStockTest()
        {
            var expected = new[]
            {
                new Product
                {
                    ProductId = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
                    UnitPrice = 21.3500m, UnitsInStock = 0,
                },
                new Product
                {
                    ProductId = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry", UnitPrice = 39.0000m,
                    UnitsInStock = 0,
                },
                new Product
                {
                    ProductId = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry",
                    UnitPrice = 123.7900m, UnitsInStock = 0,
                },
                new Product
                {
                    ProductId = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products",
                    UnitPrice = 12.5000m, UnitsInStock = 0,
                },
                new Product
                {
                    ProductId = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry", UnitPrice = 32.8000m,
                    UnitsInStock = 0,
                },
            };

            CollectionAssert.AreEqual(expected, ProductsOutOfStock());
        }

        [Test]
        public void ExpensiveProductsInStockTest()
        {
            var expected = new[]
            {
                new Product
                {
                    ProductId = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry", UnitPrice = 97.0000m,
                    UnitsInStock = 29,
                },
                new Product
                {
                    ProductId = 18, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.5000m,
                    UnitsInStock = 42,
                },
                new Product
                {
                    ProductId = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections",
                    UnitPrice = 81.0000m, UnitsInStock = 40,
                },
                new Product
                {
                    ProductId = 38, ProductName = "Côte de Blaye", Category = "Beverages", UnitPrice = 263.5000m,
                    UnitsInStock = 17,
                },
                new Product
                {
                    ProductId = 51, ProductName = "Manjimup Dried Apples", Category = "Produce", UnitPrice = 53.0000m,
                    UnitsInStock = 20,
                },
                new Product
                {
                    ProductId = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products",
                    UnitPrice = 55.0000m, UnitsInStock = 79,
                },
            };

            CollectionAssert.AreEqual(expected, ExpensiveProductsInStock());
        }

        [Test]
        public void IndexedWhereTest()
        {
            var expected = new[]
            {
                "five", "six", "seven", "eight", "nine",
            };

            CollectionAssert.AreEqual(expected, IndexedWhere());
        }
    }
}
