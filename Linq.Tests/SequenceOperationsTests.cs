using NUnit.Framework;
using static Linq.SequenceOperations;

namespace Linq.Tests
{
    [TestFixture]
    public class SequenceOperationsTests
    {
        [Test]
        public void ConcatSeriesTest()
        {
            var expected = new[] { 0, 2, 4, 5, 6, 8, 9, 1, 3, 5, 7, 8 };
            CollectionAssert.AreEqual(expected, ConcatSeries());
        }

        [Test]
        public void ConcatConcatProjectionTest()
        {
            var expected = new[]
            {
                "Alfreds Futterkiste", "Ana Trujillo Emparedados y helados", "Antonio Moreno Taquería",
                "Around the Horn", "Berglunds snabbköp", "Blauer See Delikatessen", "Blondel père et fils",
                "Bólido Comidas preparadas", "Bon app'", "Bottom-Dollar Markets", "B's Beverages",
                "Cactus Comidas para llevar", "Centro comercial Moctezuma", "Chop-suey Chinese", "Comércio Mineiro",
                "Consolidated Holdings", "Drachenblut Delikatessen", "Du monde entier", "Eastern Connection",
                "Ernst Handel", "Familia Arquibaldo", "FISSA Fabrica Inter.Salchichas S.A.", "Folies gourmandes",
                "Folk och fä HB", "Frankenversand", "France restauration", "Franchi S.p.A.",
                "Furia Bacalhau e Frutos do Mar", "Galería del gastrónomo", "Godos Cocina Típica",
                "Gourmet Lanchonetes", "Great Lakes Food Market", "GROSELLA-Restaurante", "Hanari Carnes",
                "HILARIÓN-Abastos", "Hungry Coyote Import Store", "Hungry Owl All-Night Grocers", "Island Trading",
                "Königlich Essen", "La corne d'abondance", "La maison d'Asie", "Laughing Bacchus Wine Cellars",
                "Lazy K Kountry Store", "Lehmanns Marktstand", "Let's Stop N Shop", "LILA-Supermercado",
                "LINO-Delicateses", "Lonesome Pine Restaurant", "Magazzini Alimentari Riuniti", "Maison Dewey",
                "Mère Paillarde", "Morgenstern Gesundkost", "North/South", "Océano Atlántico Ltda.",
                "Old World Delicatessen", "Ottilies Käseladen", "Paris spécialités", "Pericles Comidas clásicas",
                "Piccolo und mehr", "Princesa Isabel Vinhos", "Que Delícia", "Queen Cozinha", "QUICK-Stop",
                "Rancho grande", "Rattlesnake Canyon Grocery", "Reggiani Caseifici", "Ricardo Adocicados",
                "Richter Supermarkt", "Romero y tomillo", "Santé Gourmet", "Save-a-lot Markets", "Seven Seas Imports",
                "Simons bistro", "Spécialités du monde", "Split Rail Beer & Ale", "Suprêmes délices", "The Big Cheese",
                "The Cracker Box", "Toms Spezialitäten", "Tortuga Restaurante", "Tradição Hipermercados",
                "Trail's Head Gourmet Provisioners", "Vaffeljernet", "Victuailles en stock",
                "Vins et alcools Chevalier", "Die Wandernde Kuh", "Wartian Herkku", "Wellington Importadora",
                "White Clover Markets", "Wilman Kala", "Wolski Zajazd", "Chai", "Chang", "Aniseed Syrup",
                "Chef Anton's Cajun Seasoning", "Chef Anton's Gumbo Mix", "Grandma's Boysenberry Spread",
                "Uncle Bob's Organic Dried Pears", "Northwoods Cranberry Sauce", "Mishi Kobe Niku", "Ikura",
                "Queso Cabrales", "Queso Manchego La Pastora", "Konbu", "Tofu", "Genen Shouyu", "Pavlova",
                "Alice Mutton", "Carnarvon Tigers", "Teatime Chocolate Biscuits", "Sir Rodney's Marmalade",
                "Sir Rodney's Scones", "Gustaf's Knäckebröd", "Tunnbröd", "Guaraná Fantástica",
                "NuNuCa Nuß-Nougat-Creme", "Gumbär Gummibärchen", "Schoggi Schokolade", "Rössle Sauerkraut",
                "Thüringer Rostbratwurst", "Nord-Ost Matjeshering", "Gorgonzola Telino", "Mascarpone Fabioli",
                "Geitost", "Sasquatch Ale", "Steeleye Stout", "Inlagd Sill", "Gravad lax", "Côte de Blaye",
                "Chartreuse verte", "Boston Crab Meat", "Jack's New England Clam Chowder",
                "Singaporean Hokkien Fried Mee", "Ipoh Coffee", "Gula Malacca", "Rogede sild", "Spegesild",
                "Zaanse koeken", "Chocolade", "Maxilaku", "Valkoinen suklaa", "Manjimup Dried Apples", "Filo Mix",
                "Perth Pasties", "Tourtière", "Pâté chinois", "Gnocchi di nonna Alice", "Ravioli Angelo",
                "Escargots de Bourgogne", "Raclette Courdavault", "Camembert Pierrot", "Sirop d'érable",
                "Tarte au sucre", "Vegie-spread", "Wimmers gute Semmelknödel", "Louisiana Fiery Hot Pepper Sauce",
                "Louisiana Hot Spiced Okra", "Laughing Lumberjack Lager", "Scottish Longbreads", "Gudbrandsdalsost",
                "Outback Lager", "Flotemysost", "Mozzarella di Giovanni", "Röd Kaviar", "Longlife Tofu",
                "Rhönbräu Klosterbier", "Lakkalikööri", "Original Frankfurter grüne Soße",
            };

            CollectionAssert.AreEqual(expected, ConcatProjection());
        }

        [Test]
        public void DotProductTest()
        {
            Assert.AreEqual(109, DotProduct());
        }
    }
}
