using NUnit.Framework;
using static Linq.AggregationOperations;

namespace Linq.Tests
{
    [TestFixture]
    public class AggregationOperationsTests
    {
        [Test]
        public void CountNumbersTest()
        {
            Assert.AreEqual(5, CountNumbers());
        }

        [Test]
        public void CountOddNumbersTest()
        {
            Assert.AreEqual(5, CountOddNumbers());
        }

        [Test]
        public void ProductsInCategoryCountTest()
        {
            var expected = new[]
            {
                ("Beverages", 12),
                ("Condiments", 12),
                ("Produce", 5),
                ("Meat/Poultry", 6),
                ("Seafood", 12),
                ("Dairy Products", 10),
                ("Confections", 13),
                ("Grains/Cereals", 7),
            };

            CollectionAssert.AreEqual(expected, ProductsInCategoryCount());
        }

        [Test]
        public void CustomersOrdersCountTest()
        {
            var expected = new[]
            {
                ("ALFKI", 6),
                ("ANATR", 4),
                ("ANTON", 7),
                ("AROUT", 13),
                ("BERGS", 18),
                ("BLAUS", 7),
                ("BLONP", 11),
                ("BOLID", 3),
                ("BONAP", 17),
                ("BOTTM", 14),
                ("BSBEV", 10),
                ("CACTU", 6),
                ("CENTC", 1),
                ("CHOPS", 8),
                ("COMMI", 5),
                ("CONSH", 3),
                ("DRACD", 6),
                ("DUMON", 4),
                ("EASTC", 8),
                ("ERNSH", 30),
                ("FAMIA", 7),
                ("FISSA", 0),
                ("FOLIG", 5),
                ("FOLKO", 19),
                ("FRANK", 15),
                ("FRANR", 3),
                ("FRANS", 6),
                ("FURIB", 8),
                ("GALED", 5),
                ("GODOS", 10),
                ("GOURL", 9),
                ("GREAL", 11),
                ("GROSR", 2),
                ("HANAR", 14),
                ("HILAA", 18),
                ("HUNGC", 5),
                ("HUNGO", 19),
                ("ISLAT", 10),
                ("KOENE", 14),
                ("LACOR", 4),
                ("LAMAI", 14),
                ("LAUGB", 3),
                ("LAZYK", 2),
                ("LEHMS", 15),
                ("LETSS", 4),
                ("LILAS", 14),
                ("LINOD", 12),
                ("LONEP", 8),
                ("MAGAA", 10),
                ("MAISD", 7),
                ("MEREP", 13),
                ("MORGK", 5),
                ("NORTS", 3),
                ("OCEAN", 5),
                ("OLDWO", 10),
                ("OTTIK", 9),
                ("PARIS", 0),
                ("PERIC", 6),
                ("PICCO", 10),
                ("PRINI", 6),
                ("QUEDE", 9),
                ("QUEEN", 13),
                ("QUICK", 28),
                ("RANCH", 5),
                ("RATTC", 18),
                ("REGGC", 12),
                ("RICAR", 11),
                ("RICSU", 10),
                ("ROMEY", 5),
                ("SANTG", 6),
                ("SAVEA", 31),
                ("SEVES", 9),
                ("SIMOB", 7),
                ("SPECD", 4),
                ("SPLIR", 9),
                ("SUPRD", 12),
                ("THEBI", 4),
                ("THECR", 3),
                ("TOMSP", 5),
                ("TORTU", 10),
                ("TRADH", 7),
                ("TRAIH", 3),
                ("VAFFE", 11),
                ("VICTE", 10),
                ("VINET", 4),
                ("WANDK", 10),
                ("WARTH", 15),
                ("WELLI", 9),
                ("WHITC", 14),
                ("WILMK", 8),
                ("WOLZA", 7),
            };

            CollectionAssert.AreEqual(expected, CustomersOrdersCount());
        }

        [Test]
        public void SumTest()
        {
            Assert.AreEqual(45, Sum());
        }

        [Test]
        public void SumByLengthTest()
        {
            Assert.AreEqual(20, SumByLength());
        }

        [Test]
        public void TotalUnitsInStockTest()
        {
            var expected = new[]
            {
                ("Beverages", 559),
                ("Condiments", 507),
                ("Produce", 100),
                ("Meat/Poultry", 165),
                ("Seafood", 701),
                ("Dairy Products", 393),
                ("Confections", 386),
                ("Grains/Cereals", 308),
            };

            CollectionAssert.AreEqual(expected, TotalUnitsInStock());
        }

        [Test]
        public void MinTest()
        {
            Assert.AreEqual(0, Min());
        }

        [Test]
        public void MinByLengthTest()
        {
            Assert.AreEqual(5, MinByLength());
        }

        [Test]
        public void GetCheapestPriceTest()
        {
            var expected = new[]
            {
                ("Beverages", 4.5000m),
                ("Condiments", 10.0000m),
                ("Produce", 10.0000m),
                ("Meat/Poultry", 7.4500m),
                ("Seafood", 6.0000m),
                ("Dairy Products", 2.5000m),
                ("Confections", 9.2000m),
                ("Grains/Cereals", 7.0000m),
            };

            CollectionAssert.AreEqual(expected, GetCheapestPrice());
        }

        [Test]
        public void MaxByLengthTest()
        {
            Assert.AreEqual(9, MaxByLength());
        }

        [Test]
        public void GetMostExpensivePriceTest()
        {
            var expected = new[]
            {
                ("Beverages", 263.5000m),
                ("Condiments", 43.9000m),
                ("Produce", 53.0000m),
                ("Meat/Poultry", 123.7900m),
                ("Seafood", 62.5000m),
                ("Dairy Products", 55.0000m),
                ("Confections", 81.0000m),
                ("Grains/Cereals", 38.0000m),
            };

            CollectionAssert.AreEqual(expected, GetMostExpensivePrice());
        }

        [Test]
        public void AverageTest()
        {
            Assert.AreEqual(4.5, Average());
        }

        [Test]
        public void AverageByLengthTest()
        {
            Assert.AreEqual(6.666666666666667, AverageByLength());
        }

        [Test]
        public void AveragePriceTest()
        {
            IEnumerable<(string customerId, decimal orderCount)> expected = new (string, decimal)[]
            {
                ("Beverages", 37.979166666666666666666666667m),
                ("Condiments", 23.0625m),
                ("Produce", 32.3700m),
                ("Meat/Poultry", 54.006666666666666666666666667m),
                ("Seafood", 20.6825m),
                ("Dairy Products", 28.7300m),
                ("Confections", 25.1600m),
                ("Grains/Cereals", 20.2500m),
            };
            CollectionAssert.AreEqual(expected, AveragePrice());
        }

        [Test]
        public void AggregateTest()
        {
            Assert.AreEqual(88.33080999999999, Aggregate());
        }

        [Test]
        public void SeededAggregateTest()
        {
            Assert.AreEqual(20, SeededAggregate());
        }
    }
}
