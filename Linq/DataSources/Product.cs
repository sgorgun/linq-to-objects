using System;

namespace Linq.DataSources
{
    public sealed class Product : IEquatable<Product>
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Category { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public override string ToString()
        {
            return $"ProductId={this.ProductId} ProductName={this.ProductName} Category={this.Category} UnitPrice={this.UnitPrice:C2} UnitsInStock={this.UnitsInStock}";
        }

        public bool Equals(Product other)
        {
            return this.ProductId == other.ProductId && this.ProductName == other.ProductName && this.Category == other.Category && this.UnitPrice == other.UnitPrice && this.UnitsInStock == other.UnitsInStock;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return this.Equals((Product)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.ProductId, this.ProductName, this.Category, this.UnitPrice, this.UnitsInStock);
        }
    }
}
