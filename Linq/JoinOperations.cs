﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Linq.DataSources;

namespace Linq
{
    /// <summary>
    /// Considers use join operations (methods 'Join', 'GroupJoin' and 'join' keyword) in LINQ queries.
    /// Join and GroupJoin definition:
    /// <see cref="IEnumerable{TOuter}"/>, <see cref="IEnumerable{TInner}"/> → <see cref="IEnumerable{TResult}"/>
    /// A join of two data sources is the association of objects in one data source with objects
    /// that share a common attribute in another data source.
    /// </summary>
    public static class JoinOperations
    {
        /// <summary>
        /// Joins two sequences based on Category and extracts pairs of values.
        /// </summary>
        /// <returns>Result of joining based on Category of elements of two sequences.</returns>
        public static IEnumerable<(string category, string productName)> JoinQuery()
        {
            string[] categories =
            {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood",
            };

            List<Product> products = Products.ProductList;

            var query = categories
                .Join(products, category => category, product => product.Category, (category, product) => (category, product.ProductName));

            return query;
        }

        /// <summary>
        /// Gets all the products that match a given category.
        /// </summary>
        /// <returns>All the products that match a given category bundled as a sequence.</returns>
        public static IEnumerable<(string category, IEnumerable<Product> productsName)> GroupJoinQuery()
        {
            string[] categories =
            {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood",
            };

            List<Product> products = Products.ProductList;

            var query = categories
                .GroupJoin(products, category => category, product => product.Category, (category, product) => (category, product));

            return query;
        }

        /// <summary>
        /// Joins two sequences based on Category and extracts pairs of values.
        /// If the category has no products, it is included in the resulting sequence with the value "(No products)"
        /// Note how `Vegetables` shows up in the output even though it has no matching products.
        /// </summary>
        /// <returns>Result of joining of elements of two sequences.</returns>
        public static IEnumerable<(string category, string productName)> LeftOuterJoin()
        {
            string[] categories =
            {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood",
            };

            List<Product> products = Products.ProductList;

            var query = categories
               .GroupJoin(products, category => category, product => product.Category, (category, product) => (category, product))
               .SelectMany(x => x.product.DefaultIfEmpty(), (category, product) => (category.category, productName: product?.ProductName ?? "(No products)"));

            return query;
        }
    }
}
