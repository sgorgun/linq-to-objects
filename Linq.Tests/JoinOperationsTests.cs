using Linq.DataSources;
using NUnit.Framework;
using static Linq.JoinOperations;

namespace Linq.Tests
{
    [TestFixture]
    public class JoinOperationsTests
    {
        [Test]
        public void JoinQueryTest()
        {
            var expected = new[]
            {
                ("Beverages", "Chai"),
                ("Beverages", "Chang"),
                ("Beverages", "Guaraná Fantástica"),
                ("Beverages", "Sasquatch Ale"),
                ("Beverages", "Steeleye Stout"),
                ("Beverages", "Côte de Blaye"),
                ("Beverages", "Chartreuse verte"),
                ("Beverages", "Ipoh Coffee"),
                ("Beverages", "Laughing Lumberjack Lager"),
                ("Beverages", "Outback Lager"),
                ("Beverages", "Rhönbräu Klosterbier"),
                ("Beverages", "Lakkalikööri"),
                ("Condiments", "Aniseed Syrup"),
                ("Condiments", "Chef Anton's Cajun Seasoning"),
                ("Condiments", "Chef Anton's Gumbo Mix"),
                ("Condiments", "Grandma's Boysenberry Spread"),
                ("Condiments", "Northwoods Cranberry Sauce"),
                ("Condiments", "Genen Shouyu"),
                ("Condiments", "Gula Malacca"),
                ("Condiments", "Sirop d'érable"),
                ("Condiments", "Vegie-spread"),
                ("Condiments", "Louisiana Fiery Hot Pepper Sauce"),
                ("Condiments", "Louisiana Hot Spiced Okra"),
                ("Condiments", "Original Frankfurter grüne Soße"),
                ("Dairy Products", "Queso Cabrales"),
                ("Dairy Products", "Queso Manchego La Pastora"),
                ("Dairy Products", "Gorgonzola Telino"),
                ("Dairy Products", "Mascarpone Fabioli"),
                ("Dairy Products", "Geitost"),
                ("Dairy Products", "Raclette Courdavault"),
                ("Dairy Products", "Camembert Pierrot"),
                ("Dairy Products", "Gudbrandsdalsost"),
                ("Dairy Products", "Flotemysost"),
                ("Dairy Products", "Mozzarella di Giovanni"),
                ("Seafood", "Ikura"),
                ("Seafood", "Konbu"),
                ("Seafood", "Carnarvon Tigers"),
                ("Seafood", "Nord-Ost Matjeshering"),
                ("Seafood", "Inlagd Sill"),
                ("Seafood", "Gravad lax"),
                ("Seafood", "Boston Crab Meat"),
                ("Seafood", "Jack's New England Clam Chowder"),
                ("Seafood", "Rogede sild"),
                ("Seafood", "Spegesild"),
                ("Seafood", "Escargots de Bourgogne"),
                ("Seafood", "Röd Kaviar"),
            };

            CollectionAssert.AreEqual(expected, JoinQuery());
        }

        [Test]
        public void GroupJoinQueryTest()
        {
            var expected = new[]
            {
                ("Beverages", new Product[]
                {
                    new Product
                    {
                        ProductId = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.0000m,
                        UnitsInStock = 39,
                    },
                    new Product
                    {
                        ProductId = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.0000m,
                        UnitsInStock = 17,
                    },
                    new Product
                    {
                        ProductId = 24, ProductName = "Guaraná Fantástica", Category = "Beverages", UnitPrice = 4.5000m,
                        UnitsInStock = 20,
                    },
                    new Product
                    {
                        ProductId = 34, ProductName = "Sasquatch Ale", Category = "Beverages", UnitPrice = 14.0000m,
                        UnitsInStock = 111,
                    },
                    new Product
                    {
                        ProductId = 35, ProductName = "Steeleye Stout", Category = "Beverages", UnitPrice = 18.0000m,
                        UnitsInStock = 20,
                    },
                    new Product
                    {
                        ProductId = 38, ProductName = "Côte de Blaye", Category = "Beverages", UnitPrice = 263.5000m,
                        UnitsInStock = 17,
                    },
                    new Product
                    {
                        ProductId = 39, ProductName = "Chartreuse verte", Category = "Beverages", UnitPrice = 18.0000m,
                        UnitsInStock = 69,
                    },
                    new Product
                    {
                        ProductId = 43, ProductName = "Ipoh Coffee", Category = "Beverages", UnitPrice = 46.0000m,
                        UnitsInStock = 17,
                    },
                    new Product
                    {
                        ProductId = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages",
                        UnitPrice = 14.0000m, UnitsInStock = 52,
                    },
                    new Product
                    {
                        ProductId = 70, ProductName = "Outback Lager", Category = "Beverages", UnitPrice = 15.0000m,
                        UnitsInStock = 15,
                    },
                    new Product
                    {
                        ProductId = 75, ProductName = "Rhönbräu Klosterbier", Category = "Beverages",
                        UnitPrice = 7.7500m, UnitsInStock = 125,
                    },
                    new Product
                    {
                        ProductId = 76, ProductName = "Lakkalikööri", Category = "Beverages", UnitPrice = 18.0000m,
                        UnitsInStock = 57,
                    },
                }),
                ("Condiments", new Product[]
                {
                    new Product
                    {
                        ProductId = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.0000m,
                        UnitsInStock = 13,
                    },
                    new Product
                    {
                        ProductId = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
                        UnitPrice = 22.0000m, UnitsInStock = 53,
                    },
                    new Product
                    {
                        ProductId = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
                        UnitPrice = 21.3500m, UnitsInStock = 0,
                    },
                    new Product
                    {
                        ProductId = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments",
                        UnitPrice = 25.0000m, UnitsInStock = 120,
                    },
                    new Product
                    {
                        ProductId = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments",
                        UnitPrice = 40.0000m, UnitsInStock = 6,
                    },
                    new Product
                    {
                        ProductId = 15, ProductName = "Genen Shouyu", Category = "Condiments", UnitPrice = 15.5000m,
                        UnitsInStock = 39,
                    },
                    new Product
                    {
                        ProductId = 44, ProductName = "Gula Malacca", Category = "Condiments", UnitPrice = 19.4500m,
                        UnitsInStock = 27,
                    },
                    new Product
                    {
                        ProductId = 61, ProductName = "Sirop d'érable", Category = "Condiments", UnitPrice = 28.5000m,
                        UnitsInStock = 113,
                    },
                    new Product
                    {
                        ProductId = 63, ProductName = "Vegie-spread", Category = "Condiments", UnitPrice = 43.9000m,
                        UnitsInStock = 24,
                    },
                    new Product
                    {
                        ProductId = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments",
                        UnitPrice = 21.0500m, UnitsInStock = 76,
                    },
                    new Product
                    {
                        ProductId = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments",
                        UnitPrice = 17.0000m, UnitsInStock = 4,
                    },
                    new Product
                    {
                        ProductId = 77, ProductName = "Original Frankfurter grüne Soße", Category = "Condiments",
                        UnitPrice = 13.0000m, UnitsInStock = 32,
                    },
                }),
                ("Vegetables", Array.Empty<Product>()),
                ("Dairy Products", new Product[]
                {
                    new Product
                    {
                        ProductId = 11, ProductName = "Queso Cabrales", Category = "Dairy Products",
                        UnitPrice = 21.0000m, UnitsInStock = 22,
                    },
                    new Product
                    {
                        ProductId = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products",
                        UnitPrice = 38.0000m, UnitsInStock = 86,
                    },
                    new Product
                    {
                        ProductId = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products",
                        UnitPrice = 12.5000m, UnitsInStock = 0,
                    },
                    new Product
                    {
                        ProductId = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products",
                        UnitPrice = 32.0000m, UnitsInStock = 9,
                    },
                    new Product
                    {
                        ProductId = 33, ProductName = "Geitost", Category = "Dairy Products", UnitPrice = 2.5000m,
                        UnitsInStock = 112,
                    },
                    new Product
                    {
                        ProductId = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products",
                        UnitPrice = 55.0000m, UnitsInStock = 79,
                    },
                    new Product
                    {
                        ProductId = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products",
                        UnitPrice = 34.0000m, UnitsInStock = 19,
                    },
                    new Product
                    {
                        ProductId = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products",
                        UnitPrice = 36.0000m, UnitsInStock = 26,
                    },
                    new Product
                    {
                        ProductId = 71, ProductName = "Flotemysost", Category = "Dairy Products", UnitPrice = 21.5000m,
                        UnitsInStock = 26,
                    },
                    new Product
                    {
                        ProductId = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products",
                        UnitPrice = 34.8000m, UnitsInStock = 14,
                    },
                }),
                ("Seafood", new Product[]
                {
                    new Product
                    {
                        ProductId = 10, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.0000m,
                        UnitsInStock = 31,
                    },
                    new Product
                    {
                        ProductId = 13, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6.0000m,
                        UnitsInStock = 24,
                    },
                    new Product
                    {
                        ProductId = 18, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.5000m,
                        UnitsInStock = 42,
                    },
                    new Product
                    {
                        ProductId = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood",
                        UnitPrice = 25.8900m, UnitsInStock = 10,
                    },
                    new Product
                    {
                        ProductId = 36, ProductName = "Inlagd Sill", Category = "Seafood", UnitPrice = 19.0000m,
                        UnitsInStock = 112,
                    },
                    new Product
                    {
                        ProductId = 37, ProductName = "Gravad lax", Category = "Seafood", UnitPrice = 26.0000m,
                        UnitsInStock = 11,
                    },
                    new Product
                    {
                        ProductId = 40, ProductName = "Boston Crab Meat", Category = "Seafood", UnitPrice = 18.4000m,
                        UnitsInStock = 123,
                    },
                    new Product
                    {
                        ProductId = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood",
                        UnitPrice = 9.6500m, UnitsInStock = 85,
                    },
                    new Product
                    {
                        ProductId = 45, ProductName = "Rogede sild", Category = "Seafood", UnitPrice = 9.5000m,
                        UnitsInStock = 5,
                    },
                    new Product
                    {
                        ProductId = 46, ProductName = "Spegesild", Category = "Seafood", UnitPrice = 12.0000m,
                        UnitsInStock = 95,
                    },
                    new Product
                    {
                        ProductId = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood",
                        UnitPrice = 13.2500m, UnitsInStock = 62,
                    },
                    new Product
                    {
                        ProductId = 73, ProductName = "Röd Kaviar", Category = "Seafood", UnitPrice = 15.0000m,
                        UnitsInStock = 101,
                    },
                }),
            };

            CollectionAssert.AreEqual(expected, GroupJoinQuery());
        }

        [Test]
        public void LeftOuterJoinTest()
        {
            var expected = new[]
            {
                ("Beverages", "Chai"),
                ("Beverages", "Chang"),
                ("Beverages", "Guaraná Fantástica"),
                ("Beverages", "Sasquatch Ale"),
                ("Beverages", "Steeleye Stout"),
                ("Beverages", "Côte de Blaye"),
                ("Beverages", "Chartreuse verte"),
                ("Beverages", "Ipoh Coffee"),
                ("Beverages", "Laughing Lumberjack Lager"),
                ("Beverages", "Outback Lager"),
                ("Beverages", "Rhönbräu Klosterbier"),
                ("Beverages", "Lakkalikööri"),
                ("Condiments", "Aniseed Syrup"),
                ("Condiments", "Chef Anton's Cajun Seasoning"),
                ("Condiments", "Chef Anton's Gumbo Mix"),
                ("Condiments", "Grandma's Boysenberry Spread"),
                ("Condiments", "Northwoods Cranberry Sauce"),
                ("Condiments", "Genen Shouyu"),
                ("Condiments", "Gula Malacca"),
                ("Condiments", "Sirop d'érable"),
                ("Condiments", "Vegie-spread"),
                ("Condiments", "Louisiana Fiery Hot Pepper Sauce"),
                ("Condiments", "Louisiana Hot Spiced Okra"),
                ("Condiments", "Original Frankfurter grüne Soße"),
                ("Vegetables", "(No products)"),
                ("Dairy Products", "Queso Cabrales"),
                ("Dairy Products", "Queso Manchego La Pastora"),
                ("Dairy Products", "Gorgonzola Telino"),
                ("Dairy Products", "Mascarpone Fabioli"),
                ("Dairy Products", "Geitost"),
                ("Dairy Products", "Raclette Courdavault"),
                ("Dairy Products", "Camembert Pierrot"),
                ("Dairy Products", "Gudbrandsdalsost"),
                ("Dairy Products", "Flotemysost"),
                ("Dairy Products", "Mozzarella di Giovanni"),
                ("Seafood", "Ikura"),
                ("Seafood", "Konbu"),
                ("Seafood", "Carnarvon Tigers"),
                ("Seafood", "Nord-Ost Matjeshering"),
                ("Seafood", "Inlagd Sill"),
                ("Seafood", "Gravad lax"),
                ("Seafood", "Boston Crab Meat"),
                ("Seafood", "Jack's New England Clam Chowder"),
                ("Seafood", "Rogede sild"),
                ("Seafood", "Spegesild"),
                ("Seafood", "Escargots de Bourgogne"),
                ("Seafood", "Röd Kaviar"),
            };

            CollectionAssert.AreEqual(expected, LeftOuterJoin());
        }
    }
}
