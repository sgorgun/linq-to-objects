using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq.DataSources
{
    public static class Customers
    {
        public static List<Customer> CustomerList { get; } =
            (from e in XDocument.Parse(InputValues.CustomersXml).Root?.Elements("customer")
             select new Customer
             {
                 CustomerId = (string)e.Element("id"),
                 CompanyName = (string)e.Element("name"),
                 Address = (string)e.Element("address"),
                 City = (string)e.Element("city"),
                 Region = (string)e.Element("region"),
                 PostalCode = (string)e.Element("postalcode"),
                 Country = (string)e.Element("country"),
                 Phone = (string)e.Element("phone"),
                 Orders = (
                     from o in e.Elements("orders").Elements("order")
                     select new Order
                     {
                         OrderId = (int)o.Element("id"),
                         OrderDate = (DateTime)o.Element("orderdate"),
                         Total = (decimal)o.Element("total"),
                     }).ToArray(),
             }).ToList();
    }
}
