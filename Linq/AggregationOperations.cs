﻿#pragma warning disable CA1829
using System;
using System.Collections.Generic;
using System.Linq;
using Linq.DataSources;

namespace Linq
{
    /// <summary>
    /// Considers the use aggregate operations (methods 'Min', 'Max', 'Count', 'Sum', 'Average', and `Aggregate`) in LINQ queries.
    /// Aggregation operation definition:
    /// <see cref="IEnumerable{TSource}"/> → scalar.
    /// An aggregation operation computes a single value from a collection of values.
    /// </summary>
    public static class AggregationOperations
    {
        /// <summary>
        /// Calculates the count of elements in sequence.
        /// </summary>
        /// <returns>Count of elements in sequence.</returns>
        public static int CountNumbers()
        {
            int[] numbers = { 2, 2, 3, 5, 5 };

            var query = numbers.Count();
            return query;
        }

        /// <summary>
        /// Calculates the number of odd numbers in the array.
        /// </summary>
        /// <returns>Count of of odd numbers in the array.</returns>
        public static int CountOddNumbers()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var query = numbers.Count(x => x % 2 == 0);
            return query;
        }

        /// <summary>
        /// Calculates for each customer count of his orders.
        /// </summary>
        /// <returns>The sequence of customers and how many orders each has.</returns>
        public static IEnumerable<(string customerId, int orderCount)> CustomersOrdersCount()
        {
            List<Customer> customers = Customers.CustomerList;

            var querry = customers
                .Select(c => (c.CustomerId, c.Orders.Count()));
            return querry;
        }

        /// <summary>
        /// Defines a sequence of categories and how many products each has.
        /// </summary>
        /// <returns>The sequence of categories and how many products each has.</returns>
        public static IEnumerable<(string category, int productCount)> ProductsInCategoryCount()
        {
            List<Product> products = Products.ProductList;

            var query = products
                .GroupBy(p => p.Category)
                .Select(g => (g.Key, g.Count()));
            return query;
        }

        /// <summary>
        /// Calculates the sum of the numbers in an array.
        /// </summary>
        /// <returns>Sum of elements of numbers.</returns>
        public static int Sum()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var query = numbers.Sum();
            return query;
        }

        /// <summary>
        /// Calculates the total number of characters of all words in the array.
        /// </summary>
        /// <returns>The total number of characters of all words in the array.</returns>
        public static int SumByLength()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var query = words.Select(x => x.Count()).Sum();
            return query;
        }

        /// <summary>
        /// Calculates the total units in stock for each product category.
        /// </summary>
        /// <returns>The total units in stock for each product category.</returns>
        public static IEnumerable<(string category, int totalUnitsInStock)> TotalUnitsInStock()
        {
            List<Product> products = Products.ProductList;

            var query = products
                .GroupBy(p => p.Category)
                .Select(g => (g.Key, g.Sum(p => p.UnitsInStock)));
            return query;
        }

        /// <summary>
        /// Calculates the lowest number in an array.
        /// </summary>
        /// <returns>The lowest number in an array.</returns>
        public static int Min()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var query = numbers.Min();
            return query;
        }

        /// <summary>
        /// Calculates the length of the shortest word in an array.
        /// </summary>
        /// <returns>The length of the shortest word in an array.</returns>
        public static int MinByLength()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var query = words.Select(x => x.Count()).Min();
            return query;
        }

        /// <summary>
        /// Calculates the cheapest price among each category's products.
        /// </summary>
        /// <returns>The cheapest price among each category's products.</returns>
        public static IEnumerable<(string category, decimal cheapestPrice)> GetCheapestPrice()
        {
            List<Product> products = Products.ProductList;

            var query = products
                .GroupBy(p => p.Category)
                .Select(g => (category: g.Key, cheapestPrice: g.Min(p => p.UnitPrice)));
            return query;
        }

        /// <summary>
        /// Calculates the highest number in an array.
        /// </summary>
        /// <returns>The highest number in an array.</returns>
        public static int Max()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var query = numbers.Max();
            return query;
        }

        /// <summary>
        /// Calculates the length of the longest word in an array.
        /// </summary>
        /// <returns>The length of the longest word in an array.</returns>
        public static int MaxByLength()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var query = words.Select(x => x.Count()).Max();
            return query;
        }

        /// <summary>
        /// Calculates the most expensive price among each category's products.
        /// </summary>
        /// <returns>The most expensive price among each category's products.</returns>
        public static IEnumerable<(string category, decimal mostExpensivePrice)> GetMostExpensivePrice()
        {
            List<Product> products = Products.ProductList;

            var query = products.GroupBy(p => p.Category)
                .Select(p => (category: p.Key, mostExpensivePrice: p.Max(p => p.UnitPrice)));
            return query;
        }

        /// <summary>
        /// Gets the average of all numbers in an array.
        /// </summary>
        /// <returns>The average of all numbers in an array.</returns>
        public static double Average()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var query = numbers.Average();
            return query;
        }

        /// <summary>
        /// Gets the average length of the words in the array.
        /// </summary>
        /// <returns>The average length of the words in the array.</returns>
        public static double AverageByLength()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var query = words.Select(x => x.Count()).Average();
            return query;
        }

        /// <summary>
        /// Gets the average price of each category's products.
        /// </summary>
        /// <returns>The average price of each category's products.</returns>
        public static IEnumerable<(string Category, decimal averagePrice)> AveragePrice()
        {
            List<Product> products = Products.ProductList;

            var query = products.GroupBy(p => p.Category)
                .Select(p => (Сategory: p.Key, averagePrice: p.Average(p => p.UnitPrice)));
            return query;
        }

        /// <summary>
        /// Calculates the total product of all elements.
        /// </summary>
        /// <returns>The total product of all elements.</returns>
        public static double Aggregate()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var query = doubles.Aggregate((x, y) => x * y);
            return query;
        }

        /// <summary>
        /// Subtracts each withdrawal from the initial balance of 100, as long as the balance never drops below 0.
        /// </summary>
        /// <returns>Final balance.</returns>
        public static double SeededAggregate()
        {
            double startBalance = 100.0;

            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            var finalBalance = attemptedWithdrawals
                .Aggregate(startBalance, (balance, withdrawal) => balance - withdrawal >= 0 ? balance - withdrawal : balance);
            return finalBalance;
        }
    }
}
